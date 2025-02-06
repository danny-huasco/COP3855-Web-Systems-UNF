namespace StudentApp
{
    class Student
    {
        private string studentNumber;
        private string studentLastName;
        private string studentFirstName;
        private int score1;
        private int score2;
        private int score3;
        private string major;
        
        public Student(){}//default constructor
        
        //one argument constructor
        public Student(string sID)
        {
            studentNumber = sID;
        }

        //three args constructor
        public Student(string sID, string sLastName, string sFirstName)
        {
            studentNumber = sID;
            studentLastName = sLastName;
            studentFirstName = sFirstName;
        }

        //seven args constructor
        public Student(string sID, string sLastName, string sFirstName, int s1, int s2, int s3, string maj)
        {
            studentNumber = sID;
            studentLastName = sLastName;
            studentFirstName= sFirstName;
            score1 = s1;
            score2 = s2;
            score3 = s3;
            major = maj;
        }

        //Getters and Setters
        public string StudentLastName
        {
            get { return studentLastName; }
            set { studentLastName = value; }
        }
        public string StudentFirstName
        {
            get { return studentFirstName; }
            set { studentFirstName = value; }
        }
        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }
        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        public int Score1
        {
            get { return score1; }
            set { score1 = value; }
        }
        public int Score2
        {
            get { return score2; }
            set { score2 = value; }
        }
        public int Score3
        {
            get { return score3; }
            set { score3 = value; }
        }
        public double CalculateAverage()
        {
            return (score1 + score2 + score3)/3.0;
        }

        public override string ToString()
        {
            return "Name: "+studentFirstName+" "+studentLastName+"\nMajor: "+major+"\nScore Average: " + CalculateAverage().ToString("F2");
        }
    }
}
