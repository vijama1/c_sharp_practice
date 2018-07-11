using System;
class mini_max
{
  public static void Main(string[] args)
{
  int sum=0;
  int pos=0;
  int[] arr=new int[5];
  int[] arr1=new int[5];

  for(int i=0;i<5;i++)
  {
    arr[i]=Convert.ToInt32(Console.ReadLine());
  }

  for(int j=0;j<5;j++)
  {
    for(int k=0;k<5;k++)
    {
      sum=sum+arr[k];
    }
    sum=sum-arr[j];
    arr1[j]=sum;
    sum=0;
  }
  int min = arr1[0];
  int max = arr1[0];
  for(int i=0;i<5;i++)
  {
    Console.WriteLine(arr1[i]);
  }
  for (int i = 0; i < 5; i++)
        {
            if (min > arr1[i]) min = arr1[i];
            if (max < arr1[i]) max = arr1[i];
        }
  Console.WriteLine(min+" "+max);
}
}
