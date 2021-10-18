***** PHP program *****
<html>
 <head>
  <title>
   Selection sort
  </title>
 </head>
 <body>
  <?php
   function smallest($a, $n, $i)
   {
    $small = $a[$i];
    $pos = $i;
    for($j=$i+1;$j<10;$j++)
    {
     if($a[$j]<$small)
     {
      $small = $a[$j];
      $pos = $j;
     }
    }
    return $pos;
   }
   $a = array(10,9,7,101,23,44,12,78,34,23);
   for($i=0;$i<10;$i++)
   {
    $pos = smallest($a,10,$i);
    $temp = $a[$i];
    $a[$i] = $a[$pos];
    $a[$pos] = $temp;
   }
   echo "printing sorted elements... \n";
   for($i=0;$i<10;$i++)
   {
    echo $a[$i];
    echo "\n";
   }
  ?>
 </body>
</html> 
