﻿using Agents_game;
using System;
using System.Collections;
using System.Collections.Generic;
namespace Agents_game
{
    class agent_junior : Create_agent
    {
        public Sensor_basic Instance_Sensor_basic;
        private List<Sensor> sensorsObjectsList = new List<Sensor>();
        private  Dictionary<string, int> sensorsDict = new Dictionary<string, int>();    
        public override string Name { get; }
        public agent_junior(string name)
        {
            this.Name = name;
            list_sensor_weakness();
        }
        public void list_sensor_weakness()
        {
            this.Instance_Sensor_basic = new Sensor_basic("audio");
            //Sensor_basic Viewing = new Sensor_basic("Viewing");
            pulse_sensor pulse_sensor = new pulse_sensor("myuchad");
            List<Sensor> sensorsList = new List<Sensor> { Instance_Sensor_basic,  pulse_sensor };
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                
                Sensor randomSensor = sensorsList[rnd.Next(sensorsList.Count)];
                Weakness_Dictionary(randomSensor.Type);
                sensorsObjectsList.Add(randomSensor);
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
        public List<Sensor> GetsensorsObjectsLis()
        {
            return sensorsObjectsList;
        }
    }
}
