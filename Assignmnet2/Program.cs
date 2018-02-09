using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var products = new List<string> {"Tomato" ,"Potato","ToMato","Potato","Red Tomato","Tomato  Catchup","Grapes","grapes","potato" };

            var count = 0;
            foreach (string pdk in products)
            {
                if(string.Equals(pdk,"tomato", StringComparison.CurrentCultureIgnoreCase))          
                {
                    count = count + 1;
                }
            }
            Console.WriteLine("the total number of products of type tomato is " + count);


            int Potatoindex = 0;
            foreach (string pdk in products)
            {
                Potatoindex = Potatoindex + 1;
                if( string.Equals(pdk, "Potato", StringComparison.CurrentCulture))
                {
                    Console.WriteLine("the index of the word Potato in the list is " + Potatoindex);
                }
            }
            Program obj = new Program();
            obj.Assg();
        }

        public void Assg()
        {
            float x = 0.06f;
            float y = 5.94f;
            float sum;
            sum = x + y;
            Console.WriteLine("the sum of the two numbers is " + sum);
            if(sum == 6)
            {
                Console.WriteLine(" the sum is equal to 6 ");
            }

            if (x > y)
                Console.WriteLine("X has greater value");
            else
                Console.WriteLine("Y has greater value");
        }

    }
}
