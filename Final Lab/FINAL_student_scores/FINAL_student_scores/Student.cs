using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace maint_student_scores
{
    public class Student
    {
        private List<int> Scores = new List<int>();

        public string Name
        { get; set; }

        public bool AddScore(int score)
        {
            try
            {
                Scores.Add(score);
            }
            catch { return false; }
            return true;
        }

        public List<int> GetScores()
        {
            return Scores;
        }

        public int GetScoreAt(int index)
        {
            return (int)Scores[index];
        }

        public int GetScoreTotal()
        {
            int sum = 0;
            foreach (int score in Scores)
            {
                sum += score;
            }
            return sum;
        }

        public int GetScoreCount()
        {
            return Scores.Count;
        }

        public int GetScoreAverage()
        {
            return GetScoreTotal() / GetScoreCount();
        }

        public void DestroyScores()
        {
            Scores = new List<int>();
        }
    }
}

