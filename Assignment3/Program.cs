using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    class Product
    {
        public String name;
        public double price;
        public double quantity;
        public string type;
        public Product(string name, double price, double quantity, string type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product("lettuce", 10.5, 50, "Leafy green");
            Product product2 = new Product("cabbage", 20, 100, "Cruciferous");
            Product product3 = new Product("pumpkin", 30, 30, "Marrow");
            Product product4 = new Product("cauliflower", 10, 25, "Cruciferous");
            Product product5 = new Product("zucchini", 20.5, 50, "Marrow");
            Product product6 = new Product(" yam", 30, 50, "Root");
            Product product7 = new Product("spinach", 10, 100, "Leafy green");
            Product product8 = new Product("broccoli", 20.2, 75, "Cruciferous");
            Product product9 = new Product("Garlic", 30, 20, "Leafy green");
            Product product10 = new Product("silverbeet", 10, 50, "Marrow");


            var products = new List<Product> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 };
            int productcount = products.Count;
            double totalprice = 0;
            double quantity = 0;
            double totalinventoryprice = 0;

            for (int i = 0; i < productcount; i++)
            {
                totalprice = totalprice + products[i].price;
                quantity = quantity + products[i].quantity;
                totalinventoryprice = totalinventoryprice + (products[i].price * products[i].quantity);
            }
            int x = 0;
            try
            {

                do
                {
                    Console.WriteLine("1. print product list    2.print Total price of the inventory    3.print the product with average price    4.Print list of cheap and costly products    5.Print Hr And Developers Salary     6. exit");
                    int mainswitch = int.Parse(Console.ReadLine());
                    switch (mainswitch)
                    {
                        case 1:
                            Console.WriteLine(" Display list of which product type ????");
                            Console.WriteLine("1. Leafy green    2.Cruciferous    3.Marrow    4.Root ");
                            int caseSwitch;
                            caseSwitch = int.Parse(Console.ReadLine());
                            switch (caseSwitch)
                            {
                                case 1:
                                    Console.WriteLine("the list of products under type leafy green is");
                                    for (int i = 0; i < productcount; i++)
                                    {
                                        if (products[i].type == "Leafy green")
                                        {
                                            Console.WriteLine(products[i].name);
                                        }
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("the list of products under type Cruciferous is");
                                    for (int i = 0; i < productcount; i++)
                                    {
                                        if (products[i].type == "Cruciferous")
                                        {
                                            Console.WriteLine(products[i].name);
                                        }
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("the list of products under type Marrow is");
                                    for (int i = 0; i < productcount; i++)
                                    {
                                        if (products[i].type == "Marrow")
                                        {
                                            Console.WriteLine(products[i].name);
                                        }
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("the list of products under type Root is");
                                    for (int i = 0; i < productcount; i++)
                                    {
                                        if (products[i].type == "Root")
                                        {
                                            Console.WriteLine(products[i].name);
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Wrong choice !!!!!!!!!!");
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("The total Price of the inventory is " + totalinventoryprice);
                            Console.WriteLine("The total Quantity in the inventory is " + quantity);
                            break;
                        case 3:
                            double average = 0;
                            average = totalprice / productcount;
                            for (int i = 0; i < productcount; i++)
                            {
                                if (products[i].price == average)
                                {
                                    Console.WriteLine(products[i].name);
                                }
                            }
                            Console.WriteLine("The average price of the products is " + average);
                            break;
                        case 4:
                            var cheap = new List<string> { };
                            var costly = new List<string> { };
                            for (int i = 0; i < productcount; i++)
                            {
                                if (products[i].price > 50)
                                {
                                    cheap.Add(products[i].name);
                                }
                                else
                                {
                                    costly.Add(products[i].name);
                                }
                            }
                            Console.WriteLine("the list of cheap products : ");
                            for (int i = 0; i < cheap.Count; i++)
                            {
                                Console.WriteLine(cheap[i]);
                            }
                            Console.WriteLine("the list of costly products : ");
                            for (int i = 0; i < costly.Count; i++)
                            {
                                Console.WriteLine(costly[i]);
                            }
                            break;
                        case 5:
                            Employee obj = new Hr();
                            obj.Printsalary();
                            Employee obj1 = new Developer();
                            obj1.Printsalary();
                            break;
                        case 6:
                            x = 1;
                            Console.WriteLine("Tata!!!!!");
                            break;
                        default:
                            Console.WriteLine("Wrong choice !!!!!!!!!!");
                            break;
                    }
                } while (x < 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Empty string not acceptable RESTART ");
            }            
        }
    }

        public abstract class Employee
        {
            public string Id;
            public string Name;
            public string Designation;
            public int Experience;
            public double Annualsalary;
            public string joining;
           
            // Abstract method signature
            abstract public void Printsalary();
        }

        public class Hr : Employee
        {
           // Implements abstract method
            public override void Printsalary()
                {
                    Hr obj = new Hr();
                    obj.Designation = "HR";
                    obj.Experience = 4;
                    obj.Annualsalary = 8000 + (1000 * 4);
                    Console.WriteLine("The salary for HR is " + obj.Annualsalary);
                }

        }

        public class Developer : Employee
        {           
            // Implements abstract method
            public override void Printsalary()
                {
                    Developer obj = new Developer();
                    obj.Designation = "developer";
                    obj.Experience = 5;
                    obj.Annualsalary = 8000 + (2000 * 5);
                    Console.WriteLine("The salary for Developer is " + obj.Annualsalary);
                }
        }
    }

