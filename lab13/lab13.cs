using System;

class MainClass {
  public static void Main (string[] args) {
    //declarations
    double money,quarters,dime,nickel,penny,modValue,a,b,x,y;
    string input;


    Console.WriteLine("Please enter an amount of cents");
    input = Console.ReadLine();
    money = int.Parse(input);
    
    // math prototypes
    modValue = money % 25;
    quarters= money/25;
    Console.WriteLine(modValue);
    
    a= modvalue %10
    Console.WriteLine(a);
    dime= modValue /10;
    
    modValue = dime %10;
    nickel = modValue /5;
    modValue = nickel %5;
    penny = modValue /1;



    Console.WriteLine(quarters);
    Console.WriteLine(dime);
    Console.WriteLine(nickel);
    Console.WriteLine(penny);
  
            
         


        
         
          







    
    
    Console.WriteLine ("Hello World");
  }
}