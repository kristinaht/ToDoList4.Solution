using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int Id { get; }
    private static List<Item> _instances = new List<Item> {};

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}

// using System;
// using WordCounter.Models;

// using System.Collections.Generic;

// namespace WordCounter
// {
//   public class Program
//   {
//     public static void Main()
//     {
//       Console.WriteLine("enter word");
//       string word = Console.ReadLine();
//       Console.WriteLine("enter sentence");
//       string sentence = Console.ReadLine();
//       Game newGame = new Game(word, sentence);
//       Console.WriteLine(newGame.Sentence);
//       string[] array = newGame.SplitString(sentence);
//       Console.WriteLine(array[2]);
//       Console.WriteLine(newGame.WordCount(array));

      
//     }
//   }
//   }