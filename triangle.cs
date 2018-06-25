using System;
class Triangle
{
  public int SideOne;
  public int SideTwo;
  public int SideThree;

  public bool Equilateral()
  {
    if((SideOne==SideTwo)&&(SideTwo==SideThree)&&(SideOne==SideThree))
    {
      return true;
    }else{
      return false;
    }
  }

  public bool Isosceles()
  {
    if((SideOne==SideTwo)||(SideTwo==SideThree)||(SideOne==SideThree))
    {
      return true;
    }else{
      return false;
    }
  }
  public bool Scalene()
  {
    if((SideOne != SideTwo) && (SideTwo != SideThree) && (SideOne != SideThree))
    {
      return true;
    }else{
      return false;
    }
  }
  public bool notTri()
  {
    if((SideOne + SideTwo < SideThree) || (SideOne + SideThree < SideTwo) || (SideTwo + SideThree < SideOne))
    {
      return true;
    }else{
      return false;
    }
  }


  }



class Program
{
  public static void Main()
  {
    Triangle myTriangle= new Triangle();
    Console.WriteLine("Enter the first side of triangle");
    string firstSide= Console.ReadLine();
    int intFirstSide=int.Parse(firstSide);
    myTriangle.SideOne=intFirstSide;

    Console.WriteLine("Enter the second side of triangle");
    string secondSide= Console.ReadLine();
    int intSecondSide=int.Parse(secondSide);
    myTriangle.SideTwo=intSecondSide;

    Console.WriteLine("Enter the third side of triangle");
    string thirdSide= Console.ReadLine();
    int intThirdSide=int.Parse(thirdSide);
    myTriangle.SideThree=intThirdSide;
    if (myTriangle.notTri())
    {
      Console.WriteLine("Not a triangle");
    }
    else if (myTriangle.Equilateral())
    {
      Console.WriteLine("your triangle is equilateral");
    }
    else if (myTriangle.Isosceles())
    {
      Console.WriteLine("your triangle is isosceles");
    }
    else if (myTriangle.Scalene())
    {
      Console.WriteLine("your triangle is scalene");
    }




  }
}
