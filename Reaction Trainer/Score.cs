namespace Reaction_Trainer
{
    public class Score
    {
        private int score = 0;
        private double avgTime = -1;
        public void setScore(int user_score)
        {
            score = user_score;
        }
        public void setAvgTime(double user_avgTime)
        {
            avgTime = user_avgTime;
        }
        public int getScore()
        {
            return score;
        }
        public double getAvgTime()
        {
            return avgTime;
        }
    }
}
