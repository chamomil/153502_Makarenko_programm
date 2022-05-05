using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    public class Equation
    {
        private int a;
        private int b;
        private int c;

        public Equation(int a2, int b2, int c2)
        {
            this.a = a2; this.b = b2; this.c = c2;
        }

        public int this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return a;
                        break;
                    case 1: return b;
                        break;
                    case 2: return c;
                        break;
                    default: return -1;
                }
            }
            set
            {
                if (value < 0 || value > 2) i = -1;
                else i = value;
            }
        }

        public void Find()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0) Console.WriteLine("The root of the equation is any number");
                    else Console.WriteLine("No roots");
                }
                else
                {
                    if (c != 0) Console.WriteLine("The root of the equation is " + (-c / b));
                    else Console.WriteLine("The root of the equation is 0");
                }
            }
            else
            {
                if (b == 0) {
                    if (c == 0) Console.WriteLine("The root of the equation is 0");
                    else
                    {
                        if (-c / a >= 0) Console.WriteLine("The roots of the equation are " + Math.Sqrt(-c / a) + " and " + (-Math.Sqrt(-c / a)));
                        else Console.WriteLine("Roots are irrational");
                    }
                }                    
                else
                {
                    if (c == 0)
                    {
                        double x = -b / a;
                        Console.WriteLine("The roots of the equation are 0 and " + x);
                    }
                    else
                    {
                        int dis = b * b - 4 * a * c;
                        if (dis < 0) Console.WriteLine("No roots");
                        else if (dis == 0)
                        {
                            double x1 = (-b) / (2 * a);
                            Console.WriteLine("The root of the equation is " + x1);
                        }
                        else
                        {
                            double x1 = (-b - Math.Sqrt(dis)) / (2 * a);
                            double x2 = (-b + Math.Sqrt(dis)) / (2 * a);
                            Console.WriteLine("The roots of the equation are " + x1 + " and " + x2);
                        }
                    }
                }
            }
        }

        public static Equation operator +(Equation first, int second)
        {
            first.a += second;
            first.b += second;
            first.c += second;
            return first;
        }

        public static Equation operator -(Equation first, int second)
        {
            return (first + (-second));
        }

        public static Equation operator ++(Equation first)
        {
            return new Equation(first.a + 1, first.b + 1, first.c + 1);
        }

        public static Equation operator --(Equation first)
        {
            return new Equation(first.a - 1, first.b - 1, first.c - 1);
        }

        public static Equation operator *(Equation first, int second)
        {
            first.a *= second;
            first.b *= second;
            first.c *= second;
            return first;
        }

        public static Equation operator /(Equation first, int second)
        {
            first.a /= second;
            first.b /= second;
            first.c /= second;
            return first;
        }

        public static bool operator ==(Equation first, Equation second)
        {
            if (first.a != second.a) return false;
            if (first.b != second.b) return false;
            if (first.c != second.c) return false;
            return true;
        }

        public static bool operator !=(Equation first, Equation second)
        {
            return !(first == second);
        }

        public static bool operator true(Equation tmp)
        {
            return !((tmp.a != 0 && tmp.b != 0 && tmp.b * tmp.b + 4 * tmp.a * tmp.c < 0) || (tmp.a == 0 && tmp.b == 0 && tmp.c != 0));
        }

        public static bool operator false(Equation tmp)
        {
            return ((tmp.a != 0 && tmp.b != 0 && tmp.b * tmp.b + 4 * tmp.a * tmp.c < 0) || (tmp.a == 0 && tmp.b == 0 && tmp.c != 0));
        }

        public static explicit operator int(Equation tmp)
        {
            return tmp.a;
        }

        public static explicit operator Equation(int tmp)
        {
            return new Equation(tmp, 0, 0);
        }

        public override string ToString()
        {
            string s = "";
            bool first = true;
            if (a != 0) { s += a.ToString() + "*x^2 "; first = false; }
            if (b != 0)
            {
                if (b > 0 && !first) s += "+ ";
                s += b.ToString() + "*x ";
                first = false;
            } 
            if (c != 0)
            {
                if (c > 0 && !first) s += "+ ";
                s += c.ToString() + " = 0";
                first = false;
            }
            if (first) s = "0 = 0";
            return s;
        }
    }
}
