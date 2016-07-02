using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ToastTest
{
    class HeatProfile
    {
        List<Tuple<int, int>> durationsAndTemps = new List<Tuple<int, int>>();
        public int NumPhases { get { return durationsAndTemps.Count; } }
        public List<Tuple<int, int>> GetDurationsAndTemps() { return durationsAndTemps; }

        public void AddPhase(int holdSeconds, int holdTemperature)
        {
            durationsAndTemps.Add(new Tuple<int, int>(holdSeconds, holdTemperature));
        }

        public void SaveToFile(String filepath)
        {
            String contents = "";
            foreach(var durationTemp in durationsAndTemps)
            {
                contents += durationTemp.Item1.ToString() + "," +
                    durationTemp.Item2.ToString() + Environment.NewLine;
            }
            System.IO.File.WriteAllText(filepath, contents);
        }

        public static HeatProfile LoadFromFile(String filename)
        {
            HeatProfile profile = new HeatProfile();
            foreach(string line in System.IO.File.ReadAllLines(filename))
            {
                foreach(Match match in Regex.Matches(line, @"^(\d+),(\d+)$"))
                {
                    int duration = Int32.Parse(match.Groups[1].Value);
                    int temperature = Int32.Parse(match.Groups[2].Value);

                    profile.AddPhase(duration, temperature);
                }
            }
            return profile;
        }
    }
}
