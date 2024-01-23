
 Rectangle rectangle1=new Rectangle();
 rectangle1.Width=7;
 rectangle1.Height=5;
System.Console.WriteLine(rectangle1.GetArea());
public class Rectangle 
{
    public double Width;
    public double Height;


    public double GetArea()
    {
        return  Width*Height;
    }
}