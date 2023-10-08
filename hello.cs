using System;

public class Program
{
  private static string apiKey = "myApiKeyValue";
  public static void Main()
  {
    ExecuteQuery("Jay");
    Console.WriteLine("Hello world, this is Jay");
    System.String username = "testuser";
    System.String password = "testpass";
    CallApi(username, apiKey);
  }
  public static void ExecuteQuery(string userInput)    
  {         
    string query = "SELECT * FROM Users WHERE Username = '" + userInput + "'";         // Execute the query    
  }
  public static string DisplayMessage(string message)    
  {         
    return "<div>" + message + "</div>";     
  }
  public static void CallApi(string username, string key)
    {
        Console.WriteLine($"Calling API for user {username} with key {key}");
    }
}

public class ExampleController : Controller
{
    private static string TargetDirectory = "/path/to/target/directory/";

    public void Example(string filename)
    {
        string path = Path.Combine(TargetDirectory, filename);
        System.IO.File.Delete(path);
    }
}
