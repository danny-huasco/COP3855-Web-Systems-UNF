using static System.Console;
namespace StudentApp
{
    class StudentApp
    {
        static void Main()
        {
            Student firstStudentObject = new Student();
            firstStudentObject.StudentFirstName = AskForStudentName("First");
            firstStudentObject.StudentLastName = AskForStudentName("Last");
            firstStudentObject.StudentNumber = AskForStudentNumber();
            firstStudentObject.Major = AskForMajor(firstStudentObject.StudentFirstName);
            firstStudentObject.Score1 = AskForExamScore(1);
            firstStudentObject.Score2 = AskForExamScore(2);
            firstStudentObject.Score3 = AskForExamScore(3);
            Clear();
            WriteLine("First Student");
            WriteLine(firstStudentObject.ToString());
            Student secondStudentObject = new Student("2345");
            secondStudentObject.Score1 = 95;
            secondStudentObject.Score2 = 62;
            secondStudentObject.Score3 = 87;
            WriteLine("\n\nSecond Student");
            WriteLine("Student Number: " + secondStudentObject.StudentNumber +
            "\nAverage: {0:F1}", secondStudentObject.CalculateAverage());
            Student thirdStudentObject = new Student("5432", "Randolph", "Wonder");
            thirdStudentObject.Major = "Math";
            thirdStudentObject.Score1 = 95;
            thirdStudentObject.Score2 = 87;
            thirdStudentObject.Score3 = 72;
            WriteLine("\n\nThird Student");
            WriteLine(thirdStudentObject);
            Student aStudentObject = new Student("1234", "Maria", "Smith", 97, 75, 87, "CS");
            WriteLine("\n\nLast Student");
            WriteLine("Student Name: " + aStudentObject.StudentFirstName +
            " " + aStudentObject.StudentLastName +
            "\nStudent Number: " + aStudentObject.StudentNumber +
            "\nMajor: " + aStudentObject.Major +
            "\nExam Score 1: " + aStudentObject.Score1 +
            "\nExam Score 2: " + aStudentObject.Score2 +
            "\nExam Score 3: " + aStudentObject.Score3 +
            "\nExam Average: " + aStudentObject.CalculateAverage().ToString("F1"));
            ReadKey();
        }
        static int AskForExamScore(int whichOne)
        {
            string inValue;
            int aScore;
            Write("Enter a value for Score {0}: ", whichOne);
            inValue = ReadLine();
            aScore = int.Parse(inValue);
            return aScore;
        }
        static string AskForStudentName(string whichOne)
        {
            string inValue;
            Write("Enter Student {0} Name: ", whichOne);
            inValue = ReadLine();
            return inValue;
        }
        static string AskForMajor(string name)
        {
            string inValue;
            Write("Enter {0}\'s Major: ", name);
            inValue = ReadLine();
            return inValue;
        }
        static string AskForStudentNumber()
        {
            string inValue;
            Write("Enter Student Number: ");
            inValue = ReadLine();
            return inValue;
        }
    }
}