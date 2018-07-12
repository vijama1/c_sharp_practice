using System;
class candles
{
  public static void Main(string[] args)
  {
    int n;
    int count=0;
    Console.WriteLine("Enter number of candles");
    n=Convert.ToInt32(Console.ReadLine());
    int[] ar=new int [n];
    for(int i=0;i<n;i++)
    {
      ar[i]=Convert.ToInt32(Console.ReadLine());
    }
    int max=ar[0];
    for(int j=1;j<n;j++)
    {
      if(ar[j]>max)
      max=ar[j];
    }
    for(int i=0;i<n;i++)
    {
      if(ar[i]==max)
      count+=1;
    }
    Console.WriteLine(count);

  }
}
