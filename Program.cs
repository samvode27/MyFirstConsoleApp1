string studentName = "Dagim";
decimal fee = 1500m;
string? region = null;
int age = 20;

Console.WriteLine($"Student: {studentName}");
Console.WriteLine($"Fee: {fee}");
Console.WriteLine($"Region: {region ?? "Not Assigned"}");
Console.WriteLine($"Age: {age}");     


//////////////////////////////////////////////////////////////
var students = new List<Student>
{
    new Student
    {
        Id = "S001",
        Name = "Dagim",
        Age = 20,
        GPA = 3.8m,
        Email = "dagim@example.com"
    },
    new Student
    {
        Id = "S002",
        Name = "Abel",
        Age = 22,
        GPA = 2.7m,
        Email = "abel@example.com"
    },
    new Student
    {
        Id = "S003",
        Name = "Sara",
        Age = 21,
        GPA = 3.5m,
        Email = "sara@example.com"
    }
};

var honorsStudents = students
    .Where(s => s.GPA >= 3.0m)
    .OrderByDescending(s => s.GPA);

foreach (var student in honorsStudents)
{
    Console.WriteLine(student.Name);
}

