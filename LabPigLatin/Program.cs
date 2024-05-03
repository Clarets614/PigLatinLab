

//maincode

using System.Diagnostics.Tracing;
using System.Globalization;




Console.WriteLine("Hello, Welcome to the translator for Pig Latin!");

//okay lets start a loop so we can continue if we want to

bool runTranslator = true;
while (runTranslator)
{





Console.WriteLine("Please enter a word to translate");

string userInput = Console.ReadLine().ToLower().Trim();

    //Split-- variable.Split to get each word from the user split into a word to send through the translator work in progress
    //string[] userInput = sentence.split


    //determine whether user is writing a word with a vowel or not and output different results based on the word input


    if (IsAVowel(userInput) == true)
{
    Console.WriteLine(TranslateVowel(userInput));
}
else
{
    Console.WriteLine(TranslateConsonant(userInput));
}

//method

//this method is to check if the word starts with a vowel or not using a bool
static bool IsAVowel(string userInput)
{
    char[] vowelArray = { 'a', 'e', 'i', 'o', 'u' };
    char firstLetter = (userInput[0]);

    if (Array.IndexOf(vowelArray, firstLetter)!=-1 )
    {
        return true;
    }
    else
    {
        return false;
    }
}

//this method is to convert the words that start with a vowel into piglatin
static string TranslateVowel(string userInput)
{

    string translation = userInput + "way";
    return translation;

}

//this method is to convert the words that start with a consonant into piglatin
static string TranslateConsonant(string userInput)
{
    char firstLetter = userInput[0];


//put the vowel array in here too so that I can compare the letters of the word against it


    char[] vowelArray = { 'a', 'e', 'i', 'o', 'u' };
    int findFirstVowel = -1;
    string ctranslation = string.Empty;
        for (int i = 0; i < userInput.Length; i++)
        {
            if (Array.IndexOf(vowelArray, char.ToLower(userInput[i])) != -1)
            {
                findFirstVowel = i;
                break;
            }

        }

// this is where the code decides which one I am returning based on where the vowel is


        if(findFirstVowel != -1)
        {
            string mainWord = userInput.Substring(findFirstVowel);
            string firstPart = userInput.Substring(0, findFirstVowel);
            ctranslation = mainWord + firstPart + "ay";
        }
//this is just in case there are no vowels at all in the word such as "crypt"

        else
        {
            ctranslation = userInput + "ay";
        }

 
    return ctranslation; 
}

// alright time to make sure we can get out of the loop

    while (true)
    {
        Console.WriteLine("Would you like to translate again? y/n");
        string choice = Console.ReadLine().ToLower().Trim() ;
        if(choice == "y")
        {
            break;
        }
        else if(choice == "n")
        {
            runTranslator = false ;
            break;
        }
        else
        {
            Console.WriteLine("that answer is invalid, please type y to continue or n to quit");
        }
    }
}



