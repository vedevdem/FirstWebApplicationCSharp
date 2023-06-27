using Microsoft.AspNetCore.Mvc;

namespace WebApplication1;

[Controller]
[Route("test")]
public class MyController : Controller
{
    [HttpGet]   //атрибут
    [Route("get")]
    public int GetSum()
    {
        return 2;
    }

    [HttpPost]   //атрибут
    [Route("post")]
    public double PostSum([FromBody] Request request)
    {
        Triangle triangle = new Triangle(request.First, request.Second, request.Third);
        return triangle.GetArea();
    }
}
