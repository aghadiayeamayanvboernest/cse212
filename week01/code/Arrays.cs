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

        // My plan for part 1
        // 1. First I make an array that has room for exactly 'length' numbers.
        // 2. Then I loop through it one slot at a time. My counter i starts at 0
        //    because that's where arrays start.
        // 3. For each slot, I multiply number by (i + 1). I add 1 because when i is 0
        //    I want number x 1, not number x 0. Without it, my first answer would
        //    always be 0 and the whole list would be off by one.
        // 4. Once every slot is filled, I return the array.
        var result = new double[length];
        for (var i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;  // replace this return statement with your own
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

        // My Plan for Part 2 
        // 1. I figure out where the last 'amount' items start by doing
        //    data.Count - amount. For 9 items and an amount of 3, that's index 6.
        //    I save this number first, because once I remove items the list gets
        //    shorter and the math won't work anymore.
        // 2. I copy those last items into their own list so I don't lose them.
        // 3. Now that I have a safe copy, I delete those same items from the end.
        // 4. Finally, I put my copy back in at the front, at index 0, which
        //    pushes everything else to the right.

        var start = data.Count - amount;
        var LastItems = data.GetRange(start, amount);
        data.RemoveRange(start, amount);
        data.InsertRange(0,LastItems);
    }
}
