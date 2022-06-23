using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.CoffeeFeature
{
    public interface IMilked
    {
        public bool IsMilked { get; set; }
        void CoffeeMakeMilked(bool ismilked);
        string CoffeeMilkedText();
    }
}
