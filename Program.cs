// string studentName = "Dagim";
// decimal fee = 1500m;
// string? region = null;
// int age = 20;

// Console.WriteLine($"Student: {studentName}");
// Console.WriteLine($"Fee: {fee}");
// Console.WriteLine($"Region: {region ?? "Not Assigned"}");
// Console.WriteLine($"Age: {age}");     


//////////////////////////////////////////////////////////////
// var students = new List<Student>
// {
//     new Student
//     {
//         Id = "S001",
//         Name = "Dagim",
//         Age = 20,
//         GPA = 3.8m,
//         Email = "dagim@example.com"
//     },
//     new Student
//     {
//         Id = "S002",
//         Name = "Abel",
//         Age = 22,
//         GPA = 2.7m,
//         Email = "abel@example.com"
//     },
//     new Student
//     {
//         Id = "S003",
//         Name = "Sara",
//         Age = 21,
//         GPA = 3.5m,
//         Email = "sara@example.com"
//     }
// };

// var honorsStudents = students
//     .Where(s => s.GPA >= 3.0m)
//     .OrderByDescending(s => s.GPA);

// foreach (var student in honorsStudents)
// {
//     Console.WriteLine(student.Name);
// }


////////////////////////////////////////////////////////////////////
Console.WriteLine("=== Module one sesstion 3 ===");
Console.WriteLine();

// Start both tasks at the same time
Task<Student> studentTask = FetchStudentAsync("STU-001");
Task<Course> courseTask = FetchCourseAsync("CS101");

// Wait for both tasks to finish
await Task.WhenAll(studentTask, courseTask);

Student student = await studentTask;
Course course = await courseTask;

Console.WriteLine();
Console.WriteLine("=== Loaded Data ===");
Console.WriteLine($"Student : {student.Name}");
Console.WriteLine($"Age     : {student.Age}");
Console.WriteLine($"GPA     : {student.GPA}");
Console.WriteLine($"Email   : {student.Email}");
Console.WriteLine();
Console.WriteLine($"Course  : {course.Title}");
Console.WriteLine($"Code    : {course.Code}");
Console.WriteLine($"Capacity: {course.Capacity}");


// Async Methods
async Task<Student> FetchStudentAsync(string studentId)
{
    Console.WriteLine($"Loading student {studentId}...");

    await Task.Delay(3000);

    return new Student
    {
        Id = studentId,
        Name = "Dagim",
        Age = 22,
        GPA = 3.8m,
        Email = "dagim@example.com"
    };
}

async Task<Course> FetchCourseAsync(string courseCode)
{
    Console.WriteLine($"Loading course {courseCode}...");

    await Task.Delay(3000);

    return new Course
    {
        Code = courseCode,
        Title = "C# Fundamentals",
        Capacity = 30
    };
}