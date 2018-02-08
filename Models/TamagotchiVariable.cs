using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class TamagotchiVariable
  {
    private string _name;
    private int _health = 10;

    public string GetTamagotchiName()
    {
      return _name;
    }


    private static List<TamagotchiVariable> _tamagotchiList = new List<TamagotchiVariable>();

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetHealth()
    {
      return _health.ToString();
    }
    public void TakeHealth()
    {
      _health -= 1;
    }

    public void Save()
    {
      _tamagotchiList.Add(this);
    }
    public static List<TamagotchiVariable> GetTamagotchiList()
    {
      return _tamagotchiList;
    }
    public static TamagotchiVariable Find(int id)
    {
      return _tamagotchiList[id-1];
    }
  }
}
