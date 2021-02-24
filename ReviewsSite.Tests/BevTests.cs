using System;
using System.Collections.Generic;
using System.Text;
using ReviewsSite.Models;
using Xunit;


namespace ReviewsSite.Tests
{
    public class BevTests
    {
        Bev sut;
        
        public BevTests()
        {
            sut = new Bev(32, "This is the bev description");

        }

        [Fact]
        public void BevConstructor_Sets_Id_On_BevModel()
        {
            int result = sut.Id;
            Assert.Equal(32, result);
        }

        [Fact]
        public void BevConstructor_Sets_Description_On_BevModel()
        {
            string result = sut.Description;
            Assert.Equal("This is the bev description", result);

        }







    }
}


