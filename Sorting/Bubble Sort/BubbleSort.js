***** JavaScript program *****
<html>
 <head>
  <title>
   Bubble sort
  </title>
 </head>
 <body>
  <script>
   var a = [10,9,7,101,23,44,12,78,34,23];
   for(i=0;i<10;i++)
   {
    for(j=0;j<10;j++)
    {
     if(a[i]<a[j])
     {
      temp = a[i];
      a[i] = a[j];
      a[j] = temp;
     }
    }
   }
   txt = "<br>";
   document.writeln("printing sorted element list..." + txt);
   for(i=0;i<10;i++)
   {
    document.writeln(a[i]);
    document.writeln(txt);
   }
  </script>
 </body>
</html>
