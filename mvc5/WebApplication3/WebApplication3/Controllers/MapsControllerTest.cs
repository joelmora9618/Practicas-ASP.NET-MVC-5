using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public void ViewMaps()
    {
        // Arrange
        MapsController controller = new MapsController();

        // Act
        ViewResult result = controller.ViewMaps() as ViewResult;

        // Assert
        Assert.IsNotNull(result);
    }
}