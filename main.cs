using System;

class Program {
  public static void Main (string[] args) {
    // pick the guess word 
    string word = "flame";
    // Set number of guesses
    int guesses = 6;
    do{
    // Ask guess 
  
  Console.WriteLine("What is your guess");
  guesses--;
    // Read the guess you put in
    string guess = Console.ReadLine().ToLower();
    
    
       for (int x=0;x<guess.Length;x++) {
        if( guess[x]==word[x]) { 
           //if the current letter is in the right place, write R 
          Console.WriteLine("G");
        }if (word.indexOf(guess[x])>-1) { 
             Console.WriteLine("The letter is in the word, but in the wrong place");
       }
       }
    }while (guesses>0);

    
     }
}