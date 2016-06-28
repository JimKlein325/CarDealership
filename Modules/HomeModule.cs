using Nancy;
using CarDeal.Objects;
using System.Collections.Generic;

namespace CarDeal
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_car.cshtml"];
      Get["/view_all_cars"] = _ => {
        List<Car> allCars = Car.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };
      Post["/car_added"] = _ => {
        string makeModel = Request.Form["makeModel"];
        int year = Request.Form["year"];
        int miles = Request.Form["miles"];
        int price = Request.Form["price"];
        string message = Request.Form["message"];
      Car newCar = new Car(makeModel, price, message, miles, year);
        newCar.Save();
        return View["car_added.cshtml", newCar];
      };
      // Post["/tasks_cleared"] = _ => {
      //   Task.ClearAll();
      //   return View["tasks_cleared.cshtml"];
      // };
    }
  }
}
