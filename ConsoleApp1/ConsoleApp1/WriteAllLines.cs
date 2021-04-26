using System.IO;
using System.Threading.Tasks;

class WriteAllLines
{
    public static async Task WriteLines(string lineOne,string lineTwo, string lineThree, string fileName)
    {
        string[] lines =
        {
            lineOne, lineTwo, lineThree 
        };

        await File.WriteAllLinesAsync(fileName, lines);
    }
}