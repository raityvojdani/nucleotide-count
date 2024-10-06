using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        // Create a dictionary to store the count of each nucleotide
        var nucleotideDictionary = new Dictionary<char, int>
        {
            {'A', 0}, {'C', 0}, {'G', 0}, {'T', 0}
        };

        // Iterate through each character in the input sequence
        foreach (char c in sequence)
        {
            // Check if the character is a valid nucleotide (A, C, G, or T)
            if (!nucleotideDictionary.ContainsKey(c))
            {
                // If an invalid character is found, throw an error
                throw new ArgumentException($"Invalid character in DNA sequence: {c}");
               
            }

            // Increment the count of the corresponding nucleotide
            nucleotideDictionary[c]++;
        }

        // Return the final dictionary with the counts
        return nucleotideDictionary;
    }
}
