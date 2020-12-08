using System;

namespace Triangle.Models
{
  public class IsTriangle
  {
    public static bool CheckSide1AndSide2(int side1, int side2)
    {
      if (side1 == side2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool CheckSide2AndSide3(int side2, int side3)
    {
      if (side2 == side3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool CheckSide1AndSide3(int side1, int side3)
    {
      if (side1 == side3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool IfAnySideLonger(int side1, int side2, int side3)
    {
      if ((side1 + side2) < side3 || (side2 + side3) < side1 || (side1 + side3) < side2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
