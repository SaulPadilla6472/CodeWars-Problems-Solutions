/*Write a function that takes an array of numbers and returns the sum of the numbers. The numbers can be negative or non-integer. If the array does not contain any numbers then you should return 0.

Examples
Input: [1, 5.2, 4, 0, -1]
Output: 9.2

Input: []
Output: 0

Input: [-2.398]
Output: -2.398 */

public class Kata
{
    public static double SumArray(double[] array) //returns the sum of the numbers in the array
    {
        double sum = 0; //initialize sum, we will add the numbers to this
        foreach (var num in array) //for each number in the array
        {
            sum += num; //add the number to the sum
        }
        return sum;//return the sum
    }
}