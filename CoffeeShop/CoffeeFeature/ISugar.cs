using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.CoffeeFeature
{
    
    public interface ISugar
    {
        public bool IsSugar { get; set; }
        void CoffeeMakeSugar(bool issugar);
        string CoffeeSugarText();
    }
}
