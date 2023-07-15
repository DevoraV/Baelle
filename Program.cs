using System.Text.RegularExpressions;

namespace baelle;

public class Baelle {
    public static void Main(string[] args){
        string path = args[0];
        IDictionary<string, string> constString = new Dictionary<string, string>();
        if (!(path.EndsWith(".baelle"))){
            Console.WriteLine("Invalid File Type!!!!!!! Bälle hehehe");
        } else {
            string[] lines = File.ReadAllLines(path);
            string string_pattern = "\"([^\"]*)\"";
            foreach (var line in lines){

                // Print Command
                if (line.StartsWith("ball")){
                    string content = "";
                    MatchCollection matches = Regex.Matches(line, string_pattern);
                    foreach(Match match in matches){
                        string captured = match.Groups[1].Value;
                        content += captured;
                    }

                    Console.WriteLine(content);
                }
                // Konstante Variablen
                else if (line.StartsWith("aufgeblasen")){
                    string[] zeile = line.Split(" ");
                    if (zeile[1] == "tennis"){
                        Console.WriteLine(zeile[2] + " = " + zeile[3]);
                    }

                }
                // Variablen
                else if (line.StartsWith("platt")){
                    string[] zeile = line.Split(" ");
                    if (zeile[1] == "tennis"){

                    }
                }

            }
        }
        
    }
}