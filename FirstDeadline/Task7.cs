using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDeadline
{
    class Task7
    {
        class Vector{
            private double x;
            private double y;
            private double z;

            public double X { get => x; set => x = value; }
            public double Y { get => y; set => y = value; }
            public double Z { get => z; set => z = value; }

            public Vector(double x1, double y1, double z1)
            {
                X = x1;
                Y = y1;
                Z = z1;
            }
            public Vector() { }

            public static Vector Addd(Vector A, Vector B)
            {
                Vector C = new Vector();
            }
        }

    }
}
