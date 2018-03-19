using System;

namespace ConsoleApp2
{
    class Complex
    {
        private double R, I;
        
        public double Re
        {
            get
            {
                return R;
            }
            set
            {
                R = value;
            }
        }
        public double Im
        {
            get
            {
                return I;
            }
            set
            {
                I = value;
            }
        }




        public Complex (double a, double b)
        {
            this.Re = a;
            this.Im = b;
        }

        // Пустой конструктор для создания пустых объектов
        public Complex ()
        {
            
        }
        

        public double Module()
        {
            return Math.Abs(this.Re*this.Re/this.Im*this.Im);
        }

        public double Argument()
        {
            double a = Math.Atan(this.Re / this.Im) + Math.PI;
            return Math.Round(a, 2); // округляем
        }

        public void Print()
        {
            Console.WriteLine("\n***Данные комплексного числа***");
            Console.WriteLine("Действительная часть: " + this.Re);
            Console.WriteLine("Мнимая часть: " + this.Im);
            Console.WriteLine("Модуль: " + Module());
            Console.WriteLine("Аргумент: " + Argument());
        }

        public static explicit operator double(Complex a)
        {
            double res = a.Re + a.Im;
            return res;
        }

        // Статичный метод для вычесления суммы
        public static Complex Sum(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.Re = a.Re + b.Re;
            res.Im = a.Im + b.Im;
            return res;
        }
        //Перегрузка оператора +
        public static Complex operator +(Complex a, Complex b)
        {
            return Sum(a,b);
        }

        
      

    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex compl1 = new Complex(1, 2);
            Complex compl2 = new Complex(3, 4);

            compl1.Print();
            compl2.Print();

            Console.WriteLine(Complex.Sum(compl1, compl2));

            Console.ReadKey();
        }
    }
}
