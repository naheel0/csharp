class Student
{
    public int Id;
    public string Name;
    public int Age;
    public string Course;
};

class Course
{
    public string Course_Name;
    public int Course_ID;
};

class StudentManager
{
    public List<Student> Student = new List<Student>();

    public void AddStudent(Student student)
    {
        Student.Add(student);
    }

    public void ViewStudent()
    {
        foreach (var s in Student)
        {
            Console.WriteLine($"Name:{s.Name}  Age{s.Age}  Id:{s.Id}  Course:{s.Course}");
        }
    }

    public void UpdateStudent(int age, string name, int id)
    {
        foreach (var s in Student)
        {
            if (s.Id == id)
            {
                s.Age = age;
                s.Name = name;
            }
        }
    }

    public void DeleteStudent(int id)
    {
        Student removeStudent = Student.Find(s => s.Id == id);
        if (removeStudent != null)
        {
            Student.Remove(removeStudent);
        }
    }

    public void StudentsAboveAge(int Age)
    {
        var Result = Student.Where(s => s.Age > Age);
        foreach (var a in Result)
        {
            Console.WriteLine($"Name:{a.Name} Age:{a.Age} Course:{a.Course}");
        }
    }

    public void StudentsByCourse(string Course)
    {
        var Result = Student.Where(s => s.Course == Course);
        foreach (var c in Result)
        {
            Console.WriteLine($"Name:{c.Name} Age:{c.Age} Course:{c.Course}");
        }
    }
}

class Course_Manager
{
    List<Course> Course = new List<Course>();

    public void AddCourse(Course course)
    {
        Course.Add(course);
    }

    public void ViewCourse()
    {
        foreach (var c in Course)
        {
            Console.WriteLine($"Course Name:{c.Course_Name} Course Id:{c.Course_ID}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentManager studentManager = new StudentManager();
        Course_Manager courseManager = new Course_Manager();

        courseManager.AddCourse(new Course { Course_ID = 101, Course_Name = "Computer Science" });
        courseManager.AddCourse(new Course { Course_ID = 102, Course_Name = "Mathematics" });

        Console.WriteLine("Courses:");
        courseManager.ViewCourse();

        studentManager.AddStudent(
            new Student
            {
                Id = 1,
                Name = "Alice",
                Age = 20,
                Course = "Computer Science",
            }
        );
        studentManager.AddStudent(
            new Student
            {
                Id = 2,
                Name = "Bob",
                Age = 22,
                Course = "Mathematics",
            }
        );
        studentManager.AddStudent(
            new Student
            {
                Id = 3,
                Name = "Charlie",
                Age = 25,
                Course = "Computer Science",
            }
        );

        Console.WriteLine("\nStudents:");
        studentManager.ViewStudent();

        studentManager.UpdateStudent(21, "Alice Johnson", 1);

        Console.WriteLine("\nAfter Updating Student:");
        studentManager.ViewStudent();

        studentManager.DeleteStudent(2);

        Console.WriteLine("\nAfter Deleting Student:");
        studentManager.ViewStudent();

        Console.WriteLine("\nStudents above age 21:");
        studentManager.StudentsAboveAge(21);

        Console.WriteLine("\nStudents in Computer Science:");
        studentManager.StudentsByCourse("Computer Science");

        Console.ReadLine();
    }
}
