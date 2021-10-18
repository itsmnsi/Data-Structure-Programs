***** C# program *****
using System;
public class Program
{
 public static void Main()
 {
  int[] arr = new int[3,3];
  for(int i=0;i<3;i++)
  {
   for(int j=0;j<3;j++)
   {
    Console.WriteLine("Enter element");
    arr[i,j]=Convert.Tolnt32(Console.ReadLine());
   }
  }
  Console.WriteLine("Printing Elements...");
  for(int i=0;i<3;i++)
  {
   Console.WriteLine();
   for(int j=0;j<3;j++)
   {
    Console.Write(arr[i,j]+"");
   }
  }
 }
} 
