using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.CoffeeFeature;


namespace CoffeeShop.CoffeeType
{
    public class Latte : Coffee, ICreamed, IHot
    {

        public Latte(int id, string name, string desription, decimal price, bool ishot, bool iscreamed)
        {
            Id = id;
            Name = name;
            Description = desription;
            Price = price;
            IsCreamed = iscreamed;
            IsHot = ishot;
        }

        public bool IsCreamed { get; set; }
        public bool IsHot { get; set; }

        public string CoffeeCreamedText() => IsCreamed ? "Creamed" : "No Creamed";

        public string CoffeeHotText() => IsHot ? "Hot" : "Cold";


        public void CoffeeMakeCreamed(bool iscreamed)
        {
            IsCreamed = iscreamed;
        }

        public void CoffeeMakeHot(bool ishot)
        {
            IsHot = ishot;
        }

        public override void MakeCoffee(Coffee coffee)
        {
            base.MakeCoffee(coffee);
        }

    }
}
