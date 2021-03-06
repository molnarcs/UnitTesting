// <copyright file="PexTestClassTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;

namespace TestLibrary.Tests
{
    [TestClass]
    [PexClass(typeof(PexTestClass))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PexTestClassTest
    {

        [PexMethod]
        public int Substract(
            [PexAssumeUnderTest]PexTestClass target,
            int a,
            int b
        )
        {
            int result = target.Substract(a, b);
            return result;
            // TODO: add assertions to method PexTestClassTest.Substract(PexTestClass, Int32, Int32)
        }

        [PexMethod]
        public TriangleKind ClassifyBySideLengths(int[] lengths)
        {
            TriangleKind result = PexTestClass.ClassifyBySideLengths(lengths);
            return result;
            // TODO: add assertions to method PexTestClassTest.ClassifyBySideLengths(Int32[])
        }
    }
}
