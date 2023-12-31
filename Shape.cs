namespace FirstProject;

public class Shape
{
    public int X;
    public int Y;

    public virtual void Draw()
    {
        Console.WriteLine("Drawing Shape");
    }

 
   
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    } 
}
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    } 
}
class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Triangle");
    } 
}
