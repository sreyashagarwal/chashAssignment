using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sreyash_Project
{
    class Product
        {
        public String name;
        public double price;
        public double quantity;
        public string type;
        public Product(string name , double price, double quantity, string type)
            {
                this.name = name;
                this.price = price;
                this.quantity = quantity;
                this.type = type;
            }
        }


   public class Primeminister
    {
        public string Name { get; private set; }
        public int Yearselected { get; private set; }
        public Primeminister(string name , int year)
        {
            this.Name = name;
            this.Yearselected = year;
        }

        public override string ToString()
        {
            return string.Format("{0} , elected : {1}", Name, Yearselected);
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product("lettuce", 10.5, 50, "Leafy green");
            Product product2 = new Product("cabbage", 20 , 100,"Cruciferous");
            Product product3 = new Product("pumpkin", 30, 30," Marrow");
            Product product4 = new Product("cauliflower", 10, 25, "Cruciferous");
            Product product5 = new Product("zucchini", 20.5, 50, "Marrow");
            Product product6 = new Product(" yam", 30 , 50," Root");
            Product product7 = new Product("spinach", 10, 100, "Leafy green");
            Product product8 = new Product("broccoli", 20.2, 75, "Cruciferous");
            Product product9 = new Product("Garlic", 30 , 20, "Leafy green");
            Product product10 = new Product("silverbeet", 10 , 50," Marrow");


            var products = new List<Product> { product1 , product2 , product3 , product4 , product5 , product6 , product7 , product8 , product9 , product10 };
            int productcount = products.Count;
            Console.WriteLine("the Number of products is" + productcount);


            Product product11 = new Product("Potato",10 , 50, "Root");
            products.Add(product11);
            productcount = products.Count;
            Console.WriteLine("the Number of products after adding is" + productcount);
            for (int i = 0; i < productcount; i++)
            {
                Console.WriteLine(products[i].name + " " + products[i].price + " " + products[i].quantity + " " + products[i].type);
            }


            for (int i = 0; i < productcount; i++)
            {
                if (products[i].type == "Leafy green")
                {
                    Console.WriteLine("The product of type leafy greaan is " + products[i].name);
                }
            }

            products.RemoveAt(9);
            productcount = products.Count;
            Console.WriteLine("the Number of products after removing Garlic is is " + productcount);

            product2.quantity = product2.quantity + 50;
            Console.WriteLine("the Number of cabbages after adding 50 cabbages is " + product2.quantity);

            double costoflettuce = product1.price/product1.quantity;
            double costofzucchine = product5.price/product5.quantity;
            double costofbroccoli = product8.price/product8.quantity;

            double costtopay = Math.Ceiling((1 * costoflettuce) + (2 * costofzucchine) + (1 * costofbroccoli));
            Console.WriteLine("The final rounded cost to pay is RS " + costtopay);

            Program obj = new Program();
            obj.Assg();
            obj.Assgsecond();

        }


        public void Assg()
        {
            string[] englishdictionary = { "Boat", "house", "cat", "river", "cupboard" };
            Console.WriteLine("The plurals of the words are");
            for (int i = 0; i < englishdictionary.Length; i++)
            {
                Console.WriteLine(englishdictionary[i] + "s");
            }

            englishdictionary[1] = "residence";

            for (int i = 0; i < englishdictionary.Length; i++)
            {
                Console.WriteLine(englishdictionary[i] + "s");
            }

            var arraylist = new List<string> { };

            for (int i = 0; i < englishdictionary.Length; i++)
            {
                arraylist.Add(englishdictionary[i]);    
            }

            arraylist.Add("Sreyash");
            var listlength = arraylist.Count;
            Console.WriteLine("The length of the List after adding a new word is " + listlength);

            Console.WriteLine("The list of elements with 7 characters is : ");
            for (int i = 0; i < listlength ; i++)
            {
                if(arraylist[i].Length == 7)
                    {
                        Console.WriteLine(arraylist[i]);
                    }
            }


            Console.WriteLine("The word on 3rd position is " + arraylist[2]);


            string[] englishdictionary1 = arraylist.ToArray();
            Array.Sort(englishdictionary1);
            Console.WriteLine("the sorted array is : ");
            for (int i = 0; i < englishdictionary1.Length; i++)
            {
                Console.WriteLine(englishdictionary1[i]);
            }

            Console.WriteLine("reversing the sorted array we get : ");
            Array.Reverse(englishdictionary1);
            for (int i = 0; i < englishdictionary1.Length; i++)
            {
                Console.WriteLine(englishdictionary1[i]);
            }
        }


        public void Assgsecond()
        {
            var primeministers = new Dictionary<string, Primeminister>
            {
                {"ABV", new Primeminister("Atal Bihari Vajpayee", 1998 ) },
                 {"NM", new Primeminister("Narendra Modi" ,2014 ) },
                  {"MS", new Primeminister("Manmohan Singh", 2004) }
            };

            foreach(var pm in primeministers)
            {
                if (pm.Value.Yearselected == 2004)
                {
                    Console.WriteLine("the primeminister in the year 2004 is " + pm.Value.Name);
                }
            }

            primeministers.Add( "NDM", new Primeminister("Narendra Damodardas Modi", 2014));
            Console.WriteLine("the dictionary after adding ");
            foreach (var pm in primeministers)
            {
                Console.WriteLine(pm.Value);
            }


            var keylist = new List<string> { };
            foreach (var pm in primeministers)
            {
                keylist.Add(pm.Key);
            }
            Console.WriteLine(keylist[1]);

            string[] arr1 = keylist.ToArray();
            Array.Sort(arr1);

            Console.WriteLine("the sorted dictionary is :");
            for (int i = 0; i < arr1.Length; i++)
            {
                Primeminister pm = primeministers[arr1[i]];
                Console.WriteLine(pm.ToString());
            }
        }
    }
}
