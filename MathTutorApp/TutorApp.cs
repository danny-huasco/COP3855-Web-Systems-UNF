
namespace MathTutorApp
{
    class TutorApp
    {
        public static void Main()
        {
            string name, grade, res;
            bool i = true;
            int contM=0, contMC=0, contD=0, contDC=0;

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
                        contMC = mult.Multiply(name, grade, contMC);
                        //display results
                        contM++;

                    }
                    else
                    {
                        Division div = new Division();
                        contDC = div.Divide(name, grade, contDC);
                        //display results
                        contD++;
                    }
                    //ask user if they want to continue
                    Console.WriteLine("Would you like to try again? [Y/N]");
                    res = Console.ReadLine();
                    if (res == "N" || res == "n")
                    {
                        i = false;
                        //log results and operations based on problems solved
                        if (contM > 0)
                        {
                            Console.WriteLine("You solved " + contM + " multiplication problems and " + contMC + " were correct. \n");
                        }
                        else
                        {
                            Console.WriteLine("You did not attempt any multiplication problems. \n");
                        }

                        if (contD > 0)
                        {
                            Console.WriteLine("You solved " + contD + " division problems and " + contDC + " were correct. \n");
                        }
                        else
                        {
                            Console.WriteLine("You did not attempt any division problems. \n");
                        }
                    }
                    else
                    {
                        Console.Clear();
                    }
                }      
            }
        }
    }
}

