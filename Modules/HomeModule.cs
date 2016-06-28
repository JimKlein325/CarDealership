using Nancy;
using CarDeal.Objects;
using System.Collections.Generic;

namespace CarDeal
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/cars"] = _ => {
        List<Car> allCars = Car.GetAll();
        return View["cars.cshtml", allCars];
      };
      Get["/cars/new"] = _ => {
        return View["car_form.cshtml"];
      };
      Post["/cars"] = _ => {
        string makeModel = Request.Form["makeModel"];
        int year = Request.Form["year"];
        int miles = Request.Form["miles"];
        int price = Request.Form["price"];
        string message = Request.Form["message"];
        Car newCar = new Car(makeModel, price, message, miles, year);

        // Car newCar = new Car(Request.Form["makeModel"]);
        List<Car> allCars = Car.GetAll();
        return View["cars.cshtml", allCars];
      };

      Get["/cars/{id}"] = parameters => {
        Car car = Car.Find(parameters.id);
        return View["/car.cshtml", car];
      };
      // Get["/"] = _ => View["add_new_car.cshtml"];
      // Get["/view_all_cars"] = _ => {
      //   List<Car> allCars = Car.GetAll();
      //   return View["view_all_cars.cshtml", allCars];
      // };
      // Post["/car_added"] = _ => {
      //   string makeModel = Request.Form["makeModel"];
      //   int year = Request.Form["year"];
      //   int miles = Request.Form["miles"];
      //   int price = Request.Form["price"];
      //   string message = Request.Form["message"];
      // Car newCar = new Car(makeModel, price, message, miles, year);
      //   newCar.Save();
      //   return View["car_added.cshtml", newCar];
      // };
      // Post["/cars_cleared"] = _ => {
      //   Car.ClearAll();
      //   return View["cars_cleared.cshtml"];
      // };
    }
  }
}
