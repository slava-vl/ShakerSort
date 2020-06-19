using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ShakerSort
{
    public partial class MainForm : Form
    {
        int countGlob;//Длина массива
        Dictionary<int,int> realChart = new Dictionary<int, int>(); //Словарь полученных данных
        int[] nums;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TeoreticChartFill();
            RealChartFill();
        }
        private void RealChartFill()
        {

        }

        private void TeoreticChartFill()
        {
            for (int i = 0; i < 10000; i+=100)
            {
            }
        }

        /// <summary>
        /// Шейкер-сортировка
        /// </summary>
        private void shakerSort()
        {
            Stopwatch stopWatch = new Stopwatch();//Таймер, замеряющий время выполнения сортировки 
            stopWatch.Start(); //Запуск таймера

            int left = 0, right = countGlob - 1; // левая и правая границы сортируемой области массива
            int flag = 1;  // флаг наличия перемещений
            int t;// вспомогательная переменная
            // Цикл выполняется пока левая граница не сомкнётся с правой и пока в массиве имеются перемещения
            while ((left < right) && flag > 0)
            {
                flag = 0;
                for (int i = left; i < right; i++)  //двигаемся слева направо
                {
                    if (nums[i] > nums[i + 1])
                    {
                        t = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = t;
                        flag = 1;
                    }
                }
                right--; // сдвигаем правую границу на предыдущий элемент
                
                for (int i = right; i > left; i--)  //двигаемся справа налево
                {
                    if (nums[i - 1] > nums[i])
                    {
                        t = nums[i];
                        nums[i] = nums[i - 1];
                        nums[i - 1] = t;
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
            textBoxTime.Text = elapsedTime;

            //Перевожу время с таймера в миллисекунды
            int milisec = ts.Seconds * 1000 + ts.Milliseconds;

            //Добавляю полученные данные в словарь
            if (!chart.ContainsKey(countGlob))
                chart.Add(countGlob, milisec);
            else chart[countGlob] = milisec;
        }

        /// <summary>
        /// Запрет на нажатие любых клавишь, кроме цифр, backspace, пробела
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 32) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

            countGlob = int.Parse(textBoxCount.Text);
            TransformToIntMass();
            shakerSort();
            AddNumsToTextBoxAfterSort();
        }

        private void AddNumsToTextBoxAfterSort()
        {
            textBoxAfterSort.Clear();
            string s="";
            for (int i = 0; i < countGlob; i++)
            {
                s += nums[i] + " ";
            }
            textBoxAfterSort.Text = s;
        }

        private void TransformToIntMass()
        {
            nums = new int[countGlob];
            string[] textmas = textBoxNums.Text.Split();
            for (int i = 0; i < countGlob; i++)
            {
                nums[i] = int.Parse(textmas[i]);
            }
        }

        /// <summary>
        /// Заполнение textBoxNums случайными числами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            textBoxNums.Clear();
            countGlob = int.Parse(textBoxCount.Text);
            Random rd = new Random();
            string s="";
            for (int i = 0; i < countGlob; i++)
            {
                 s+= rd.Next(int.MinValue, int.MaxValue) +" ";

            }
            textBoxNums.Text = s;
        }

        private void ImportFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var excelOpen = new OpenFileDialog
            {
                Filter = "|*.txt"
            };
            if (excelOpen.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(excelOpen.FileName))
                {

                    textBoxCount.Text = sr.ReadLine();
                    textBoxNums.Text = sr.ReadToEnd();
                }
            }
        }

    }
}
