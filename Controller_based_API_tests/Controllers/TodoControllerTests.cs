using Controller_based_API.Controllers;
using Controller_based_API.Models;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NSubstitute;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Controller_based_API_tests.Controllers;

public class TodoControllerTests()
{
    // Creates a substitute context instance to mock the controller's dependency, which is TodoContext and then pass 
    // it into the controller
    private readonly TodoController _mockContext = Substitute.For<TodoController>();

    [Fact]
    public void Get_TodoItems_ReturnsNoContent()
    {
        //Arrange
        // sut is a private field and constructor to instantiate subject under test (sut)
        var _sut = new TodoController(_mockContext);
        
        // Act
        var result = _sut.GetTodoItems();
        // Assert
        Assert.IsNull(result);
    }
}