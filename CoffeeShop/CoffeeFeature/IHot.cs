using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.CoffeeFeature
{
    public interface IHot
    {
        public bool IsHot { get; set; }
        void CoffeeMakeHot(bool ishot);
        string CoffeeHotText();

    }
}
