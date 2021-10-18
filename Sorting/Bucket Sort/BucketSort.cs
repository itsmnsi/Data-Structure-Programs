using System;
class Bucket
{
 static int getMax(int[] a)
 {
  int n = a.Length;
  int max = a[0];
  for(int i=1;i<n;i++)
  if(a[i] > max)
  max = a[i];
  return max;
 }
 static void bucket(int[] a)
 {
  int n = a.Length;
  int max = getMax(a);
  int[] bucket = new int[max+1];
  for (int i=0;i<=max;i++)
  {
   bucket[i] = 0;
  }
  for(int i=0;i<n;i++)
  {
   bucket[a[i]]++;
  }
  for(int i=0, j=0;i<=max;i++)
  {
   while(bucket[i] > 0)
   {
    a[j++] = i;
    bucket[i]--;
   }
  }
 }
 static void printArr(int[] a)
 {
  int i;
  int n = a.Length;
  for(i=0;i<n;i++)
  Console.Write(a[i]+" ");
 }
 static void Main()
 {
  int[] a = {95, 50, 45, 15, 20, 10};
  Console.Write("Before sorting array elements are - \n");
  printArr(a);
  bucket(a);
  Console.Write("After sorting array elements are - \n");
  printArr(a);
 }
}

   
  
