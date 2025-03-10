
namespace MathTutorApp
{
    class Student
    {
        private string name;
        private string grade;
        
        public Student(string name, string grade)
        {
            this.name = name;
            this.grade = grade;
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        
        public void toString()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + grade);
        }
    }
}