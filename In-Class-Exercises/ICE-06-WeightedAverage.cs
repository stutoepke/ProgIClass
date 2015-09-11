using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightedAverage
{
    class Program
    {
        static void Main(string[] args)
        {

            string studentName = "Stuart";

            const double CRITERIA_PRACTICE_EXERCISE = .1;
            const double CRITERIA_HOMEWORK = .25;
            const double CRITERIA_QUIZES = .05;
            const double CRITERIA_EXAMS = .3;
            const double CRITERIA_FINAL_PRACTICE_EXAM = .15;
            const double CRITERIA_FINAL_EXAM = .15;

            int avgGradeNinetySix = 96;
            int avgGradeSeventyTwo = 72;
            int avgGradeEightyFive = 85;
            int avgGradeEighty = 80;
            int avgGradeSeventyFive = 75;
            int avgGradeNinety = 90;

            double resultOne;
            double resultTwo;
            double resultThree;
            double resultFour;
            double resultFive;
            double resultSix;

            double totalResults;

            resultOne = CRITERIA_PRACTICE_EXERCISE * avgGradeNinetySix;
            resultTwo = CRITERIA_HOMEWORK * avgGradeSeventyTwo;
            resultThree = CRITERIA_QUIZES * avgGradeEightyFive;
            resultFour = CRITERIA_EXAMS * avgGradeEighty;
            resultFive = CRITERIA_FINAL_PRACTICE_EXAM * avgGradeSeventyFive;
            resultSix = CRITERIA_FINAL_EXAM * avgGradeNinety;

            totalResults = resultOne + resultTwo + resultThree + resultFour + resultFive + resultSix;

            Console.WriteLine(studentName + "'s average grade for each criteria:");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Practice Exercises: " + avgGradeNinetySix);
            Console.WriteLine("Homework: " + avgGradeSeventyTwo);
            Console.WriteLine("Quizes: " + avgGradeEightyFive);
            Console.WriteLine("Exams: " + avgGradeEighty);
            Console.WriteLine("Final Practice Exam: " + avgGradeSeventyFive);
            Console.WriteLine("Final Exam: " + avgGradeNinety);
            Console.WriteLine(" ");

            Console.WriteLine(studentName + "'s results for each criteria:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Practice Exercises: " + resultOne + "%");
            Console.WriteLine("Homework: " + resultTwo + "%");
            Console.WriteLine("Quizes: " + resultThree + "%");
            Console.WriteLine("Exams: " + resultFour + "%");
            Console.WriteLine("Final Practice Exam: " + resultFive + "%");
            Console.WriteLine("Final Exam: " + resultSix + "%");
            Console.WriteLine(" ");


            Console.WriteLine(studentName + " recieved a final grade of: " + totalResults + "%");
            Console.ReadLine();

        }
    }
}
