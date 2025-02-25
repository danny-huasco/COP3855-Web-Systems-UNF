
namespace MathTutorApp
{
    class TutorApp
    {
        public static void Main()
        {
            string name, grade, res;
            bool i = true;
            //welcome menu
            Console.WriteLine("Welcome to the Multiplication and Division Tutor App! \n");
            Console.WriteLine("This app will ask questions on basic multiplication and division skills that an elementary student should master. \n");
            Console.WriteLine("We would like to get some information about you before we start. \n");
            //getting student info
            Console.WriteLine("To get started, please enter your full name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your grade level [1 to 5]:");
            grade = Console.ReadLine();
            //create student object
            Student student = new Student(name, grade);
            //additional info 
            Console.WriteLine(name + ", we appreciate you using this app. When you're ready to start please hit any key to continue...");
            Console.Clear();
            while (i)
            {
                //select math skill
                Console.WriteLine("Please specify the math skill you want to be tested in. \n Your options are: \n 1.Multiplication - enter 1 \n 2.Division - enter 2 \n Please enter your choice: ");
                res = Console.ReadLine();
                //validar entrada de datos
                if(res != "1" && res != "2")
                {
                    Console.WriteLine("Invalid entry. Please enter 1 or 2.");
                }
                else
                {
                    //create object based on user's choice
                    if (res == "1")
                    {
                        Multiplication mult = new Multiplication();
                        mult.Multiply();
                        //display results
                    }
                    else
                    {
                        Division div = new Division();
                        div.Divide();
                        //display results
                    }
                    //ask user if they want to continue
                    Console.WriteLine("Do you want to continue? [Y/N]");
                    res = Console.ReadLine();
                    if (res == "N" || res == "n")
                    {
                        i = false;
                        Console.WriteLine("Thank you for using the Math Tutor App. Goodbye!");
                        //log results and operations
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
                //display results
                
                //wanna do it again?        
            }
        }
    }
    }
}

