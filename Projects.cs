

using System.Runtime.Intrinsics.X86;

using System.IO;


class Program
{

    static void ShapeAreaCalculator()
    {
        string answer;

        float height;
        float width;
        float radius;

        float result;

        Console.WriteLine("What shape would you like to find the area of? Please enter 'r' for rectangle or any other key for circle.");

        answer = Console.ReadLine();

        if (answer == "r")
        {
            Console.WriteLine("Please enter the height of the rectangle.");
            height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width of the rectangle.");
            width = float.Parse(Console.ReadLine());

            result = height * width;
        }
        else
        {
            Console.WriteLine("Please enter the radius of the circle.");
            radius = float.Parse(Console.ReadLine());

            result = (float)Math.PI * (radius * radius);
        }

        Console.WriteLine("The result is " + result);

        Console.ReadKey();
    }
    static void Calculator()
    {
        string answer;

        float height;
        float width;
        float radius;

        float result;

        Console.WriteLine("What shape would you like to find the area of? Please enter 'r' for rectangle or any other key for circle.");

        answer = Console.ReadLine();

        if (answer == "r")
        {
            Console.WriteLine("Please enter the height of the rectangle.");
            height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width of the rectangle.");
            width = float.Parse(Console.ReadLine());

            result = height * width;
        }
        else
        {
            Console.WriteLine("Please enter the radius of the circle.");
            radius = float.Parse(Console.ReadLine());

            result = (float)Math.PI * (radius * radius);
        }

        Console.WriteLine("The result is " + result);

        Console.ReadKey();
    }

    static void Quize()
    {
        string[] text = File.ReadAllLines("questions.txt");
        List<string> questions = new List<string>();
        List<string> answers = new List<string>();

        for (int i = 0; i < text.Length; i++)
        {
            if (i % 4 == 0)
                questions.Add(text[i]);
            else
                answers.Add(text[i]);
        }

        int questionIndex = 0;
        int answerIndex = 0;
        int score = 0;

        while (questionIndex < questions.Count)
        {
            Console.WriteLine("Question: " + questions[questionIndex]);
            questionIndex++;

            int correctAnswer = 0;

            for (int i = 0; i < 3; i++)
            {
                if (answers[answerIndex].StartsWith(">"))
                    correctAnswer = i + 1;

                Console.WriteLine(i + 1 + "." + answers[answerIndex].Replace(">", ""));

                answerIndex++;
            }

            int answer = int.Parse(Console.ReadLine());

            if (answer == correctAnswer)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
                Console.WriteLine("Incorrect.");
        }

        Console.WriteLine("End of quiz! Your score was " + score + " points!");
        Console.ReadKey();
    }
    static void Main(string[] args) {
        //ShapeAreaCalculator();
        //Calculator();
        Quize();

    }  
}

