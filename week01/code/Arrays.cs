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

        // Step 1: Create a new array, with the type double and a size of 'length'
        // The array will store the multiples of the given number
        double[] result = new double[length];

        // Step 2: Use a for loop to iterate from 0 to length - 1
        // Each index will represent the position in the array where we will store the multiple
        for (int i = 0; i < length; i++)
        {
            // Step 3: For each index, calculate the multiple 
            // The multiple is calculated by multiplying 'number' by (i + 1)
            result[i] = number * (i + 1);
        }

        return result; // Step 4: Return the completed array with the multiples
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

        // Step 1: Determine the length of the list
        int length = data.Count;

        // Step 2: Create a temporary list to store the rotated result
        List<int> temp = new List<int>();

        // Step 3: Add the last 'amount' elements to the temporary list
        for (int i = length - amount; i < length; i++)
        {
            temp.Add(data[i]);
        }

        // Step 4: Add the remaining elements from the beginning of the list
        // These elements come after the rotated portion of the list
        for (int i = 0; i < length - amount; i++)
        {
            temp.Add(data[i]);
        }

        // Step 5: Replace the original list with the rotated elements
        // Clear the orginal list and copy elements from the temporary list back to it
        data.Clear();
        data.AddRange(temp);
    }
}