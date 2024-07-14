using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point();
            A.ToString();
            A.X = 22;
            A.Y = 34;
            Console.WriteLine($"X = {A.X}; Y = {A.Y}");
        }
    }
    struct Point
    {
        double x;
        double y;

        public double X { get; set; }
        public double Y { get; set; }
        //public double X
        //{
        //    get { return x; }
        //    set { this.x = value; }
        //}
        //public double Y
        //{
        //    get { return y; }
        //    set { this.y = value; }
        //}
        //public double GetX()
        //{
        //    return x;
        //}
        //public double GetY()
        //{
        //    return y;
        //}
        //public void SetX(double x)
        //{
        //    this.x = x;
        //}
        //public void SetY(double y)
        //{ 
        //    this.y = y;
        //}

    }
}
