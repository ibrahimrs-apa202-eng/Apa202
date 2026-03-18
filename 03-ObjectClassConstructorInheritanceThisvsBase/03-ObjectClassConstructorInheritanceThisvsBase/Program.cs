class Program
{
    static void Main()
    {
        Student s1 = new Student("Ali", "Aliyev", 20, "ali@mail.com", "S1",
            "ST001", "IT", 88.5, 2);

        Student s2 = new Student("Veli", "Veliyev", 21, "veli@mail.com", "S2",
            "ST002", "IT", 92.0, 3);

        Student s3 = new Student("Aysel", "Memmedova", 19, "aysel@mail.com", "S3",
            "ST003", "Design", 68.5, 1);

        // Teachers
        Teacher t1 = new Teacher("Rashad", "Hasanov", 40, "r@mail.com", "T1",
            "CS", "Programming", 800, 15);

        Teacher t2 = new Teacher("Leyla", "Quliyeva", 35, "l@mail.com", "T2",
            "Math", "Algebra", 800, 8);

        Administrator admin = new Administrator("Nigar", "Huseynova", 45, "n@mail.com", "A1",
            "Dekan", "IT", 5);

        double totalScholarship = 0;
        decimal totalSalary = 0;

        Student[] students = { s1, s2, s3 };
        foreach (var s in students)
        {
            s.ShowStudentInfo();
            double scholarship = s.CalculateScholarship();
            Console.WriteLine($"Təqaüd: {scholarship} AZN\n");
            totalScholarship += scholarship;
        }
        Teacher[] teachers = { t1, t2 };
        foreach (var t in teachers)
        {
            t.ShowTeacherInfo();
            decimal salary = t.CalculateSalary();
            Console.WriteLine($"Maaş: {salary} AZN\n");
            totalSalary += salary;
        }

        admin.ShowAdminInfo();
        admin.GrantAccess(s1);

        
        Console.WriteLine("\n--- Statistika ---");
        Console.WriteLine($"Ümumi təqaüd: {totalScholarship} AZN");
        Console.WriteLine($"Ümumi maaş: {totalSalary} AZN");
    }
}