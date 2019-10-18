using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class ReadonlyMembers
    {
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public readonly double Distance => Math.Sqrt(X * X + Y * Y);

            public override readonly string ToString() =>
                $"({X}, {Y}) is {Distance} from the origin";
        }

        public void UseReadonlyMember()
        {
            Point x = new Point { X = 3, Y = 4 };

            Console.WriteLine(x.ToString());
        }
    }
}
