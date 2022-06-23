using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.CoffeeFeature
{
    public interface ICold
    {
        public bool IsCold { get; set; }
        void CoffeeMakeCold(bool iscold);
        string CoffeeColdText();
    }
}
