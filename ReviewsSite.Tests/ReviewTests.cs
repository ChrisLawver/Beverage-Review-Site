using System;
using System.Collections.Generic;
using System.Text;
using ReviewsSite.Models;
using Xunit;

namespace ReviewsSite.Tests
{
    public class ReviewTests
    {
        public Review sut;

        public ReviewTests()
        {
            sut = new Review();
            sut.Id = 40;
            sut.Rating = 2;
            //sut.ReviewDate = "date";
            sut.ReviewerName = "TestName";
                        
        }


        [Fact]
        public void ReviewId_Sets_Id_On_ReviewModel()
        {
            int result = sut.Id;
            Assert.Equal(40, result);
        }

        [Fact]
        public void ReviewConstructor_Sets_Rating_On_ReviewModel()
        {
            int result = sut.Rating;
            Assert.Equal(2, result);
        }

        [Fact]
        public void ReviewConstructor_Sets_ReviewerName_On_ReviewModel()
        {
            string result = sut.ReviewerName;
            Assert.Equal("TestName", result);
        }


    }

    //     Tests set up for attributes below:
    //     public int Id { get; set; }
    //     public int Rating { get; set; }
    //     public string ReviewerName { get; set; }

    // TO DO test for Attributes below: 
    //public string Content { get; set; }       
    //public int BevId { get; set; }
    //public virtual Bev Bev { get; set; }
    //public DateTime ReviewDate { get; set; }







}
