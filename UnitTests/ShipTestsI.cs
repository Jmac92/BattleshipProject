using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGame
{
    [TestClass()]
    public class ShipTests
    {
        
        [TestMethod()]
        public void ShipTestSub()
        {
            Ship testShip1 = new Ship(ShipName.Submarine);

            Assert.IsTrue(testShip1.Name == "Submarine");
            
       
        }
        [TestMethod()]
        public void ShipTestTug()
        {
            
            Ship testShip2 = new Ship(ShipName.Tug);

            Assert.IsTrue(testShip2.Name == "Tug");

            
        }
        [TestMethod()]
        public void ShipTestDest()
        {

            Ship testShip3 = new Ship(ShipName.Destroyer);

            Assert.IsTrue(testShip3.Name == "Destroyer");

    

        }
        [TestMethod()]
        public void ShipTestNone()
        {
                        
            Ship testShip4 = new Ship(ShipName.None);

            Assert.IsTrue(testShip4.Name == "None");

        }


    }
}
