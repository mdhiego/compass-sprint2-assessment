using System;
using System.Text;

class URI
{
    static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;

            bool useUpperCase = true;
            var output = new StringBuilder();

            foreach (char character in input)
            {
                if (character == ' ') output.Append(character);
                else
                {
                    output.Append(useUpperCase ? char.ToUpper(character) : char.ToLower(character));
                    useUpperCase = !useUpperCase;
                }
            }

            Console.WriteLine(output.ToString());
        }
    }
}