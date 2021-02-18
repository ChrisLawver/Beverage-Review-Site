using System;
using System.Web.Mvc;
using Xunit;
using ReviewsSite.Controllers;

namespace ReviewsSite.Tests
{
    public class BevControllerTests
    {
            [Fact]
            public void Index_Should_Return_View()
            {
                BevController sut = new BevController();

                var result = sut.Index();

                Assert.IsType<ViewResult>(result);

            }
        
    }
}
