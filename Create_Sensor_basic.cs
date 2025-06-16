using Agents_game;
using System;
using System.Collections;
using System.Collections.Generic;
namespace Agents_game
{
    public class Create_Sensor_basic : Sensor
    {
        public override string Type { get; }
        private static Dictionary<string, int> sensorsDict = new Dictionary<string, int>();
        public Create_Sensor_basic(string type)
        {
            this.Type = type;
        }
        public override void Activate(string sensor)
        {
            if (sensorsDict.ContainsKey(sensor))
                sensorsDict[sensor]++;
            else
                sensorsDict[sensor] = 1;
        }
        public static void PrintSensorsDict()
        {
            foreach (var entry in sensorsDict)
            {
                Console.WriteLine($"Sensor: {entry.Key}, Count: {entry.Value}");
            }
        }
    }

}
    