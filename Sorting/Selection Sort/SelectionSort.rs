***** Rust program *****
fn main()
{
 let mut a:[i32;10] = [10,9,7,101,23,44,12,78,34,23];
 for i in 0..10
 {
  let mut small = a[i];
  let mut pos = i;
  for j in (i+1)..10
  {
   if a[j]<small
   {
    small = a[j];
    pos = j;
   }
  }
  let mut temp = a[i];
  a[i] = a[pos];
  a[pos] = temp;
 }
 println!("\n printing sorted elements...\n");
 for i in &a
 {
  println!("{}",i);
 }
}
