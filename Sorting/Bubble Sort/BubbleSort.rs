***** Rust program *****
fn main()
{
 let mut temp;
 let mut a: [i32; 10] = [10,9,7,101,23,44,12,78,34,23];
 for i in 0..10
 {
  for j in (i+1)..10
  {
   if a[j] < a[i]
   {
    temp = a[i];
    a[i] = a[j];
    a[j] = temp;
   }
  }
 }
 println!("printing sorted element list...\n");
 for i in &a
 {
  println!("{}",i);
 }
}
