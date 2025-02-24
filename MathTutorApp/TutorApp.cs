
using System.Runtime.CompilerServices;

namespace MathTutorApp
{
    class TutorApp
    {
        public static void Main() {
            private string name, grade;
            //create menu
            Console.WriteLine("Welcome to the Multiplication and Division Tutor App! \n");
            Console.WriteLine("This app will ask questions on basic multiplication and division skills that an elementary student should master. \n");
            Console.WriteLine("We would like to get some information about you before we start. \n");
            Console.WriteLine("To get started, please enter your full name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your grade level [1 to 5]:");
            grade = Console.ReadLine();
            Console.WriteLine(name+", we appreciate you using this app. When you're ready to start please hit any key to continue...");
            Console.clear();
            Console.WriteLine("Please specify the math skill you want to be tested in. \n Your options are: \n 1.Multiplication - enter 1 \n 2.Division - enter 2 \n Please enter your choice: ");
            Console.ReadLine();
            //validar entrada de datos (quizas usar metodo externo para esto) con loop 
            //display results
            //log results and operations
            //wanna do it again?
        }
    }

}
