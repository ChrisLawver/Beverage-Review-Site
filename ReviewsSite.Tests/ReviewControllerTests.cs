using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ReviewsSite.Controllers;
using NSubstitute;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ReviewsSite.Tests
{
    public class ReviewControllerTests
    {
        ReviewController sut;
        IRepository<Review> reviewRepo;

        public ReviewControllerTests()
        {
            reviewRepo = Substitute.For<IRepository<Review>>();
            sut = new ReviewController(reviewRepo);
        }

        [Fact]
        public void Create_Adds_A_Model()
        {
            //Arrange
             Review model = new Review() { BevId = 1, Content = ""};
            //reviewRepo.GetById(1).Returns(model);

            //Act
            var result = sut.Create(model);

            //Assertion
            //Assert.Equal("You have successfully saved this course.", result.ViewData["Result"]);
            Assert.IsType<ViewResult>(result);

        }
        [Fact]
        public void Update_Returns_A_View()
        {
            // Arrange
            var reviewToUpdate = new Review();
            reviewRepo.GetById(1).Returns(reviewToUpdate);
            //Act

            var result = sut.Update(1);

            //Assert

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Update_Passes_Review_To_View()
        {
            // Arrange
            var reviewToUpdate = new Review();
            reviewRepo.GetById(1).Returns(reviewToUpdate);
            reviewToUpdate.Content = "You reviewed this beverage.";

            // Act
            var result = (ViewResult)sut.Update(reviewToUpdate);

            //Assertion
            Assert.IsType<ViewResult>(result);
        }



    }
}
