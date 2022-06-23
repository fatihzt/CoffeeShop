using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.CoffeeType
{
    public abstract class Coffee
    {
        public Coffee()
        {

        }
        public  Coffee(int  id, string name, string desription, decimal price)
        {
            Id = id;
            Name = name;
            Description = desription;
            Price = price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual void MakeCoffee(Coffee coffee)
        {
            Console.WriteLine($"{coffee.Name} is ready.\n"+
                "You can take.");
        }
        





    }
}
