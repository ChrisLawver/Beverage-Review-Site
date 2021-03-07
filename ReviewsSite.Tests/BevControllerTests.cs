using System;

using Xunit;
using ReviewsSite.Controllers;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using NSubstitute;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace ReviewsSite.Tests
{
    public class BevControllerTests
    {
        private IRepository<Bev> bevRepo;

        private BevController sut;

        public BevControllerTests()         
        {
            bevRepo = Substitute.For<IRepository<Bev>>();
            sut = new BevController(bevRepo);
        }

        

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
            //Bev bev = new Bev();
            List<Bev> bevs = null;
            bevRepo.GetALL().Returns(bevs);
                      


            //Act
                var result = sut.Index();


            // Assert
            Assert.Equal(bevs,result.Model);
            
         }
        [Fact]
        public void Create_Returns_A_View()
        {
            // Arrange

            //Act

            //var result = sut.Create();

            //Assert

           // Assert.IsType<ViewResult>(result);
        }

    }
}
