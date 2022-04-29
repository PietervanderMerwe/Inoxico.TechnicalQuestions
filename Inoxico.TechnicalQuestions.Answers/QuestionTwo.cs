
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {
        public static int GetPitDepth(int[] Points)
        {
            var arrayLength = Points.Length - 1;
            var depth = -1;

            //Check if array is long enough
            if (arrayLength < 2)
            {
                return depth;
            }

            for (int i = 0; i < arrayLength - 2; i++)
            {
                var startingPoint = Points[i];
                var j = i + 1;
                while (Points[j] < Points[j - 1] && j < arrayLength - 1)
                {
                    j++;
                }
                //check if flat
                if (j == i + 1)
                {
                    continue;
                }
                j = j - 1;

                var lowestPoint = Points[j];

                var k = j + 1;
                while (Points[k] > Points[k - 1] && k < arrayLength)
                {
                    k++;
                }
                //check if flat
                if (k == j + 1)
                {
                    continue;
                }
                k = k - 1;
                var endPoint = Points[k];

                //Checks that points start above ground
                if (endPoint >= 0 && startingPoint >= 0)
                {
                    depth = Math.Max(depth, Math.Min(startingPoint - lowestPoint, endPoint - lowestPoint));
                }

            }

            return depth;
        }
    }
}
