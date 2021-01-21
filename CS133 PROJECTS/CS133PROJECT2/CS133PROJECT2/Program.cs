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
            MyUser myUser = new MyUser();

            myUser.UserName =  "Rene";
            myUser.TotalViews = 2;
            myUser.likes = 3;

            myUser.Comments = new List<string>();
            myUser.Comments.Add("This is my first comment");
            myUser.Comments.Add("A Comment from another user");
            myUser.Comments.Add("One more comment");



            Console.WriteLine("The User" + myUser.UserName +
                             " has Total Views of :" + myUser.TotalViews +
                             " , With these many likes:" + myUser.likes );

            Console.WriteLine("It has the following comments:");
            foreach(var item in myUser.Comments)
            {
                Console.WriteLine(item);
                                  
            }


        }
    }
}

public class MyUser
{
    public string UserName { get; set; }
    public int TotalViews { get; set; }
    public int likes { get; set; }
    public List<string> Comments { get; set; }
}