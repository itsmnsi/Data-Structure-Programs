***** JavaScript program *****
 <html>
  <head>
   <title>
    Insertion Sort
   </title>
  </head>
  <body>
   <script>
    var txt = "<br>";
    var a = [10,9,7,101,23,44,12,78,34,23];
    document.writeln("printing sorted elements..." + txt);
    for(k=0;k<10;k++)
    {
     var temp = a[k]
     j = k-1;
     while(j>=0 && temp<=a[j])
     {
      a[j+1] = a[j];
      j = j-1;
     }
     a[j+1] = temp;
    }
    for(i=0;i<10;i++)
    {
     document.writeln(a[j]);
     document.writeln(txt);
    }
   </script>
  </body>
 </html> 
