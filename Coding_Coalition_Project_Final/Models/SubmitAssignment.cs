
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Coalition_Project.Models
{
    public class SubmitAssignment
    {
        [Key]
        public int SAssignmentID { get; set; }
        public int Points { get; set; }
        public int maxPoints { get; set; }
        public string submissionType { get; set; }
        public string AssignmentLocation { get; set; }
        public int UserID { get; set; }

         public static bool TestUserID(int UserID)
        {
            return UserID != 0;
        }
        public int CourseID { get; set; }

         public static bool TestCourseID(int CourseID)
        {
            return CourseID != 0;
        }
        public int AssignmentID { get; set; }

        public static int calcScore(List<int> arr)
        {
            int total = 0;
            foreach(int item in arr)
            {
                total += item;
            }
            return total;
        }

        public static int calcPossibleScore(List<int> arr)
        {
            int total = 0;
            foreach (int item in arr)
            {
                total += item;
            }
            return total;
        }

        public static List<int> calulateBoxPlot(List<int> scores)
        {
            scores = scores.OrderBy(x => x).ToList();
            List<int> lower = new List<int>();
            List<int> upper = new List<int>();
            List<int> returnScores = new List<int>();
            if (scores.Count() == 0)
            {
                //min = 0;
                //q1 = 0;
                //med = 0;
                //q3 = 0;
                //max = 0;
                List<int> emptyArray = new List<int> { 0, 0, 0, 0, 0 };
                return emptyArray;
            }
            else if (scores.Count() == 1)
            {
                //min = scores[0];
                //q1 = scores[0];
                //med = scores[0];
                //q3 = scores[0];
                //max = scores[0];
                List<int> singleArray = new List<int> { scores[0], scores[0], scores[0], scores[0], scores[0] };
                return singleArray;
            }
            else if (scores.Count() % 2 == 0)
            {

                int halfway = scores.Count() / 2;
                for (int i = 0; i < scores.Count(); i++)
                {
                    if (i < halfway)
                    {
                        lower.Add(scores[i]);
                    }
                    else
                    {
                        upper.Add(scores[i]);
                    }
                }

                //min = lower[0];
                //max = upper[upper.Count() - 1];
                //med = (lower[lower.Count() - 1] + upper[0]) / 2;
                returnScores.Add(lower[0]);
                returnScores.Add(upper[upper.Count() - 1]);
                returnScores.Add((lower[lower.Count() - 1] + upper[0]) / 2);
            }
            else
            {
                int halfway = scores.Count() / 2;
                for (int i = 0; i < scores.Count(); i++)
                {
                    if (i < halfway)
                    {
                        lower.Add(scores[i]);
                    }
                    else if (i == halfway)
                    {
                        //med = scores[i];
                        returnScores.Add(scores[i]);
                    }
                    else
                    {
                        upper.Add(scores[i]);
                    }
                }

                //min = scores[0];
                //max = scores[scores.Count() - 1];
                returnScores.Add(scores[0]);
                returnScores.Add(scores[scores.Count() - 1]);
            }
            if (lower.Count() % 2 == 0 && scores.Count() > 1)
            {
                int halfway = lower.Count / 2;
                //q1 = (lower[halfway - 1] + lower[halfway]) / 2;
                returnScores.Add((lower[halfway - 1] + lower[halfway]) / 2);
                Console.WriteLine(upper.Count());
                //q3 = (upper[halfway - 1] + upper[halfway]) / 2;
                returnScores.Add((upper[halfway - 1] + upper[halfway]) / 2);
            }
            else if (lower.Count() % 2 == 1 && scores.Count() > 1)
            {
                int halfway = lower.Count / 2;
                //q1 = lower[halfway];
                //q3 = upper[halfway];
                Console.WriteLine(upper.Count());
                returnScores.Add(lower[halfway]);
                returnScores.Add(upper[halfway]);
            }
            returnScores = returnScores.OrderBy(x => x).ToList();
            return returnScores;
        }
    }
}
