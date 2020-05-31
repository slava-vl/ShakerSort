using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShakerSort
{
    public partial class MainForm : Form
    {
        double[] globalMass;//Массив значений
        int countGlobMas;//Длина массива
        Dictionary<int,int> chart = new Dictionary<int, int>(); //Словарь полученных данных
        TextBox[] tm;
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Шейкер-сортировка
        /// </summary>
        private void shekerSort(double[] mass, int count)
        {
            Stopwatch stopWatch = new Stopwatch();//Таймер, замеряющий время выполнения сортировки 
            stopWatch.Start(); //Запуск таймера

            int left = 0, right = count - 1; // левая и правая границы сортируемой области массива
            int flag = 1;  // флаг наличия перемещений
            double t;// вспомогательная переменная
            // Цикл выполняется пока левая граница не сомкнётся с правой и пока в массиве имеются перемещения
            while ((left < right) && flag > 0)
            {
                flag = 0;
                for (int i = left; i < right; i++)  //двигаемся слева направо
                {
                    if (mass[i] > mass[i + 1])
                    {
                        t = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = t;
                        flag = 1;
                    }
                }
                right--; // сдвигаем правую границу на предыдущий элемент
                
                for (int i = right; i > left; i--)  //двигаемся справа налево
                {
                    if (mass[i - 1] > mass[i])
                    {
                        t = mass[i];
                        mass[i] = mass[i - 1];
                        mass[i - 1] = t;
                        flag = 1;
                    }
                }
                left++; // сдвигаем левую границу на следующий элемент
            }
            AddChangeToForm();//Вывожу изменения на панель

            stopWatch.Stop();//Остановка таймера

            // Задаю формат и вывожу время с таймера
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            textBoxTime.Text +=count+" - " +elapsedTime+"\n";//Вывод в textBox

            //Перевожу время с таймера в миллисекунды
            int milisec = ts.Seconds * 1000 + ts.Milliseconds;

            //Добавляю полученные данные в словарь
            if (!chart.ContainsKey(count))
                chart.Add(count, milisec);
            else chart[count] = milisec;
        }


        /// <summary>
        /// Отображает изменения на TextBox-ы
        /// </summary>
        private void AddChangeToForm() 
        {
            for (int i = 0; i < countGlobMas; i++)
            {
                tm[i].Text = globalMass[i].ToString();
            }
        }

        /// <summary>
        /// Создание массива TextBox-ов на панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCount_Click(object sender, EventArgs e)
        {
            try
            {
                panelMas.Controls.Clear();
                countGlobMas = int.Parse(textBoxCount.Text);//Длина массива
                globalMass = new double[countGlobMas];
                tm = new TextBox[countGlobMas];
                int width = panelMas.Width / 25;//Ширина одного textBox
                int height = panelMas.Height;//Высота одного textBox
                for (int j = 0; j < countGlobMas; j++)
                {
                    tm[j] = new TextBox
                    {
                        Multiline = true,
                        Width = width,
                        Height = height,
                        Left = j * width,//Положение по горизонтали
                        Tag = j
                    };
                    tm[j].TextChanged += tchanged;
                    tm[j].KeyPress += textBoxKeyPress;
                    panelMas.Controls.Add(tm[j]);//Добавление textBox на панель

                }
            }
            catch 
            {
                MessageBox.Show("Невозможно создать массив из такого количества элементов");
            }
            
        }
        private void buttonSortAll_Click(object sender, EventArgs e)
        {
            textBoxTime.Text = "";
            shekerSort(globalMass, countGlobMas);
            var sortedDict = new SortedDictionary<int, int>(chart);
            chartTimeFromCount.Series["Время"].Points.Clear();
            foreach (var item in sortedDict)
            {
                chartTimeFromCount.Series["Время"].Points.AddXY(item.Key, item.Value);

            }

        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            textBoxCount.Clear();//Очищаю текстбокс с числом элементов для последующего использования
            int t = 0;
            textBoxTime.Text="";
            for (int i = 0; i < 50; i++)
            {
                int n = countGlobMas / 100 * (i + 1);
                if (t + n <= countGlobMas)
                {
                    double[] mas = new double[n];

                    for (int j = t; j < t + n; j++)
                    {
                        mas[j - t] = globalMass[j];
                    }
                    shekerSort(mas, n);
                    var sortedDict = new SortedDictionary<int, int>(chart);
                    chartTimeFromCount.Series["Время"].Points.Clear();
                    foreach (var item in sortedDict)
                    {
                        chartTimeFromCount.Series["Время"].Points.AddXY(item.Key, item.Value);

                    }
                    t += n;
                }
                else break;
            
            }
            
        }

        /// <summary>
        /// Заполнение массива случайными числами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < countGlobMas; i++)
            {
                tm[i].Text = rnd.Next(-1000, 1000).ToString();
            }
        }

        /// <summary>
        /// Запрет на нажатие любых клавишь, кроме цифр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Функция, изменяющая содержимое массива на основе текстбоксов на панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tchanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            int a = Convert.ToInt32(t.Tag.ToString());//По тегу обращаюсь к созданному TextBox
            globalMass[a] = double.Parse(t.Text);

        }
    }
}
