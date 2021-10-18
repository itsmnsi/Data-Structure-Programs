***** Swift program *****
import Foundation
import Glibc
 var a = [10,9,7,101,23,44,12,78,34,23];
 print("\n printing sorted elements... \n");
 for k in 1...9
 {
  let temp = a[k];
  var j=k-1;
  while j>=0 && temp<=a[j]
  {
   a[j+1] = a[j];
   j = j-1;
  }
  a[j+1] = temp;
 }
 for i in a
 {
  print(i);
 }
