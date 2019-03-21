using System;
using Komodo_Outings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Komodo_claims_Tests
{
    [TestClass]
    public class Komodo_Outings_Repository_Tests
    {
        private Komodo_Outings_Repository _Outings_Repository;

        [TestMethod]
        public void TestAddOutingToList()
        {
            Outings outings = new Outings();
            _Outings_Repository = new Komodo_Outings_Repository();


            _Outings_Repository.AddOutingToList(outings);

            int expected = 1;
            int actual = _Outings_Repository.GetOutings().Count;

            Assert.AreEqual(expected, actual);
            

            
        }
       


        }
    }

