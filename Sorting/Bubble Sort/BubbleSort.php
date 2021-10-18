***** PHP program *****
<html>
 <head>
  <title>
   Bubble sort
  </title>
 </head>
 <body>
  <?php
   $a = array(10,9,7,101,23,44,12,78,34,23);
   for($i=0;$i<10;$i++)
   {
    for($j=0;$j<10;$j++)
    {
     if($a[$i]<$a[$j])
     {
      $temp = $a[$i];
      $a[$i] = $a[$i];
      $a[$j] = $temp;
     }
    }
   }
   echo "printing sorted element list...\n";
   for($i=0;$i<10;$i++)
   {
    echo $a[$i];
    echo "\n";
   }
  ?>
 </body>
</html>
