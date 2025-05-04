namespace ClassLibraries.Lib
{
    public class MessageProvider
    {
        public static void WriteMessage(string? message)
        {
            if (string.IsNullOrEmpty(message))
            {
                Console.WriteLine("No message provided.");
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
