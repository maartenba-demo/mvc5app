using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AcmeCompany.Portal.Tests
{
    public class SampleTests
    {
        [Test]
        public void TestBooleanTrueEqualsTrue()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void TestBooleanFalseEqualsFalse()
        {
            Assert.IsFalse(false);
        }
    }
}
