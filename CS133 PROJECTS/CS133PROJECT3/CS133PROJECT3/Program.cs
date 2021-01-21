using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace CS133PROJECT2
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass<string, string> myClass = new myClass<string,string>();

            myClass.MyProperty = "A String value";
            myClass.MyProperty2 = "Another string value";

            myClass<int,string> myClass2 = new myClass<int,string>();

            myClass2.MyProperty = 1;
            myClass2.MyProperty2 = "A string value";

            myClass<int, int> myClass3 = new myClass<int, int>();

            myClass3.MyProperty = 1;
            myClass3.MyProperty2 = 2583;

            myClass<bool, ChocolateCake> myClass4 = new myClass<bool, ChocolateCake>();

            myClass4.MyProperty = true;
            myClass4.MyProperty2 = new ChocolateCake();
            myClass4.MyProperty2.Flavor = "Chocolate";




            foreach (var item in newList)
            {
                Console.WriteLine("My cake is a type" + item.flavor
                                  + "And the flavor is" + item.type);
            }


        }
    }
}

public class myClass<T,X>
{
    public T MyProperty  { get; set; }
    public X MyProperty2 { get; set; }
   
}

public class ChocolateCake
{
    public string Flavor { get; set; }
}