using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class LinearFunction
    {
        private double _y;
        private double _x;
        private double _k;
        private double _b;
        // y=k*x+b
        public double y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }
        public double x
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }
        public double k
        {
            get
            {
                return _k;
            }

            set
            {
                _k = value;
            }
        }
        public double b
        {
            get
            {
                return _b;
            }

            set
            {
                _b = value;
            }
        }
        public LinearFunction(double K, double B)
        {
            k = K;
            b = B;
        }
        public LinearFunction()
        {
            k = 0;
            b = 0;
        }

        public static implicit operator string(LinearFunction ob1)
        {
            string res = "\ny=" + ob1.k + "x" + "+" + ob1.b;
            return res;
        }
        public static LinearFunction operator +(LinearFunction ob1, LinearFunction ob2)
        {
            LinearFunction res = new LinearFunction();
            res.k = ob1.k + ob2.k;
            res.b = ob1.b + ob2.b;
            return res;
        }
        public static LinearFunction operator -(LinearFunction ob1, LinearFunction ob2)
        {
            LinearFunction res = new LinearFunction();
            res.k = ob1.k - ob2.k;
            res.b = ob1.b - ob2.b;
            return res;
        }
        public static bool operator >(LinearFunction ob1, LinearFunction ob2)
        {
            if (ob1.k > ob2.k || ob1.b > ob2.b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(LinearFunction ob1, LinearFunction ob2)
        {
            if (ob1.k < ob2.k || ob1.b < ob2.b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(LinearFunction ob1, LinearFunction ob2)
        {
            if (ob1.k != ob2.k && ob2.b != ob2.b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(LinearFunction ob1, LinearFunction ob2)
        {
            if (ob1.k == ob2.k && ob2.b == ob2.b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(LinearFunction ob1, LinearFunction ob2)
        {
            if (ob1.k <= ob2.k && ob2.b <= ob2.b)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator >=(LinearFunction ob1, LinearFunction ob2)
        {
            if (ob1.k >= ob2.k && ob2.b >= ob2.b)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

       
    }
}