using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraCCV;
using NUnit.Framework;

namespace UltraCCV.Test.Unit
{
    [TestFixture]
    public class UltraCCVUnitTest
    {
        private UltraCCV _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new UltraCCV();
        }

        [Test]
        public void ValidateName_hasSpaceInName_isTrue()
        {
           Assert.That(_uut.ValidateName("John Doe"), Is.True);
        }

        [Test]
        public void ValidateName_missingSpaceInName_isFalse()
        {
            Assert.That(_uut.ValidateName("John"), Is.False);
        }

        [Test]
        public void ValidateName_oneNameEndWithSpace_isFalse()
        {
            Assert.That(_uut.ValidateName("John "), Is.False);
        }

        [Test]
        public void ValidateName_oneNameStartWithSpace_isFalse()
        {
            Assert.That(_uut.ValidateName(" John"), Is.False);
        }

        [Test]
        public void Validatename_numbersInName_ReturnsFalse()
        {
            Assert.That(_uut.ValidateName("John 123"), Is.False);
        }

        [Test]
        public void ValidateName_containsSymbols_ReturnsFalse()
        {
            Assert.That(_uut.ValidateName("John>< Doe"), Is.False);
        }

        [Test]
        public void ValidateName_hasHyphen_ReturnsTrue()
        {
            Assert.That(_uut.ValidateName("John-Matilde Mogensen"), Is.True);
        }

        [Test]
        public void ValidateName_hasUnderscore_ReturnsFalse()
        {
            Assert.That(_uut.ValidateName("Mads__Nielsen Opp"), Is.False);
        }
    }
}
