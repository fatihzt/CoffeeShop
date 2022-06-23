using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.CoffeeFeature;

namespace CoffeeShop.CoffeeType
{
    public class TurkishCoffee : Coffee, ISugar, IMilked
    {


        public TurkishCoffee(int id, string name, string desription, decimal price, bool issugar, bool ismilked)
        {
            Id = id;
            Name = name;
            Description = desription;
            Price = price;
            IsSugar = issugar;
            IsMilked = ismilked;
        }
        public bool IsSugar { get; set; }
        public bool IsMilked { get; set; }

        public string CoffeeHotText() => IsSugar ? "Sugar" : "No Sugar";

        public void CoffeeMakeMilked(bool ismilked)
        {
            IsMilked = ismilked;
        }

        public void CoffeeMakeSugar(bool issugar)
        {
            IsSugar = issugar;
        }

        public string CoffeeMilkedText() => IsMilked ? "Milked" : "No Milked";
        public string CoffeeSugarText() => IsSugar ? "Sugar" : "No Sugar";

        public override void MakeCoffee(Coffee coffee)
        {
            base.MakeCoffee(coffee);
        }
    }
}
