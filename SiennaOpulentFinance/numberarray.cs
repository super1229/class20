using System;

class MainClass {
  public static void Main (string[] args) {
  
    int even=0;
    int odd =0;
    int[] container = new int[100];
    int[] counter = new int[21];


    Random random = new Random();
    int number;

    number = random.Next(1,21);

    for(int i=0; i<container.Length;i++)
    {
      container[i]=number;
      number = random.Next(1,21);
                                   
       if(container[i]%2 == 0)
       {
         even++;
       }
       else
       {
         odd++;
       }

        


    }
    for(int x=0;x<counter.Length;x++)
          {
           for(int y=0; y<container.Length;y++)
           {
            
            
             if(container[y]==x)
              {
        
              counter[x]++;
              }
           }
          }

         for(int x=0; x<21;x++)
        {
          Console.WriteLine("The Number "+x+ " appears "+counter[x]+"times");
        }
         
         
          Console.WriteLine("The number of even numbers is:"+even);
          Console.WriteLine("The number of odd numbers is:"+odd);

          
    
    
   


  
  
  }
}