
//main code



Console.WriteLine("Hello, Welcome to the translator for Pig Latin!");

//okay lets start a loop so we can continue if we want to

bool runTranslator = true;
while (runTranslator)
{




    Console.WriteLine("Please input the word or sentence you would like to translate:");
    string sentence = Console.ReadLine();
    string[] words = sentence.Split();

    foreach (string word in words)
    {

        if (IsAVowel(word) == true)
        {
            Console.Write(TranslateVowel(word));
            Console.Write(" ");
        }
        else
        {
            Console.Write(TranslateConsonant(word));
            Console.Write(" ");
        }

    }



    //methods

    //method#1


    static bool IsAVowel(string words)
    {
        char[] vowelArray = { 'a', 'e', 'i', 'o', 'u' };
        char firstLetter = (words[0]);

        if (Array.IndexOf(vowelArray, firstLetter) != -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    //method #2
    static string TranslateVowel(string word)
    {

        string translation = word + "way";
        return translation;

    }
    //method #3
    static string TranslateConsonant(string words)
    {
        char firstLetter = words[0];

        char[] vowelArray = { 'a', 'e', 'i', 'o', 'u' };
        int findFirstVowel = -1;
        string ctranslation = string.Empty;
        for (int i = 0; i < words.Length; i++)
        {
            if (Array.IndexOf(vowelArray, char.ToLower(words[i])) != -1)
            {
                findFirstVowel = i;
                break;
            }

        }


        if (findFirstVowel != -1)
        {
            string mainWord = words.Substring(findFirstVowel);
            string firstPart = words.Substring(0, findFirstVowel);
            ctranslation = mainWord + firstPart + "ay";
        }

        else
        {
            ctranslation = words + "ay";
        }


        return ctranslation;
    }


    // alright time to make sure we can get out of the loop

    while (true)
    {
        Console.WriteLine("\nWould you like to translate again? y/n");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "y")
        {
            break;
        }
        else if (choice == "n")
        {
            runTranslator = false;
            break;
        }
        else
        {
            Console.WriteLine("that answer is invalid, please type y to continue or n to quit");
        }
    }
}

