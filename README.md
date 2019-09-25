# TestASP.NET

1.create folder TestASP.net

2.open terminal ==> dotnet new mvc

3.install extensions C# , WilderMinds' ASP.NET Core Snippets

4.create new C# Class in Models

5.write 

namespace TestASP.NET.Models {

    public class Beers {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
}

6.create file BeersController.cs in Controllers

7. write mvc6 select mvc6-controller  (extensions)

8.chagne name 

using System;

using System.Linq;

using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Logging;

namespace SUNVODZ.Controllers

{

  public class BeersController : Controller
  
  {
  
    ILogger<BeersController> _logger;
    public BeersController(ILogger<BeersController> logger)
    {
      _logger = logger;
    }
    public IActionResult Index()
    {
      return View();
    }
    
  }
  
}

9.create folder Beers in Views

10.create file index.cshtml in folder Beers

11.write <p>SunvoDz like to drink beer.</p> 

12.F5 OR Debug -> Start Debugging  

13.https://localhost:5001/Beers


14.Edit BeersController.cs in folder Controllers

using TestASP.NET.Models;

.
.
.
       public IActionResult Index()
       
        {
            return View();
        }
        public IActionResult ViewBeer()
        {
            Beers _data = new Beers();
            _data.Name = "Chang";
            return View(_data);
        }
.
.

15.Create ViewBeer.cshtml in folder Views -> Beers

16.write 

@model Beers

<p>Name : @Model.Name</p>

17. F5 --> https://localhost:5001/Beers/ViewBeer


18.Edit Beers.cs in folder Models

namespace TestASP.NET.Models {

    public class Beers {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Calorie { get; set; }
        public string Price { get; set; }
    }

19.Edit BeersController.cs in folder Controllers

.
.
.
       public IActionResult ViewBeer()
       
        {
            Beers _data = new Beers();
            _data.Name = "Chang";
            _data.Calorie = "120 Calorie";
            _data.Price = "65 B";

            return View(_data);
        }
.
.
.

20.Edit ViewBeer.cshtml in folder Views -> Beers

@model Beers

<p>Name : @Model.Name</p>
<p>Calorie : @Model.Calorie</p>
<p>Price : @Model.Price</p>

21. F5 -->> https://localhost:5001/Beers/ViewBeer


Name : Chang

Calorie : 120 Calorie

Price : 55 B


22.Edit BeersController.cs in folder Controllers

.
.
.
            public IActionResult ViewBeer()
            
        {
            IEnumerable<Beers> _data = new List<Beers>
            {
                new Beers(){
                    Name = "Chang",
                    Calorie = "120 Calorie",
                    Price = "55 B",
                },
                new Beers(){
                    Name = "Leo",
                    Calorie = "150 Calorie",
                    Price = "60 B",
                }
            };
            return View(_data);
        }
.
.
.
    
23.Edit ViewBeer.cshtml in folder Views -> Beers
@model IEnumerable<Beers>

@foreach(var item in Model){

    <p>Name :@item.Name</p>
    <p>Calorie: @item.Calorie</p>
    <p>Price: @item.Price</p>
    <p>====================</p>
}

24.F5 -->> https://localhost:5001/Beers/ViewBeer


25.Edit BeersController.cs in folder Controllers

.
.
.

public IActionResult Index()

        {
            return View();
        }
        public string run(){
            return "running";
        }
        public IActionResult ViewBeer()
        {
            IEnumerable<Beers> _data = new List<Beers>
            {
                new Beers(){
                    Name = "Chang",
                    Calorie = "120 Calorie",
                    Price = "55 B",
                },
                new Beers(){
                    Name = "Leo",
                    Calorie = "150 Calorie",
                    Price = "60 B",
                }
            };
            return View(_data);
        }
    }
.
.
.

26. F5 --> https://localhost:5001/Beers/run

running



##SUNVODZ##

