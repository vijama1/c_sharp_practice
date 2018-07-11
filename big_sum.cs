using System;
class Solution
{
  public static void Main(string[] args)
  {
    int n;
    long sum=0;
    Console.WriteLine("Enter number of elements of array");
    n=Convert.ToInt32(Console.ReadLine());
    long[] arr=new long[n];
    for(int i=0;i<n;i++)
    {
      Console.WriteLine("Enter array elements");
      arr[i]=Convert.ToInt64(Console.ReadLine());
    }
    for(int j=0;j<n;j++)
    {
      sum=sum+arr[j];
    }
    Console.WriteLine(sum);
  }
}
