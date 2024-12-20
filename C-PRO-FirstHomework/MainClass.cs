﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using static C_PRO_FirstHomework.ArrayReverse;

namespace C_PRO_FirstHomework;

public class MainClass
{
    public class PerformanceTest
    {
        private const string Cities = "London, Paris, Rome";
        private const string Separator = ",";
        private const string SubString = "Rome";
        private const string DnaChain = "ATGAGGCCCTCCACTCAGGACGGATTTCCCACATCAGTAGGAAAATAGTC";
        private int[] numbers = [1, 2, 3, 4, 5];
        

        [Benchmark]
        public string[] BuiltInSplit() => Cities.Split(Separator);
        
        [Benchmark]
        public string[] MySplit() => StringSplitter.SplitLine(Cities, Separator);
        
        [Benchmark]
        public bool BuiltInContains() => Cities.Contains(SubString);
        
        [Benchmark]
        public bool MyContains() => StringContains.ContainsSubstring(Cities, SubString);
        
        [Benchmark]
        public void BuiltInReverse() => Array.Reverse(numbers);
        
        [Benchmark]
        public int[] MyReverse() => ReverseArray(numbers);
        
        [Benchmark]
        public string DecompressDna() => DNA.DecompressDna(DNA.CompressDna(DnaChain));
        
        [Benchmark]
        public string MyDecompressDna() => DNA.MyDecompressDna(DNA.MyCompressDna(DnaChain));
    }
    
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<PerformanceTest>();
        
        //Homework 1
        //Task 1
        char[] alphabet =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
            'v', 'w',
            'x', 'y', 'z'
        };

        char selectedLetter = 'm';

        AlphabetChars.GetLetterRowNumberAndChangeCase(alphabet, selectedLetter);


        //Task 2
        string cities = "London, Paris, Rome";
        string symbol = ",";
        
        string[] splittedCities = StringSplitter.SplitLine(cities, symbol);

        foreach (var city in splittedCities)
        {
            Console.WriteLine(city);
        }

        //Task 3
        string mainString = "London, Paris, Rome";
        string subString = "Rome";

        bool doesMainStringContainSubString = StringContains.ContainsSubstring(mainString, subString);

        if (doesMainStringContainSubString)
        {
            Console.WriteLine("Does main string contain substring: yes!");
        }
        else
        {
            Console.WriteLine("Does main string contain substring: no!");
        }

        //Task 4
        int number = 313;
        NumberReader.ReadNumber(number);

        //Task 5
        int a = 5;
        int b = 2;

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("a = " + a + ", " + "b = " + b);
        
        //Homework 2
        Console.WriteLine("----------------------------------------");

        //Task 1
        int[] numbers = [1, 2, 3, 4, 5];
        int[] reversedArray = ReverseArray(numbers);
        
        for (int i = 0; i < reversedArray.Length; i++)
        {
            Console.WriteLine(reversedArray[i]);
        }
        
        //Task 2
        string text = "Hello! How are you doing, man";
        string[] prohibitedWords = { "Man" };
        
        StringFilter.FilterString(text, prohibitedWords);
        
        //Task 3
        string randomSymbols = SymbolGenerator.RandomSymbolGenerator(3);

        Console.WriteLine(randomSymbols);
        
        //Task 4
        int n = 5; 
        int maxValue = 50;

        int[] uniqueRandomNumbers = 
            ArrayWithSkippedElement
                .GetRandomNumberArray(n, maxValue);
        
        ArrayWithSkippedElement
                .RemoveRandomArrayElement(uniqueRandomNumbers);

        int holeIndex = 
            ArrayWithSkippedElement
                .HoleSeeker(uniqueRandomNumbers);

        Console.WriteLine("Unique Random Numbers:");
        foreach (int item in uniqueRandomNumbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Hole is element number " + (holeIndex + 1));
        
        //Task 5
        int dnaLength = 50;
        string dnaChain = DNA.GetDnaAsString(dnaLength);
        Console.WriteLine(dnaChain);

        byte[] dnaAsBytes = DNA.CompressDna(dnaChain);
        Console.WriteLine(BitConverter.ToString(dnaAsBytes));
        
        byte[] myDnaAsBytes = DNA.MyCompressDna(dnaChain);
        Console.WriteLine(BitConverter.ToString(myDnaAsBytes));

        string dna = DNA.DecompressDna(dnaAsBytes);
        Console.WriteLine(dna);
        
        string myDna = DNA.MyDecompressDna(myDnaAsBytes);
        Console.WriteLine(myDna);
        
        //Task 6
        string originalText = "String for encryption";
        byte key = 0x01; 

        Console.WriteLine("Original Text: " + originalText);

        byte[] encryptedBytes = EncryptDecrypt.Encrypt(originalText, key);
        Console.WriteLine("Encrypted text: " + BitConverter.ToString(encryptedBytes));

        string decryptedText = EncryptDecrypt.Decrypt(encryptedBytes, key);
        Console.WriteLine("Decrypted Text: " + decryptedText);
    }
}