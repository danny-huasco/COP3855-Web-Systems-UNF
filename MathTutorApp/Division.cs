
namespace MathTutorApp
{
    class Division

    {

        public int Divide(string name, string grade, int contador)
        {
            Console.WriteLine("Welcome to the Division Section! \n");
            Console.WriteLine("You will be asked to solve 3 division problems at level k-" + grade + ". \n");
            Console.WriteLine("Please enter your answer after each question. \n");
            Console.WriteLine("Let's get started! \n");

            Random rand = new Random();
            int num1, num2;
            //loop 3 times
            for (int i = 0; i < 3; i++)
            {
                //generate two random numbers
                num1 = rand.Next(1, 20);
                num2 = rand.Next(1, 20);
                //calculate
                double result = Math.Round((num1 / num2), 2);
                //ask question
                Console.WriteLine("What is " + num1 + " divided by " + num2 + "?");
                int userAnswer = Convert.ToDouble(Console.ReadLine());
                //compare with user's answer up to 2 decimal points
                if (Math.Round(userAnswer, 2) == result)
                {
                    Console.WriteLine("Correct, " + name + "! \n");
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
