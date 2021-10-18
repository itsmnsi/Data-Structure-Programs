***** C# program *****
using System;
public class MyMergeSort
{
 void merge(int[] arr, int beg, int mid, int end)
 {
  int I = mid-beg+1;
  int r = end-mid;
  int i,j;
  int[] LeftArray = new int[I];
  int[] RightArray = new int[r];
  for(i=0;i<I;++i)
  LeftArray[i] = arr[beg+i];
  for(j=0;j<r;++j)
  RightArray[i] = arr[mid+1+j];
  i=0;
  j=0;
  int k=beg;
  while(i<I && j<r)
  {
   if(LeftArray[i] <= RightArray[j])
   {
    arr[k] = LeftArray[i];
    i++;
   }
   else
   {
    arr[k] = RightArray[j];
    j++;
   }
   k++;
  }
  While(i<I)
  {
   arr[k] = LeftArray[i];
   i++;
   k++;
  }
  While(j<r)
  {
   arr[k] = RightArray[j];
   j++;
   k++;
  }
 }
 void sort(int[] arr, int beg, int end)
 {
  if(beg<end)
  {
   int mid = (beg+end)/2;
   sort(arr, beg, mid);
   sort(arr, mid+1, end);
   merge(arr, beg, mid, end);
  }
 }
 public static void Main()
 {
  int[] arr = {90,23,101,45,65,23,67,89,34,23};
  MyMergeSort ob = new MyMergeSort();
  ob.sort(arr, 0,9);
  Console.WriteLine("\n Sorted array");
  for(int i=0;i<10;i++)
  {
   Console.WriteLine(arr[i]+"");
  }
 }
}
