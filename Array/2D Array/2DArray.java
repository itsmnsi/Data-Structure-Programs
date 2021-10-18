import java.util.Scanner;
public class TwoDarray
{
  public static void main(String args[])
  {
    int[][] arr = new int[3][3];
    Scanner sc = new Scanner(System.in);
    for(int i=0;i<3;i++)
    {
     for(int j=0;j<3;j++)
     {
      System.out.print("Enter elements");
      arr[i][j] = sc.next();
      System.out.println();
     }
    }
    System.out.println("Printing elements...");
    for(int i=0;i<3;i++)
    {
     System.out.println();
     for(int j=0;j<3;j++)
     {
      System.out.print(arr[i][j]+"\t");
     }
    }
   }
  }
