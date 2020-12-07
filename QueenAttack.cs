using System;
using System.Collections.Generic;


names Queen 
{
  //biz
  public class QueenData
  {
    private string MakeModel;
    private int Price;
    private int Miles;

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }

  // UI -- would get refactored to a new page upon completion
  public class QueenAttack
  {


  // if/else 
  // MoveDiagonally 1st - most specific
  // 

  }
}