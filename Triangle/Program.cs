using System;
using Triangle.Models;

namespace Triangle
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number for Side 1:");
      string stringSide1 = Console.ReadLine();
      int side1 = int.Parse(stringSide1);

      Console.WriteLine("Enter a number for Side 2:");
      string stringSide2 = Console.ReadLine();
      int side2 = int.Parse(stringSide2);

      Console.WriteLine("Enter a number for Side 3:");
      string stringSide3 = Console.ReadLine();
      int side3 = int.Parse(stringSide3);

      if (IsTriangle.IfAnySideLonger(side1, side2, side3) == true)
      {
        Console.WriteLine("This cannot make a triangle!");
      }
      else if (IsTriangle.CheckSide1AndSide2(side1, side2) == true && IsTriangle.CheckSide2AndSide3(side2, side3) == true)
      {
        Console.WriteLine("This is an Equilateral Triangle!");
      }
      else if (IsTriangle.CheckSide1AndSide2(side1, side2) == true || IsTriangle.CheckSide2AndSide3(side2, side3) == true || IsTriangle.CheckSide1AndSide3(side1, side3) == true)
      {
        Console.WriteLine("This is an Isosceles Triangle!");
      }
      else
      {
        Console.WriteLine("This is a Scalene Triangle!");
      }
    }
  }
}