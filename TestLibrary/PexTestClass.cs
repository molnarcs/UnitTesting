using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class PexTestClass
    {
        public int Substract(int a, int b)
        {
            int result = a - b;
            return result;
        }

        public static TriangleKind ClassifyBySideLengths(int[] lengths)
        {
            int s1 = lengths[0];
            int s2 = lengths[1];
            int s3 = lengths[2];

            if ((s1 + s2 <= s3) || (s1 + s3 <= s2) || (s2 + s3 <= s1))
            {
                return TriangleKind.Invalid;
            }
            else if (s1 == s2 && s2 == s3)
            {
                return TriangleKind.Equilateral;
            }
            else if ((s1 == s2) || (s1 == s3) || (s2 == s3))
            {
                return TriangleKind.Isosceles;
            }
            else
            {
                return TriangleKind.Scalene;
            }
        }
    }
}
