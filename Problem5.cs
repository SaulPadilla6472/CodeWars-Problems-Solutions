/*
There was a test in your class and you passed it. Congratulations!
But you're an ambitious person. You want to know if you're better than the average student in your class.

You receive an array with your peers' test scores. Now calculate the average and compare your score!

Return True if you're better, else False!

Note:
Your points are not included in the array of your class's points. For calculating the average point you may add your point to the given array!
*/
public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        int total = 0; //create a variable to hold the total points
        foreach(int point in ClassPoints) //loop through each point in the array
        {
            total += point; //sum all the points
        }
        total += YourPoints; //add your points to the total
        float avg = total/(ClassPoints.Length + 1); //calculate the average
        return avg < YourPoints; //return true if your points are greater than the average
    }
}

