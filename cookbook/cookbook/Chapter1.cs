

using System.Linq;

namespace cookbook
{
    public class Chapter1
    {
        public (int average, int studentCount) GetAverageAndCount(int[] scores)
        {
            var returnTuple = (ave: 0, sCount: 0);

            returnTuple = (scores.Sum() / scores.Count(), scores.Count());

            return returnTuple;
        }

    }
}
