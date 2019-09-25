using System;
using System.Linq;
class MainClass {
  public static void Main (string[] args) {
    
    
    double num1,num2,num3;// declarations
    string input;
    int comb1,comb2,comb3;
    int unlock = 0 ;
    int[] combination = new int[3];
    int[] storage = new int[3];
    Random random = new Random();

  
    combination[0] = random.Next(1,9);// numbers to unlock the lock
    combination[1] = random.Next(1,9);
    combination[2] = random.Next(1,9);

    Console.WriteLine("Please input 3 numbers between 1 and 9 to try the lock");
    
    
     input = Console.ReadLine();// get the first input
    num1 = double.Parse(input);
     
     input = Console.ReadLine();
    num2 = double.Parse(input);
    
     input = Console.ReadLine();
    num3 = double.Parse(input);

    int i = 0;
    do
    {
      if(num1 == combination[0])
      {
        storage[0] = 1;
      }
        if(num2 == combination[1])
        {
          storage[1] = 1;
        }
       if(num3 == combination[2])
      {
        storage[1] = 1;
      }
       
        if(storage[0]!= 0 && storage[1]!= 0 && storage[2]!=0)
      {
        unlock = 1;
      }     
       
       if(unlock == false)
       {
         if(storage[0]==0)
         {
           Console.WriteLine
         }
         if(storage[1]==0)
         {

         }
         if(storage[2]==0)
         {

         }



       }




      i++;
    }while(unlock = 0);

    
    Console.WriteLine(storage[0]);

    




    








  }
}