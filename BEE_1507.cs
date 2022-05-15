using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        var testCases = new Dictionary<string, IEnumerable<string>>();

        for (int i = 0; i < N; i++)
        {
            string testCase = Console.ReadLine();

            int Q = int.Parse(Console.ReadLine());
            string[] queries = new string[Q];

            for (int j = 0; j < Q; j++)
                queries[j] = Console.ReadLine();

            testCases.Add(testCase, queries);
        }

        foreach (var testCase in testCases)
            foreach (var query in testCase.Value)
                Console.WriteLine(IsSubString(testCase.Key, query) ? "Yes" : "No");
    }

    private static bool IsSubString(string word, string query)
    {
        int j = 0;
        for (int i = 0; i < word.Length && j < query.Length; i++)
            if (query[j] == word[i]) j++;

        return j == query.Length;
    }
}