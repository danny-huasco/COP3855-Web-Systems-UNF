
namespace JoggingTracker
{
    public class JoggingDistance
    {
        const double STRIDE = 2.5;
        const int FEET_PER_MILE = 5280;
        private static int initialStrideCount, finalStrideCount;
        private static int hours, minutes, totalMinutes;
        private static double numberOfStepsPerMin, distanceTraveled;

        public static void Main()
        {
            DisplayInstructions();
            initialStrideCount = GetNumberStrides("First");            
            finalStrideCount = GetNumberStrides("Last");            
            InputJoggingTime();
            totalMinutes = CalculateTime(hours, minutes);
            numberOfStepsPerMin = CalculateAvgSteps(initialStrideCount, finalStrideCount);
            distanceTraveled = CalculateDistance(numberOfStepsPerMin, totalMinutes);
            DisplayResults();
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("INSTRUCTIONS");
            Console.WriteLine("Enter all the values asked in the following prompts.");
        }
        public static int GetNumberStrides(string when)
        {
            Console.WriteLine("Enter steps performed during the "+when+" minute");
            string numSteps = Console.ReadLine();
            return int.Parse(numSteps);
        }
        public static void InputJoggingTime()
        {
            Console.WriteLine("Enter hours: ");
            hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes: ");
            minutes = int.Parse(Console.ReadLine());
        }
        public static double CalculateAvgSteps(int initial, int final)
        {
            return (Convert.ToDouble(initial) + Convert.ToDouble(final)) / 2;
        }
        public static int CalculateTime(int hrs, int mins)
        {
            return (hrs * 60) + mins;
        }
        public static double CalculateDistance(double stepsPerMin, int totalMins)
        {
            return stepsPerMin * STRIDE * totalMins / FEET_PER_MILE;
        }
        public static void DisplayResults()
        {
            Console.WriteLine("The average stride is: {0:F1}", numberOfStepsPerMin);
            Console.WriteLine("The total of jogging time was: {0:F0} minutes", totalMinutes);
            Console.WriteLine("The distance traveled was: {0:F1} miles", distanceTraveled);
        }
    }
}
