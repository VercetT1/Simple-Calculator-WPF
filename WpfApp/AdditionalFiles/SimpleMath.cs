using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp.AdditionalFiles
{
    internal static class SimpleMath
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Substraction(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                MessageBox.Show("Cant divide by 0", "Wrong Operation",MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }
            return x / y;
        }
    }
}
