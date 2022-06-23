using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.CoffeeFeature;


namespace CoffeeShop.CoffeeType
{
    public class FilteredCoffee : Coffee, ISugar, IHot
    {
        public FilteredCoffee( int id,string name, string desription, decimal iprice, bool ishot, bool issugar)
        {
            Id= id;
            Name = name;
            Description = desription;
            Price = iprice;
            IsHot = ishot;
            IsSugar = issugar;
        }

        

        public bool IsHot { get; set; }
        public bool IsSugar { get; set; }

    public void CoffeeMakeHot(bool ishot)
        {
            IsHot = ishot;
        }
        public string CoffeeHotText() => IsHot ? "Hot" : "Cold";





        public void CoffeeMakeSugar(bool issugar)
        {
            IsSugar = issugar;
        }

        public string CoffeeSugarText() => IsSugar ? "Sugar" : "No Sugar";

        public override void MakeCoffee(Coffee coffee)
        {
            base.MakeCoffee(coffee);
        }
    }
}
