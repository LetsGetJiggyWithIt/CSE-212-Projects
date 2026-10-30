using System.Diagnostics;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /*
            Step 1: Create an array with a capacity of $length to store the multiples
            Step 2: Set array[0] to number
            Step 3: Create a for loop with $i = 1 to iterate $length - 1 times
            Step 4: Within the loop, set array[$i] to ($number + array[$i - 1])
            Step 5: Return the array after the loop is completed
        */

        var multiples = new double[length];
        multiples[0] = number;
        for (var i = 1; i <= length - 1; i++) {
            multiples[i] = multiples[i - 1] + number;
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /*
            Step 1: Create a for loop with $i = 0 that iterates ($data.count - $amount) times
            Step 2: Within the loop, do the following:
                * Add data[0] to data
                * Remove data[0] from data
        */
        Debug.WriteLine(amount);
        Debug.WriteLine($"Amount: Before: {string.Join( ",", data.ToArray() )}");
        for (var i = 0; i < data.Count - amount; i++) {
            data.Add(data[0]);
            data.RemoveAt(0);
        }
        Debug.WriteLine($"Amount: After: {string.Join( ",", data.ToArray() )}");
    }
}
