//string content = "";

//try
//{
//    content = File.ReadAllText("doc.txt");
//    Console.WriteLine("The file has been read.");
//}
//catch (FileNotFoundException exception)
//{
//    Console.WriteLine($"ERROR: The file '{exception.FileName}' could not be found");
//} finally
//{
//    Console.WriteLine($"The content length is: {content.Length}");
//}

var filename = "doc.txt";

if (File.Exists(filename))
{
    var content = File.ReadAllText(filename);
    Console.WriteLine(content);
}
else
{
    Console.WriteLine($"ERROR: The file '{filename}' could not be found");
}