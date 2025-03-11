using System.Security.Cryptography;
using elitecars_admin.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace elitecars_admin.Controllers;

[ApiController]
[Route("/api/[controller]s")]
public class CarController : ControllerBase
{
    public static readonly List<Car> Cars = [];
    private readonly ILogger<CarController> _logger;

    public CarController(ILogger<CarController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCars")]
    public Results<Ok<List<Car>>, NotFound> Get()
    {
        return TypedResults.Ok(Cars);
    }

    [HttpGet("{id}", Name = "GetACar")]
    public Results<Ok<Car>, NotFound> GetCar(int id)
    {
        var result = Cars.FirstOrDefault(c => c.CarId == id);
        return TypedResults.Ok(result);
    }

    [HttpPost(Name = "PostACar")]
    public Results<Created<Car>, BadRequest> Post(Car car)
    {
        car.CarId = RandomNumberGenerator.GetInt32(1000000);
        car.CreatedAt = DateTime.Now;
        Cars.Add(car);
        return TypedResults.Created($"/api/car/{car.CarId}", car);
    }
}
