***** Java Program *****
public class MyMergeSort
{
 void merge(int arr[], int beg, int mid, int end)
 {
  int I = mid-beg+1;
  int r = end-mid;
  intLeftArray[] = new int[I];
  intRightArray[] = new int[r];
  for(int i=0;i<I;++i)
  LeftArray[i] = arr[beg+i];
  for(int j=o;j<r;++j)
  RightArray[j] = arr[mid+1+j];
  int i=0, j=0;
  int k=beg;
  while(i<I && j<r)
  {
   if(LeftArray[i]<=RightArray[j])
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
  while(i<I)
  {
   arr[k] = LeftArray[i];
   i++;
   k++;
  }
  while(j<r)
  {
   arr[k] = RightArray[j];
   j++;
   k++;
  }
 }
 void sort(int arr[], int beg, int end)
 {
  if(beg<end)
  {
   int mid = (beg+end)/2;
   sort(arr, beg, mid);
   sort(arr, mid+1, end);
   merge(arr, beg, mid, end);
  }
 }
 public static void main(String args[])
 {
  int arr[] = {90,23,101,45,65,23,67,89,34,23};
  MyMergeSort ob = new MyMergeSort();
  ob.sort(arr, 0, arr.length-1);
  System.out.println("\n Sorted array");
  for(int i=0;i<arr.length;i++)
  {
   System.out.println(arr[i]+"");
  }
 }
}
