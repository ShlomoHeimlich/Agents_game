using Agents_game;
using System;
using System.Collections.Generic;
namespace Agents_game {
    public class Create_Sensor_basic : Sensor
    {
        public Dictionary<string, int> sensorsDict;
        public override string Type { get; }

        public Create_Sensor_basic(string type)
        {
            this.Type = type;
        }
        public override void Activate(List<Create_Sensor_basic> weaknesses)
        {
            sensorsDict = new Dictionary<string, int>();
            foreach (var sensor in weaknesses)
            {
                string key = sensor.Type;

                if (sensorsDict.ContainsKey(key))
                    sensorsDict[key]++;
                else
                    sensorsDict[key] = 1;
            }

        }
    
    public void PrintDict()
        {
            foreach (var pair in sensorsDict)
            {
                Console.WriteLine($"Sensor: {pair.Key}, Quantity: {pair.Value}");
            }
        }
    }
}
    