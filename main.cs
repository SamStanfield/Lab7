using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {


    Console.WriteLine ("How many people parked at the garage?");
    int len = Convert.ToInt32(Console.ReadLine());
    int[] hour = new int[len];
    for(int counter=0; counter < len; counter++)
    {
      Console.WriteLine("How many hours did you park?");
      hour[counter]= Convert.ToInt32(Console.ReadLine());
      if(hour[counter] < 3);
      {
        double total = hour[counter] * 2;
        Console.WriteLine("Your total is $" + total);
      }
      if(hour[counter] > 3);
      {
       int con = 0;
       con++;  
        double total = hour[counter] * 2 + (.5 * con);
        Console.WriteLine("Your total is $" + total);
      }
      
    }


  }
}