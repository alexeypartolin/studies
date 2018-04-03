using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

   
    
    public partial class MainWindow : Window
    {

        private string func1;
        private string func2;
        public string function1
        {
            get
            {
                return func1;
            }
            set
            {
                func1 = value;
            }
        }
        public string function2
        {
            get
            {
                return func2;
            }
            set
            {
                func2 = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;



        }

        private void ParseBtn_Click(object sender, RoutedEventArgs e)
        {
            function1 = TextBox1.Text;
            function2 = TextBox2.Text;
            MessageBox.Show($"First func: {function1}" +
                $"\nSecond func: {function2}");

            // split first function
            int k1, b1;
            string[] func1str1, func1str2, func1str3;
            func1str2 = function1.Split('+');
            b1 = int.Parse(func1str2[1]);
            func1str1 = func1str2[0].Split('=');
            func1str3 = func1str1[1].Split('x');
            b1 = int.Parse(func1str3[0]);
            k1 = int.Parse(func1str2[1]);

            // split second function

            int k2, b2;
            string[] func2str1, func2str2, func2str3;
            func2str2 = function2.Split('+');
            b2 = int.Parse(func2str2[1]);
            func2str1 = func2str2[0].Split('=');
            func2str3 = func2str1[1].Split('x');
            b2 = int.Parse(func2str3[0]);
            k2 = int.Parse(func2str2[1]);

            // output
            output1.Content = "k=" + (Convert.ToString(b1)) + " b=" + (Convert.ToString(k1));
            output2.Content = "k=" + (Convert.ToString(b2)) + " b=" + (Convert.ToString(k2));

            LinearFunction l1 = new LinearFunction(b1, k1);
            LinearFunction l2 = new LinearFunction(b2, k2);

            MessageBox.Show("Сложение: " + (l1 + l2));
            MessageBox.Show("Разность: " + (l1 - l2));
            
            //Сравнение
            if(l1 > l2)
            {
                MessageBox.Show("Первая линейная функция больше второй");
            }
            else if(l1 == l2)
            {
                MessageBox.Show("Функции равны");
            }
            else if(l1 != l2)
            {
                MessageBox.Show("Функции не равны");
            }
            else
            {
                MessageBox.Show("Вторая линейная функция больше первой");
            }

           


            


        }
    }
}
