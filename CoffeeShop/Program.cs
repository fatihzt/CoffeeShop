using System;
using CoffeeShop.CoffeeType;

public class Program
{
    public static List<Coffee> coffees = new();


    public static void Main(string[] args)
    {



        Latte latte = new(1, "Latte", "Hot and Milked", 35,true,true);
        coffees.Add(latte);
        TurkishCoffee turkishCoffee = new(2, "Turkish Coffee", "Delicious and Turkish made", 40,true,true);
        coffees.Add(turkishCoffee);
        FilteredCoffee filteredcoffee= new(3, "Filtered Coffee", "Cold ", 42,true,true);
        coffees.Add(filteredcoffee);
        Mocha mocha = new(4, "Mocha", "Milked", 31,true,true);
        coffees.Add(mocha);




        Console.WriteLine("-----Welcome to CoffeShop-----\n\n" +
                            "1----Latte\n" +
                            "2----TurkishCoffee\n\n" +
                            "3----FilteredCoffee\n" +
                            "4----Mocha\n\n" +
                            "Enter order no :");
        int customerorder = Convert.ToInt32(Console.ReadLine());
        foreach (Coffee coffee in coffees)
        {


            if (customerorder == 1)
            {
                Console.WriteLine("1----Hot Latte\n"+
                    "2----Cold Latte\n");
                //ayrı ayrı sor 1 2 şeklinde soğuk sıcak vs sonra crem var mı yok mu diye her seferinde fiyat artır sonra abstractta olan bilgileri nasıl yazmayızza bak 
                
                string hotorcollatte = Console.ReadLine();
                latte.CoffeeMakeHot(hotorcollatte == "1");
                if (hotorcollatte == "1")
                {
                    latte.Price += 2;
                }
                Console.WriteLine("1----Extra Creamed Syrup \n"+
                    "2----Nothing ");
                string creamedornotlatte=Console.ReadLine();
                latte.CoffeeMakeCreamed(creamedornotlatte == "1");
                if (creamedornotlatte == "1")
                {
                    latte.Price += 3;
                }

                Console.WriteLine(latte.CoffeeHotText());
                Console.WriteLine(latte.CoffeeCreamedText());
               
                Console.WriteLine($"{latte.Price} $ price you have to pay");
                latte.MakeCoffee(latte);

                return;




            }
            else if (customerorder == 2)
            {

                Console.WriteLine("1----Sugar Turkish Coffee :\n"+
                    "2----Soft Turkish Coffee :");
                
                string sugerornottrcoffee =Console.ReadLine();
                turkishCoffee.CoffeeMakeSugar(sugerornottrcoffee == "1");
                if(sugerornottrcoffee == "1")
                {
                    turkishCoffee.Price += 1;
                }
                Console.WriteLine("1----Extra Milk\n"+
                    "2-----Nothing");
                string milkornottrcoffee = Console.ReadLine();

                turkishCoffee.CoffeeMakeMilked(milkornottrcoffee == "1");
                if (milkornottrcoffee == "1")
                {
                    turkishCoffee.Price += 2;
                }
                Console.WriteLine(turkishCoffee.CoffeeSugarText());
                Console.WriteLine(turkishCoffee.CoffeeMilkedText());
                
                Console.WriteLine($"{turkishCoffee.Price}$ price you have to pay");
                turkishCoffee.MakeCoffee(turkishCoffee);

                return;




            }
            else if(customerorder == 3)
            {

                Console.WriteLine("1----Sugar Filtered Coffee:\n"+
                    "2----No Sugar Filtered Coffee\n"
                    );
                string sugarfiltered = Console.ReadLine();
                filteredcoffee.CoffeeMakeSugar(sugarfiltered == "1");
                if (sugarfiltered == "1")
                {
                    filteredcoffee.Price += 1;
                }
                Console.WriteLine("1----Hot Filtered ?\n"+
                    "2----Cold Filtered");
                string hotorcoldfiltered = Console.ReadLine();
                filteredcoffee.CoffeeMakeHot(hotorcoldfiltered=="1");
                if (hotorcoldfiltered == "1")
                {
                    filteredcoffee.Price += 2;
                }

                Console.WriteLine($"{filteredcoffee.Price}$ price you have to pay");
                filteredcoffee.MakeCoffee(filteredcoffee);

                return;

            }
            else if (customerorder == 4)
            {

                Console.WriteLine("1----Hot Mocha ? \n"+
                    "2----Cold Mocha ?\n"
                    );
                string hotorcoldmocha=Console.ReadLine();
                mocha.CoffeeMakeHot(hotorcoldmocha == "1");
                if(hotorcoldmocha == "1")
                {
                    mocha.Price += 2;
                }
                Console.WriteLine("1----Extra Creamed Syrup\n"+
                    "2-----Nothing");
                string creamornotmocha =Console.ReadLine();
                mocha.CoffeeMakeCreamed(creamornotmocha == "1");
                if (creamornotmocha == "1")
                {
                    mocha.Price += 3;
                }

                Console.WriteLine($"{mocha.Price}$ price you have to pay");
                mocha.MakeCoffee(mocha);

                return;


            }
        }
        

        
        
    }

}