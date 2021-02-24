using System;
using System.Web.Mvc;
using Xunit;
using ReviewsSite.Controllers;
using ReviewsSite.Models;

namespace ReviewsSite.Tests
{
    public class BevControllerTests
    {

        BevController sut = new BevController();

        [Fact]
        public void Index_Should_Return_View()
        {


            var result = sut.Index();

            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void Index_Returns_BevModel_To_View()
         {
            //Arrange
            Bev bev = new Bev();



            //Act
                var result = sut.Index();


            // Assert
            Assert.IsType<Bev>(result.Model);
            
         }

    }
}
