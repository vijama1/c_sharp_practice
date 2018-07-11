using System;
class plus_minus
{
  public static void Main(string[] args)
  {
    int pos_count=0,neg_count=0,neutral=0;
    float pos_frac,neg_frac,neutral_frac;
    Console.WriteLine("Enter numver of elements");
    int n=Convert.ToInt32(Console.ReadLine());
    int[] arr=new int[n];
    for(int i=0;i<n;i++)
    {
      arr[i]=Convert.ToInt32(Console.ReadLine());
    }
    for(int j=0;j<n;j++)
    {
      if(arr[j]>0)
      {
        pos_count+=1;
      }
      else if(arr[j]<0)
      {
        neg_count+=1;
      }
      else
      {
        neutral+=1;
      }
    }
    Console.WriteLine(pos_count+" "+neg_count+" "+neutral);
    pos_frac=(float)pos_count/n;
    neg_frac=(float)neg_count/n;
    neutral_frac=(float)neutral/n;
    string pos=pos_frac.ToString("0.000000");
    string neg=neg_frac.ToString("0.000000");
    string neu=neutral_frac.ToString("0.000000");
    Console.WriteLine(pos+"\n"+neg+"\n"+neu);
  }
}
