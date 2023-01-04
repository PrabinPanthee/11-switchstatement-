using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a Number ");
       int UserNumber = int.Parse(Console.ReadLine());
        switch(UserNumber)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Your number is {0}", UserNumber);
                break;
             default: Console.WriteLine("Your number is not 10 , 20 and 30 "); break;

        }
      
       
    }
}