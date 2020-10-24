using System;


namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTableBuilder hashTable = new HashTableBuilder();

            
            Console.WriteLine($"Frequency of word is {hashTable.FindFrequencyOfWord()}");
        }
    }

}
