using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _08_Smart_Insurance;

namespace _08_Smart_Insurance_Tests
{
    [TestClass]
    public class Smart_Insurance_Repository_Tests_08
    {
        private Smart_Insurance_Repository_08 insurance_Repository_08;

        [TestMethod]

        public void TestAddUserToList()
        {
            User_08 user = new User_08();
            insurance_Repository_08 = new Smart_Insurance_Repository_08();

            insurance_Repository_08.AddUserToList(user);

            int expected = 1;
            int actual = insurance_Repository_08.GetUsersList().Count;

            Assert.AreEqual(expected, actual);


        }
    }
}
