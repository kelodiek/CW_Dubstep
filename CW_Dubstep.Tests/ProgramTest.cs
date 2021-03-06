// <copyright file="ProgramTest.cs">Copyright ©  2017</copyright>
using System;
using CW_Dubstep;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CW_Dubstep.Tests
{
    /// <summary>Cette classe contient des tests unitaires paramétrables pour Program</summary>
    [PexClass(typeof(Dubstep))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProgramTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("ABC", Dubstep.SongDecoder("WUBWUBABCWUB"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual("R L", Dubstep.SongDecoder("RWUBWUBWUBLWUB"));
        }
    }
}
