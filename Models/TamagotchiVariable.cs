using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class TamagotchiVariable
  {
    private string _name;
    private static List<TamagotchiVariable> _tamagotchiList = new List<TamagotchiVariable> {};

        public TamagotchiVariable(string tamagotchiName)
        {
          _name = tamagotchiName;
        }
        public string GetTamagotchiName()
    {
      return _name;
    }
  }
}
