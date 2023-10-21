using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using WEB_1005_Fall_2023_WebAPI.ControllerBases;

namespace WEB_1005_Fall_2023_WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ToDoController : OptionsControllerBase
{
    public ToDoController(ILogger logger)
    {}

    // [HttpDelete]
    // public string ToDoDelete()
    // {
    //     return "This is the delete method.";
    // }

    [HttpGet("{echo}")]
    public string ToDoGet2(string echo)
    {
        return echo;
    }

    // [HttpPut]
    // public string ToDoPut()
    // {
    //     return "This is the put method.";
    // }

    [HttpGet]
    public string ToDoGet()
    {
        return "This is the get method";
    }

    [HttpPost]
    public string ToDoPost()
    {
        return "This is the post method";
    }
}
