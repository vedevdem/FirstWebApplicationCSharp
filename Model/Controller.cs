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
        var triangle = new Triangle(request.FirstSide, request.SecondSide, request.ThirdSide);
        var circle = new Circle(request.Radius);
        var figures = new List<IFigure>
        {
            triangle,
            circle
        };
        var processor = new Processor();
        return processor.SumArea(figures);
    }
}
