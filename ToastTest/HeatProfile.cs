using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToastTest
{
    class HeatProfile
    {
        List<Tuple<int, int>> durationsAndTemps = new List<Tuple<int, int>>();
        public int NumPhases { get { return durationsAndTemps.Count; } }

        public void AddPhase(int holdSeconds, int holdTemperature)
        {
            durationsAndTemps.Add(new Tuple<int, int>(holdSeconds, holdTemperature));
        }

        public void SaveToFile(String filepath)
        {
            String contents = "";
            foreach(var durationTemp in durationsAndTemps)
            {
                contents += durationTemp.Item2.ToString() + "," +
                    durationTemp.Item1.ToString() + Environment.NewLine;
            }
            System.IO.File.WriteAllText(filepath, contents);
        }
    }
}
