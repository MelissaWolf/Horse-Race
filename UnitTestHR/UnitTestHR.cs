using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Horse_Race;

namespace UnitTestHR
{
    [TestClass]
    public class UnitTestHR
    {

        [TestMethod]
        public void TestMethod() //Checking there are 3 Punters
        {
            //Creating Punters Array
            Punter[] Punters = new Punter[3];

            //Creating RadioBtns
            RadioButton JacRadioBtn = null;
            RadioButton MelRadioBtn = null;
            RadioButton MarRadioBtn = null;

            //Creating TxtBoxes
            TextBox JacTxtBox = null;
            TextBox MelTxtBox = null;
            TextBox MarTxtBox = null;

            //Defining Punters
            Factory.MakePunter("Jack", JacRadioBtn, JacTxtBox);
            Factory.MakePunter("Melissa", MelRadioBtn, MelTxtBox);
            Factory.MakePunter("Marina", MarRadioBtn, MarTxtBox);

            Assert.IsTrue(Factory.count == Punters.Length);
        }
    }
}
