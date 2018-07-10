using System;
class prime_check
{
  public static void Main(string[] args)
  {
    int number;
    int i,flag=0;
    Console.WriteLine("Enter a Number");
    number=Convert.ToInt32(Console.ReadLine());
    for(i=2;i<number/2;i++)
    {
      if(number%i==0)
      {
        flag=1;
      }
    }
    if(flag==1)
    {
      Console.WriteLine("Not prime");
    }
    else
    {
      Console.WriteLine("Prime");
    }


  }
}
