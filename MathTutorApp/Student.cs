
namespace MathTutorApp
{
    class Student
    {
        private string name;
        private int age;
        
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
        public void toString()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
}