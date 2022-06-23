using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.CoffeeFeature
{
    public interface ICreamed
    {
        public bool IsCreamed { get; set; }
        void CoffeeMakeCreamed(bool iscreamed);
        string CoffeeCreamedText();
    }
}
