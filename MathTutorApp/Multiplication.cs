
namespace MathTutorApp
{
    class Multiplication
    {
        
       //loop 5 times

        public int Multiply(string name, string grade, int contador)
        {
            Console.WriteLine("Welcome to the Multiplication Section! \n");
            Console.WriteLine("You will be asked to solve 5 multiplication problems at level k-"+grade+". \n");
            Console.WriteLine("Please enter your answer after each question. \n");
            Console.WriteLine("Let's get started! \n");

            Random rand = new Random();
            int num1, num2;
            //loop 5 times
            for (int i = 0; i < 5; i++)
            {
                //generate two random numbers
                num1 = rand.Next(1, 20);
                num2 = rand.Next(1, 20);
                //calculate
                int result = num1 * num2;
                //ask question
                Console.WriteLine("What is " + num1 + " times " + num2 + "?");
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                //compare with user's answer
                if (userAnswer == result)
                {
                    Console.WriteLine("Correct, "+name+"! \n");
                    contador++;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is " + result + ". \n");
                }
            }
            return contador;

        }

    }
}
