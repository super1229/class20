using System;

class MainClass {
  public static void Main (string[] args) {
    
 int reason = 3;
 int maxNumber = 3;
 int switch1;
 double C=0;
 double player= 0;
 double computer=0;
 double tie = 0;
 string input,choice;
 bool cont = true;

Random random = new Random();
switch1 = random.Next(maxNumber);






do{
Console.WriteLine("Select rock paper or scissors\n1:Rock\n2:Paper\n3:scissors");
input = Console.ReadLine();
C = double.Parse(input);




switch (switch1){

  case 1:
  {
  
    if (C == 1)
    {
      Console.WriteLine("Rock vs Rock is a tie");
      tie++;
    }
    if (C == 2)
    {
      Console.WriteLine("Paper vs Rock is a win");
      player++;
    }
    if (C == 3)
    {
      Console.WriteLine("scissors and Rock is a loss");
      computer++;
    }
  break;


  }

  case 2:
  {

    if (C == 1){
      Console.WriteLine("Paper vs Rock is a win");
        player++;
    }
    if (C == 2){
      Console.WriteLine("Paper vs paper is a tie");
        tie++;
    }
    if (C == 3){
      Console.WriteLine("scissors and paper is a loss");
      computer++;
    }
  break;


  }



  case 3:
  {

    if (C == 1)
    {
      Console.WriteLine("scissors vs Rock is a loss");
        computer++;
    }
    if (C == 2)
    {
      Console.WriteLine("scissors vs paper is a win");
        player++;
    }
    if (C == 3)
    {
      Console.WriteLine("scissors and scissors is a tie");
        tie++;
    }

break;

  }
}



Console.WriteLine("Would you like to continue y/n");

}while(Console.ReadLine()== "y");

 Console.WriteLine("Game over\n Scores:\n   Player:{0}\n   Comupter:{1}\n   Tie:{2}",player,computer,tie );





  }//void
}//class