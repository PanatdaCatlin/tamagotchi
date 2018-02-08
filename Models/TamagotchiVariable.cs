using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class TamagotchiVariable
  {
    private string _name;
    private int _health = 10;
    private int _id;

    public string GetTamagotchiName()
    {
      return _name;
    }
    private static List<TamagotchiVariable> _tamagotchiList = new List<TamagotchiVariable>{};

    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetHealth()
    {
      return _health.ToString();
    }
    public bool CheckHealth()
    { if (_health >= 1)
      {
        Random getRandom = new Random();
        int Value =  getRandom.Next(1, 9);
        _health -= Value;
      }
      if (_health <=0) {
        return false;
      }else{
        return true;
      }
    }
    public void PlusHealth()
    {
      _health += 1;
    }
    public void Save()
    {
      _tamagotchiList.Add(this);
      _id = _tamagotchiList.Count;
    }
    public static List<TamagotchiVariable> GetTamagotchiList()
    {
      return _tamagotchiList;
    }
    public static void ClearAll()
    {
      _tamagotchiList.Clear();
    }
    public static TamagotchiVariable Find(int id)
    {
      return _tamagotchiList[id-1];
    }
  }
}
