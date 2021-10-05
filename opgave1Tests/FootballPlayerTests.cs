using Microsoft.VisualStudio.TestTools.UnitTesting;
using opgave1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave1.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer _player { get; set; }
        [TestInitialize]
        public void BeforeTest()
        {

            _player = new FootballPlayer(1,"Ronaldo", 1000, 3);
        }
        [TestMethod()]
        public void FootballPlayerNameTest()
        {
            _player.Name = "Alex";
            Assert.AreEqual("Alex", _player.Name);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.Name = "abc");
        }

        [TestMethod()]
        public void FootballPlayerPriceTest()
        {
            _player.Price = 1200;
            Assert.AreEqual(1200, _player.Price);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.Price = -1);
        }
        [TestMethod()]
        public void FootballPlayerShirtTest()
        {
            _player.ShirtNumber = 5;
            Assert.AreEqual(5, _player.ShirtNumber);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.ShirtNumber = 0);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _player.ShirtNumber = 101);

        }

        [TestMethod()]
        public void FootballPlayerNullTest()
        {
            Assert.ThrowsException<NullReferenceException>(() => _player.Name = null);

        }
    }
}