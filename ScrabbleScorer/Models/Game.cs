using System;

namespace ScrabbleScorer.Models
{
  public class ScrabbleScore
  {
    // private string _currentWord = ""; // the next line will do this automatically

    public string CurrentWord{get; set;}
    public int score { get; set;}

    public static int WordScore(string word) {
      int score = 0;
      foreach(char myChar in word) 
      {
        score += LetterScore(myChar
        );
      }
      return score;
    }// passes test for identifying letters with in word and adding score


    public static int LetterScore(char letter)//recognizes score per letter. doing this before writing code to run through switch loop every instance a letter appears in word
    {    //switch takes in letter and jumps to case point where letter occurs. return breaks switch loop and stops it from running from case to case -- needs to have default option (last line -1)
      switch(Char.ToUpper(letter)) 
      {
      case 'A': case 'E': case 'I': case 'O': case 'U': case 'L': case 'N': case 'R': case 'S': case 'T':
        return 1;
      case 'D': case 'G':
        return 2;
      case 'B': case 'C': case 'M': case 'P':
        return 3;
      case 'F': case 'H': case 'V': case 'W': case 'Y':
        return 4;
      case 'K':
        return 5;
      case 'J': case 'X':
        return 8;
      case 'Q': case 'Z':
        return 10;
      default:
        return 0;
      }
    }
  }
}
