using System.Text.RegularExpressions;

namespace App.Service
{
    public class LongestIncreasingSubsequenceService : ILongestIncreasingSubsequenceService
    {
        public string FindLongestIncreasingSubsequence(string input)
        {
            int[] sequence = ParseInput(input);
            int[] longestSubsequence = GenerateOutput(sequence);
            return string.Join(" ", longestSubsequence);
        }

        /// <summary>
        /// Check for valid input
        /// - Must be a valid non empty string
        /// - Must contain only numbers
        /// </summary>
        public bool ValidateInput(string input)
        {
            bool containsOnlyNumbers = Regex.IsMatch(input, @"^(?!.* $)\d+(\s\d+)*$");

            if (string.IsNullOrEmpty(input) || !containsOnlyNumbers)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Convert input into an array by stripping out "" and space in-between numbers
        /// </summary>
        private int[] ParseInput(string input)
        {
            return input.Split(' ').Select(int.Parse).ToArray();
        }

        /// <summary>
        /// Generate an array of longest increasing subsequence
        /// </summary>
        private int[] GenerateOutput(int[] input)
        {
            List<int> list = new List<int>();
            List<int> longestList = new List<int>();

            // Initialize a variable to keep track of the length of the longest increasing subsequence
            int highestCount = 1;

            // Loop through each element in the input array
            for (int i = 0; i < input.Length; i++)
            {
                // Add the current element to the current increasing subsequence
                list.Add(input[i]);

                // Iterate through the elements following the current one
                for (int j = i + 1; j < input.Length; j++)
                {
                    // If the next element is greater than the current one, add it to the subsequence
                    if (input[i] < input[j])
                    {
                        list.Add(input[j]);
                    }
                    else
                    {
                        // If the next element is not greater, break out of the inner loop
                        break;
                    }
                    // Update the outer loop index to the current inner loop index
                    i = j;
                }

                // Compare the length of the current increasing subsequence with the longest one found so far
                if (highestCount < list.Count)
                {
                    // If the current subsequence is longer, update the longest subsequence
                    highestCount = list.Count;
                    longestList = new List<int>(list);
                }

                // Clear the current subsequence to start building a new one in the next iteration
                list.Clear();
            }

            return longestList.ToArray();
        }
    }
}
