using System;

class Program {
  public static void Main (string[] args) {
    Random rnd = new Random();
    string[] wordList={"flame", "tacos","swarm"};
    int choice = rnd.Next(0,wordList.Length);
    // pick the guess word 
    string word = wordList[choice];
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
        }else if (word.IndexOf(guess[x])>-1) { 
             Console.WriteLine("Y");
       }//else
       else{
          //print B
          Console.WriteLine("B");

       }
          
       }
       //if guess is equal to word
       if(guess==word){
       Console.WriteLine("You Win");
        break;
       }
    }while (guesses>0);

    
     }
}