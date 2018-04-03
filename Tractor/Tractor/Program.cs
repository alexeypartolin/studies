using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tractor
{
    class Tractor
    {
        // Класс тягача

        private double _id; // номер тягача
        private double _mass; // масса
        private double _force; // сила тяги
        private double _fuelTank; // объем топливного бака 
        private double _fuelKm; // расход топлива на 1 киллометр
        private double _massInput; // Задаем ручками в консоле массу
        private double _distanceInput; // Задаем ручками в консоле расстояние


        public double id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public double mass
        {
            get
            {
                return _mass;
            }
            set
            {
                _mass = value;
            }
        }
        public double force
        {
            get
            {
                return _force;
            }
            set
            {
                _force = value;
            }
        }
        public double fuelTank
        {
            get
            {
                return _fuelTank;
            }
            set
            {
                _fuelTank = value;
            }
        }
        public double fuelKm
        {
            get
            {
                return _fuelKm;
            }
            set
            {
                _fuelKm = value;
            }
        }
        public double massInput
        {
            get
            {
                return _massInput;
            }
            set
            {
                _massInput = value;
            }
        }
        public double distanceInput
        {
            get
            {
                return _distanceInput;
            }
            set
            {
                _distanceInput = value;
            }
        }

            
        // Конструктор
        public Tractor(double a, double b, double c, double d, double f)
        {
            id = a;
            mass = b;
            force = c;
            fuelTank = d;
            fuelKm = f;
        }

        public Tractor()
        {
            id = 0;
            mass = 0;
            force = 0;
            fuelTank = 0;
            fuelKm = 0;
        }

        public static void Input(Tractor ob)
        {
            Console.WriteLine("Какую массу требуется перевезти [в тоннах]?");
            ob.massInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Какую дистанцию требуется преодолеть [в км]?");
            ob.distanceInput = Convert.ToDouble(Console.ReadLine());
            // Print
            Console.WriteLine("Требуется перевезти " + ob.massInput + "(т)" + " на " + ob.distanceInput + "(км)");
        }

        // Метод сложения (суммирования) усилий
        public static double Sum(Tractor a, Tractor b, Tractor c)
        {
            return (a.force + b.force + c.force);
        }

        // Метод определения дальности поездки ДЛЯ КАЖДОГО ТЯГАЧА по отдельности
        public static double Distance(Tractor a)
        {
            return (a.fuelTank / a.fuelKm);
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Для конструктора:
            // id, масса которую может поднять тягач в тоннах, сила тяги (!)в тоннах (формальность), объем бака в литрах, расход/1км
            Tractor t1 = new Tractor(1, 5000, 30, 500, 3.40);
            Tractor t2 = new Tractor(2, 8000, 60, 750, 7.50);
            Tractor t3 = new Tractor(3, 11000, 90, 1000, 12.70);
            // Создано три тягача

            // Формально
            Tractor forInput = new Tractor();

            Tractor.Input(forInput); // Ввод с клавиатуры

            double a = Tractor.Sum(t1,t2,t3);
            Console.WriteLine("\nСуммарные усилия трех тягачей = {0}(т)", a);



            // Рассчитываем дальность поездки и округляем к наименьшему целому
            double distance1, distance2, distance3;
            distance1 = Math.Floor(Tractor.Distance(t1));
            distance2 = Math.Floor(Tractor.Distance(t2));
            distance3 = Math.Floor(Tractor.Distance(t3));
            

            Console.WriteLine("\n1 тягач может проехать = {0}(км)", distance1);
            Console.WriteLine("2 тягач может проехать = {0}(км)", distance2);
            Console.WriteLine("3 тягач может проехать = {0}(км)", distance3);

            double force1, force2, force3;
            force1 = t1.force;
            force2 = t2.force;
            force3 = t3.force;

            Console.WriteLine("Усилия 1 тягача = {0}(т)", force1);
            Console.WriteLine("Усилия 2 тягача = {0}(т)", force2);
            Console.WriteLine("Усилия 3 тягача = {0}(т)", force3);

            // для 1 тягача
            if (distance1 < forInput.distanceInput || force1 < forInput.massInput)
            {
                Console.WriteLine("Первый тягач не подходит");
            }
            else
            {
                Console.WriteLine("Первый тягач подходит");
            }
            // для 2 тягача
            if (distance2 < forInput.distanceInput || force2 < forInput.massInput)
            {
                Console.WriteLine("Второй тягач не подходит");
            }
            else
            {
                Console.WriteLine("Второй тягач подходит");
            }
            // для 3 тягача 
            if (distance3 < forInput.distanceInput || force3 < forInput.massInput)
            {
                Console.WriteLine("Третий тягач не подходит");
            }
            else
            {
                Console.WriteLine("Третий тягач подходит");
            }
                
            // Теперь определяем, СКОЛЬКО тягачей нужно




            Console.ReadKey();
        }
    }
}
