using Agents_game;
using System;
using System.Collections;
using System.Collections.Generic;
namespace Agents_game
{
    class agent_junior : Create_agent
    {
        public Sensor_basic audio;
        private  Dictionary<string, int> sensorsDict = new Dictionary<string, int>();    
        public override string Name { get; }
        public agent_junior(string name)
        {
            this.Name = name;
            list_sensor_weakness();
        }
        public void list_sensor_weakness()
        {
            this.audio = new Sensor_basic("audio");
            Sensor_basic Viewing = new Sensor_basic("Viewing");
            List<Sensor_basic> sensorsList = new List<Sensor_basic> {audio,Viewing};
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                Sensor_basic randomSensor = sensorsList[rnd.Next(sensorsList.Count)];
                Weakness_Dictionary(randomSensor.Type);
            }
        }
        public void Weakness_Dictionary(string sensor)
        {
            if (sensorsDict.ContainsKey(sensor))
                sensorsDict[sensor]++;
            else
                sensorsDict[sensor] = 1;
        }
        public int SumSensorValues()
        {
            int sum = 0;
            foreach (var val in sensorsDict.Values)
            {
                sum += val;
            }
            return sum;
        }
        public Dictionary<string, int> GetSensorsDict()
        {
            return sensorsDict;
        }
    }
}
