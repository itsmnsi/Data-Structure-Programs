***** C# program *****
using System;
public class LinearSearch()
{
 public static void Main()
 {
  int item, flag=0;
  int[] a = {10,23,5,90,89,34,12,34,1,78};
  Console.WriteLine("Enter the item value");
  item = Convert.Tolnt32(Console.ReadLine());
  for(int i=0;i<10;i++)
  {
   if(item==a[i])
   {
    flag=i+1;
    break;
   }
   else
   flag=0;
  }
  if(flag!=0)
  {
   Console.WriteLine("Item found at Location"+flag);
  }
  else
  Console.WriteLine("Item not found");
 }
} 
