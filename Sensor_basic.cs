using Agents_game;
using System;
using System.Collections;
using System.Collections.Generic;
namespace Agents_game
{
    public  class Sensor_basic : Sensor
    {
        public int Number_of_successful_guesses { get;protected set; } = 0;
        public override string Type { get; }
        public Sensor_basic(string type)
        {
            this.Type = type;
        }
        public override void Activate(string sensor, Dictionary<string, int> sensorsDict)
        {
            if (sensorsDict.ContainsKey(sensor) && sensorsDict[sensor] > 0)
            {
                sensorsDict[sensor]--;
                this.Number_of_successful_guesses++;
            }

        }
        public void sub_Number_of_successful_guesses()
        {
            this.Number_of_successful_guesses--;
        }

    }

}