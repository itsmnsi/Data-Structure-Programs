***** C# program *****
using System;
public class HeapSorting
{
 static void heapify(int[] arr, int size, int i)
 {
  int largest = i;
  int left = 2*i+1;
  int right = 2*i+2;
  int temp;
  if(left<size && arr[left]>arr[largest])
  largest = left;
  if(right<size && arr[right]>arr[largest])
  largest = right;
  if(largest != i)
  {
   temp = arr[i];
   arr[i] = arr[largest];
   arr[largest] = temp;
   heapify(arr, size, largest);
  }
 }
 static void heapSort(int[] arr, int size)
 {
  int i;
  int temp;
  for(i=size/2-1;i>=0;i--)
  heapify(arr,size,i);
  for(i=size-1;i>=0;i--)
  {
   temp = arr[0];
   arr[0] = arr[i];
   arr[i] = temp;
   heapify(arr, i, 0);
  }
 }
 public void main()
 {
  int[] arr = {1, 10, 2, 3, 4, 1, 2, 100, 23, 2};
  int i;
  heapSort(arr, 10);
  Console.WriteLine("printing sorted elements");
  for(i=0;i<10;++i)
  Console.WriteLine(arr[i]);
 }
} 
