using System;

public class Program
{
  public static void Main()
  {
    ExecuteQuery("Jay");
    Console.WriteLine("Hello world, this is Jay");
  }
  public static void ExecuteQuery(string userInput)    
  {         
    string query = "SELECT * FROM Users WHERE Username = '" + userInput + "'";         // Execute the query    
  }
  public static string DisplayMessage(string message)    
  {         
    return "<div>" + message + "</div>";     
  }
}
