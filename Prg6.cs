using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Prg6
    {
        static void Main(string[] args)
        {
            Point2D point2D = new Point2D(2, 3.2);
            Console.WriteLine(point2D.ToString());

            Point3D point3D = new Point3D(2, 3.2, 3);
            Console.WriteLine(point3D.ToString());
            Console.WriteLine(string.Join(" ", point3D.GetXYZ()));

            Console.ReadKey();
        }
    }

    class Point2D
    {
        private double x, y;

        public Point2D(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public void SetXY(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public List<double> GetXY()
        {
            List<double> result = new List<double>();
            result.Add(this.x);
            result.Add(this.y);

            return result;
        }
        public override string ToString()
        {
            return string.Format("({0},{1})", x, y);
        }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
    }

    class Point3D : Point2D
    {
        private double z;

        public Point3D(double x, double y, double z = 0.0) : base(x, y)
        {
            this.z = z;
        }
        public double Z { get => z; set => z = value; }
        public void SetXYZ(double x, double y, double z = 0.0)
        {
            base.SetXY(x, y);
            this.z = z;
        }
        public List<double> GetXYZ()
        {
            List<double> result = new List<double>();
            result = base.GetXY();
            result.Add(z);

            return result;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", X, Y, this.z);
        }
    }
    

}
