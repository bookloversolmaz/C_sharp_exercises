using Controller_based_API.Controllers;
using Controller_based_API.Models;
using Controller_based_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Controller_based_API_tests.Controllers;

public class TodoControllerTests()
{
    // Test the gettodoitems function, which returns the entire list
    [Fact]
    public async Task GetTodoItems_ReturnsEmptyList()
    {
        // Arrange
        // Sets up the mock todoitems
        // initialises a new mock of the interface repo
        var mockRepo = new Mock<ITodoRepository>();
        // sets up the mock to implement the gettodoitems method, which takes and returns an empty list of todoitem
        mockRepo.Setup(repo => repo.GetTodoItems())
            .ReturnsAsync(new List<TodoItem>());
        // initialises an instance of the controller, which takes the mock as an object
        // this is done to mimic the method, which uses the repo interface to talk to the dbcontext,
        // and then is passed to the controller
        var controller = new TodoController(mockRepo.Object);
        
        // Act
        // response implements the method under test. Inside, the controller awaits the repo, gets the empty list,
        // maps to DTOs (still empty), and returns it
        var response = await controller.GetTodoItems();
        // result takes the output of the response by finding its value
        var result = response.Value;
        
        // Assert
        // result.any asks if the result contains any elements. The test states that it should not contain anything.
        Assert.IsFalse(result.Any());
    }
}