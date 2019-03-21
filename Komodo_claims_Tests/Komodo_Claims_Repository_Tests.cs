using System;
using Komodo_Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Komodo_claims_Tests
{
    [TestClass]
    public class Komodo_Claims_Repository_Tests
    {
        private Claims_Repository _claimRepo;

        [TestMethod]
        public void TestAddClaimToQueue()
        {

            //Arrange
            Claims claims = new Claims();
            _claimRepo = new Claims_Repository();


            //Act
            _claimRepo.AddClaimtoQueue(claims);
            



            int expected = 1;
            int actual = _claimRepo.GetClaims().Count;


            //Assert
            Assert.AreEqual(expected, actual);
        }
       
       
        
    }
}
