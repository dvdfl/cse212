public class DuplicateFinder
{

    // ------------------------------------------------------------------------
    // Find the first duplicated character in the word
    // - Posible scenario
    //      Words: "technical", "interviewer", "someone", "Instructions", "function", "love"
    // - Data structures
    //      Set (HashSet): To store individuallly charaters of the word without duplication.
    //      Array: to store the list of the possuble scenario words.
    // - Boundary conditions
    //      Words without duplicated characters or une character: "abcde", "a1b2", "I"
    // - Approach
    //      The function will loop through each character in the word and store them in a set 
    //      before storing the character it will check if it already exists, if so, the function will return
    //      the character as the first duplicate, otherwise the character will be stored in the Set 
    //      and the loop will continue.
    //      If not duplicate found a question mark (?) char will be returned

    public static void Run()
    {
        var words = new string[]{ "technical", "interviewer", "someone", "Instructions", "function", "love"};
        foreach(var word in words){
            Console.WriteLine($"First duplicate letter in '{word}' is '{DuplicateFinder.FindFirstDuplicate(word)}'");
        }
    }

    private static char FindFirstDuplicate(string word)
    {
        // define set for word characters
        var chars = new HashSet<char>();

        // loop thorugh every character in the word to find firs dupplicate
        foreach(char letter in word){
            if(chars.Contains(letter))
                return letter;
            else
                chars.Add(letter);
        }
        return '?';
    }
}