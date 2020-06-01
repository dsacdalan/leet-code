namespace LeetCode.Service
{
    public partial class Solution 
    {
        public int NumTeams(int[] rating) {
            var maxStartIndex = rating.Length - 3;
            var teams = 0;
            for(int i = 0; i <= maxStartIndex; i++)
            {
                for(int j = i + 1; j < rating.Length; j++)
                {
                    for(int k = j + 1; k < rating.Length; k++)
                    {
                        if ((rating[i] < rating[j] && rating[j] < rating[k]) ||
                            (rating[i] > rating[j] && rating[j] > rating[k]))
                        {
                            teams++;
                        }
                    }
                }
            }
            
            return teams;
        }
    }
}