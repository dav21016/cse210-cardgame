public class Score
{
    private List<int> CurrentScore = new List<int>();

    public void score(int defaultScore) 
    {
        CurrentScore.Add(defaultScore);
    }
}
