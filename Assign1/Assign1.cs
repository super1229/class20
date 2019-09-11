// Eli Super
// 9/10/2019
using System;

class MainClass {
  public static void Main (string[] args) {
    double temp,selection,solution;
    string input;
  
      Console.WriteLine("please select a conversion option");
      

      // menu

      Console.WriteLine("1: Farenheight to Kelvin\n"+
                        "2: Celcius to Kelvin\n "+
                        "3: Kelvin to Celcius\n"+
                        "4: Kelvin to Farenheight ");
       
       input = Console.ReadLine();
       selection = double.Parse(input);
     
     
     
     /// selection and calculations
     
      if(selection == 1)
      {
        Console.WriteLine("Please input a tempuature"); 
        input = Console.ReadLine();
        temp = double.Parse(input);
        solution = (temp +459.67)* 0.555;
        Console.WriteLine("Kelvin = "+ solution);
      }
      if(selection == 2)
      {
        Console.WriteLine("Please input a tempuature"); 
        input = Console.ReadLine();
        temp = double.Parse(input);
        solution = temp +273.15;
        Console.WriteLine("Kelvin = "+ solution);



      }
      if (selection == 3)
      {
        Console.WriteLine("Please input a tempuature"); 
        input = Console.ReadLine();
        temp = double.Parse(input);
        solution = temp -273.15;
        Console.WriteLine("Celcius = "+ solution);


      }
      if (selection == 4)
      {
        Console.WriteLine("Please input a tempuature"); 
        input = Console.ReadLine();
        temp = double.Parse(input);
        solution = temp*1.8-459.67;
        Console.WriteLine("Kelvin = "+ solution);




      }

      


    
    
    
   
  }
}