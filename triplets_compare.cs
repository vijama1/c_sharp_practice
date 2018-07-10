using System;
class triplets
{
  public static void Main(string[] args)
  {
    int n;
    int alice_count=0;
    int bob_count=0;
    int[] alice=new int[3];
    int[] bob=new int[3];
    for(int i=0;i<3;i++)
    {
      Console.WriteLine("Enter Alice's data");
      alice[i]=Convert.ToInt32(Console.ReadLine());
    }

    for(int i=0;i<3;i++)
    {
      Console.WriteLine("Enter Bob's data");
      bob[i]=Convert.ToInt32(Console.ReadLine());
    }
    for(int i=0;i<3;i++)
    {
      if(alice[i]>bob[i])
      {
        alice_count+=1;
      }
      else if(bob[i]>alice[i])
      {
        bob_count+=1;
      }
      else
      {

      }
    }
    Console.WriteLine(alice_count+" "+bob_count);
  }
}
