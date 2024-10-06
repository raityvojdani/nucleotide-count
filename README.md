# DNA Nucleotide Count

## Introduction
This project is a simple C# implementation for counting the number of nucleotides (`A`, `C`, `G`, `T`) in a given DNA sequence. The program checks for valid characters and returns an error if any invalid nucleotide is found.

## Problem Statement
Given a string representing a DNA sequence, count how many of each nucleotide (`A`, `C`, `G`, and `T`) are present. If the string contains characters that aren't one of these four nucleotides, the program should throw an error.

### Examples:
1. **Input**: `"GATTACA"`  
   **Output**:  
   - `A`: 3  
   - `C`: 1  
   - `G`: 1  
   - `T`: 2  

2. **Input**: `"INVALID"`  
   **Output**: Error (Invalid character in DNA sequence)

## Solution Overview
- A method named `Count` is implemented inside a static class `NucleotideCount`.
- It uses a `Dictionary` to store the count of each nucleotide in the DNA sequence.
- The method iterates through each character of the input string:
  - If a character is not one of `A`, `C`, `G`, or `T`, an exception is thrown.
  - Otherwise, it increments the count of the corresponding nucleotide in the dictionary.
- The method returns the final dictionary with the counts of each nucleotide.

## Requirements
- C# 9.0 or later
- .NET Core 5.0 or later

## Setup and Run Instructions
1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/nucleotide-count.git
   cd nucleotide-count
