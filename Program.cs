using System.Text.RegularExpressions;

namespace baelle;

public class Baelle {
    public static void Main(string[] args){
        string path = args[0];
        if (!(path.EndsWith(".baelle"))){
            Console.WriteLine("Invalid File Type!!!!!!! Bälle hehehe");
        } else {
            string[] lines = File.ReadAllLines(path);
            string string_pattern = "\"([^\"]*)\"";
            foreach (var line in lines){
                if (line.StartsWith("ball")){
                    string content = "";
                    MatchCollection matches = Regex.Matches(line, string_pattern);
                    foreach(Match match in matches){
                        string captured = match.Groups[1].Value;
                        content += captured;
                    }
                    Console.WriteLine(content);
                }
            }
        }
        
    }
}