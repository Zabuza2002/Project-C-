using Microsoft.VisualStudio.TestTools.UnitTesting;
using SF2022User_NN_Lib.dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User_NN_Lib.dll.Tests
{
    [TestClass()]
    public class CalculationsTests
    {
        [TestMethod()]
        public void AvailablePeriodsTest()
        {
            string pass = "3jj3oi@";
            bool expected = true;
            bool actual = Calculations.AvailablePeriods(pass);

            Assert.AreEqual(expected, actual);
        }

        
    }
}