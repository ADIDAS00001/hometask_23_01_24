


Student student1=new Student();
student1.Name="Firuz";
student1.GradeLevel=11;
student1.Scores=new int [5]{100,90,50,70,80};
System.Console.WriteLine(student1.GetAverage());

public class  Student
{
    public string Name;
    public int GradeLevel;
    public int[] Scores;

    public double GetAverage()
    {
        int sum=0;
        for(int i=0;i<Scores.Length;i++)
        {
            sum+=Scores[i];
        }
        return sum/Scores.Length;
    }
}
