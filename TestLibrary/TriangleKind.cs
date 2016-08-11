using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public enum TriangleKind
    {
        Invalid,
        /// <summary>
        /// Egyenlőtlen oldalú
        /// </summary>
        Scalene,
        /// <summary>
        /// Egyenlő szárú
        /// </summary>
        Isosceles,
        /// <summary>
        /// Egyenlő oldalú
        /// </summary>
        Equilateral
    }
}
