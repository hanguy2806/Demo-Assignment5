using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_Summer2019.Views;

namespace DollarComputerUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThatSelectFormHasConnectionToDB()
        {
            //arange
            SelectForm selectForm;
            //act 
            selectForm = new SelectForm();
            //assert
            Assert.IsTrue(selectForm.isConnectedToDatabase());
            

        }
    }
}
