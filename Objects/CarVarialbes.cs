using System;
using System.Collections.Generic;

namespace CarDeal.Objects
{

  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _message;
    private int _year;
    private int _id;


    private static List<Car> _carList = new List<Car> {};


    public Car ()
    {

    }

    public Car (string makeModel , int price , string message,  int miles, int year)
    {
      _price = price;
      _makeModel = makeModel;
      _miles = miles;
      _message = message;
      _year = year;

      _carList.Add(this);
      _id = _carList.Count;

    }

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

    public int GetYear()
    {
      return _year;
    }

    public void SetYear(int newYear)
    {
      _year = newYear;
    }

    public static List<Car> GetAll()
    {
      return _carList;
    }
    public void Save()
    {
      _carList.Add(this);
    }
    public static void ClearAll()
    {
      _carList.Clear();
    }
    public int GetId()
       {
         return _id;
       }
    public static Car Find (int id)
    {
      return _carList[id - 1];
    }
  }
}
