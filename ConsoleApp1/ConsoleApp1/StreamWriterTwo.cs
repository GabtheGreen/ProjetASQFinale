using System.IO;
using System.Threading.Tasks;

class StreamWriterTwo
{
    public static async Task AppendLine(string addedLine, string fileName)
    {
        using StreamWriter file = new StreamWriter(fileName, append: true);
        await file.WriteLineAsync(addedLine);
    }
}