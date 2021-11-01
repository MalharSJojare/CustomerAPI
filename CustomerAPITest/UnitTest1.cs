using System.Collections.Generic;
using CustomerAPI.CakeModel1;
using CustomerAPI.Repository;

using NUnit.Framework;

namespace FlowApiTest
{
    public class Tests
    {
        Customer f = new Customer()
        { 
            Id=101,
            Name="Ram",
            Email="ram@gmail.com",
           

        };

      
        [SetUp]
        public void Setup()
        {

            
        }

        [Test]

        public void TestCakeByIdValid()
        {
            //int a = 1;
            RepoClass r = new RepoClass();
            var b = r.CustomerbyId(101);
            Assert.AreEqual(f.Id, b.Id);
            // Assert.AreEqual(d.Drug_Name, b.Drug_Name);
        }

        [Test]

        public void TestCakeByIdInValid()
        {
            //int a = 1;
            RepoClass r = new RepoClass();
            var b = r.CustomerbyId(5);
            if (b == null)
            {
                b = new Customer()
                {
                    Id = 0,
                };

            }
            Assert.AreNotEqual(f.Id, b.Id);
            // Assert.AreEqual(d.Drug_Name, b.Drug_Name);
        }
        
    }
}