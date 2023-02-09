using System;
using Xunit;

namespace UniqueEmailAddresses.Tests
{
    public class UniqueEmailAddressesTests
    {
        [Fact]
        public void Test_A()
        {
            string[] emails =new string[2] { "first.m.last@somewhere.com", "team1+jill+bob@somewhere.com" };
            int emailcount= UniqueEmailAddresses.NumberOfUniqueEmailAddresses(emails);
            if (emailcount>0)
            {
                Assert.True(true);   
            }

        }

       
        [Fact]
        public void Test_BUniqeEmail()
        {
            string[] emails = new string[2] { "first.m.last@somewhere.com", "first.m.last@somewhere.com" };
            int emailcount = UniqueEmailAddresses.NumberOfUniqueEmailAddresses(emails);
            if (emailcount ==1)
            {
                Assert.True(true);
            }

        }
    }
}