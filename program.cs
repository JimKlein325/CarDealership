using System;
using System.Collections.Generic;

class Car
{

  // public string MakeModel;
  // public int Price;
  // public int Miles;


  private string _makeModel;
  private int _price;
  private int _miles;
  private string _message;

  public void SetPrice(int newPrice)
  {
    if (newPrice >=0) {
      _price=newPrice;
    }
    else {
      Console.WriteLine("Invalid price");
    }
  }

  public int GetPrice()
  {
    return _price;
  }

  public void SetMiles(int newMiles)
  {
    if (newMiles >=0) {
      _miles=newMiles;
    }
    else {
      Console.WriteLine("Invalid miles");
    }
  }
  public int GetMiles()
  {
    return _miles;
  }

  public void SetMakeModel(string newMakeModel)
  {
    //if (String.IsNullorEmpty(newMakeModel)) {
      _makeModel=newMakeModel;
  //  }
    // else {
    //   Console.WriteLine("Please enter a valid make/model");
    // }
  }
  public string GetMakeModel()
  {
    return _makeModel;
  }

  public void SetMessage(string newMessage)
  {
  //  if (String.IsNullorEmpty(newMessage)) {
      _message=newMessage;
    //}
    // else {
    //   Console.WriteLine("Please enter a valid message");
    // }
  }
  public string GetMessage()
  {
    return _message;
  }


  public Car (){}

  public Car (string makeModel , int price , string message,  int miles = 5)
  {

      _makeModel = makeModel;
      _miles = miles;
      _message = message;

  }
}

public class Program
{
  public static void Main()
  {
    //Car porsche = new Car();
    string myMessage = "Good Pick!";

    Car toyota = new Car("Toyota",  100, myMessage, 99);

    // porsche.MakeModel = "2014 Porsche 911";
    // porsche.Price = 114991;
    // porsche.Miles = 7864;

    // Car ford = new Car();
    // ford.MakeModel = "2011 Ford F450";
    // ford.Price = 55995;
    // ford.Miles = 14241;
    //
    // Car lexus = new Car();
    // lexus.MakeModel = "2013 Lexus RX 350";
    // lexus.Price = 44700;
    // lexus.Miles = 20000;
    //
    // Car mercedes = new Car();
    // mercedes.MakeModel = "Mercedes Benz CLS550";
    // mercedes.Price = 39900;
    // mercedes.Miles = 37979;

    List<Car> Cars = new List<Car>() { toyota };//, ford, lexus, mercedes };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);



    foreach (Car automobile in Cars)
    {
      if (automobile.GetPrice() < maxPrice && automobile.GetMiles() < maxMiles)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    if (CarsMatchingSearch.Count == 0)
    {
      Console.WriteLine("No cars match your search.");
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      string output = automobile.GetMakeModel() + ":  " +  automobile.GetMessage();
      Console.WriteLine(output);
    }
  }
}
