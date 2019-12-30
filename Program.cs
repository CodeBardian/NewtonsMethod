// Jakob Wilhelm, 11.12.2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace NewtonEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            NewtonIteration(-1, 1);      //enter start of iteration
            NewtonIteration(-1, -1);
            NewtonIteration(1, 1);
            NewtonIteration(1, -1);
            Console.ReadKey();
        }

        private static void NewtonIteration(double x, double y)
        {
            Vector xCurrent = new Vector(x, y);
            Vector fx;
            Vector d;
            int cnt = 0;

            do
            {
                double[,] df = new double[,] { { 2 * xCurrent.X, 1 }, { 1, 2 * xCurrent.Y } };     //enter partial derivative 
                Console.WriteLine("{0,20} {1,20} {2,20}", cnt++, xCurrent.X, xCurrent.Y);
                fx = new Vector(Math.Pow(xCurrent.X, 2) + xCurrent.Y - 11, Math.Pow(xCurrent.Y, 2) + xCurrent.X - 7);
                d = solveMatrix(df, -fx);
                xCurrent = d + xCurrent;
            }
            while (Math.Abs((xCurrent - (xCurrent - d)).X) > Math.Pow(10, -8) && Math.Abs((xCurrent - (xCurrent - d)).Y) > Math.Pow(10, -8));
            Console.WriteLine();
        }

        public static Vector solveMatrix(double[,] m , Vector n)  //cramers rule
        {
            double[,] d1 = new double[,] { { n.X, m[0,1] }, { n.Y, m[1,1] } };
            double[,] d2 = new double[,] { { m[0, 0], n.X }, { m[1,0], n.Y } };
            return new Vector(calculateDet(d1) / calculateDet(m), calculateDet(d2) / calculateDet(m));
        }

        public static double calculateDet(double[,] m) //only for 2x2 matrices
        {
            return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
        }
    }
}
