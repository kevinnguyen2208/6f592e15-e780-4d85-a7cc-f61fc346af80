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
            List<int> lis = new List<int>(); //longest increasing subsequence list
            List<int> currentSeq = new List<int>(); //current subsequence list

            for (int i = 0; i < input.Length - 1; i++)
            {
                // Check if the current element is less than the next element
                if (input[i] < input[i + 1])
                {
                    // Add it to the current sequence
                    currentSeq.Add(input[i]);
                }
                else
                {
                    // Add the current element to the current sequence
                    currentSeq.Add(input[i]);

                    // Check if the length of the current sequence is greater than the length of the LIS
                    if (currentSeq.Count > lis.Count)
                    {
                        // Update the LIS
                        lis = new List<int>(currentSeq);
                    }

                    // Clear the current sequence to start a new one
                    currentSeq.Clear();
                }
            }

            // Include the last element in the current sequence
            currentSeq.Add(input[input.Length - 1]);

            // Check if the length of the current sequence is greater than the length of the LIS
            if (currentSeq.Count > lis.Count)
            {
                // Update the LIS
                lis = new List<int>(currentSeq);
            }

            // Convert the LIS list to an array and return it
            return lis.ToArray();
        }
    }
}
