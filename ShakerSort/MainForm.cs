using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShakerSort
{
    public partial class MainForm : Form
    {
        int countGlob;//Длина массива
        Dictionary<int,int> chart = new Dictionary<int, int>(); //Словарь полученных данных
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Шейкер-сортировка
        /// </summary>
        private void shekerSort(int count, int[] mass)
        {
            Stopwatch stopWatch = new Stopwatch();//Таймер, замеряющий время выполнения сортировки 
            stopWatch.Start(); //Запуск таймера

            int left = 0, right = count - 1; // левая и правая границы сортируемой области массива
            int flag = 1;  // флаг наличия перемещений
            int t;// вспомогательная переменная
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

            stopWatch.Stop();//Остановка таймера

            // Задаю формат и вывожу время с таймера
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            textBoxTime.Text = elapsedTime;//Вывод в textBox

            //Перевожу время с таймера в миллисекунды
            int milisec = ts.Seconds * 1000 + ts.Milliseconds;

            //Добавляю полученные данные в словарь
            if (!chart.ContainsKey(count))
                chart.Add(count, milisec);
            else chart[count] = milisec;
        }

        /// <summary>
        /// Создание массива TextBox-ов на панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCount_Click(object sender, EventArgs e)
        {
            countGlob = int.Parse(textBoxCount.Text);//Длина массива
            for (int i = 1; i < countGlob; i+= countGlob/10)
            {
                int[] mass = new int[i];
                Random rnd = new Random();
                for (int j = 0; j < mass.Length; j++)
                {
                    mass[j] = rnd.Next(-1000, 1000);
                }
                shekerSort(mass.Length, mass);
                var sortedDict = new SortedDictionary<int, int>(chart);
                chartTimeFromCount.Series["Время"].Points.Clear();
                foreach (var item in sortedDict)
                {
                    chartTimeFromCount.Series["Время"].Points.AddXY(item.Key, item.Value);

                }
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
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
