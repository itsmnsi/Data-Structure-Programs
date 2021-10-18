***** PHP program *****
 <html>
  <head>
   <title>
    Insertion sort
   </title>
  </head>
  <body>
   <?php
    $a = array(10,9,7,101,23,44,12,78,34,23);
    echo("printing sorted elements...\n");
    for($k=0;$k<10;$k++)
    {
     $temp = $a[$k];
     $j = $k-1;
     while($j>=0 && $temp<=$a[$j])
     {
      $a[$j+1] = $a[$j];
      $j = $j-1;
     }
     $a[$j+1] = $temp;
    }
    for($i=0;$i<10;$i++)
    { 
     echo $a[$i];
     echo "\n";
    }
   ?>
  </body>
 </html>
