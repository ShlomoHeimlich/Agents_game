using Agents_game;
using System;
using System.Collections;
using System.Collections.Generic;
namespace Agents_game
{
    class Create_agent_junior : Create_agent
    {

        public override string Name { get; }
        private List<Create_Sensor_basic> Weaknesses;
        public Create_agent_junior(string name)
        {
            this.Name = name;
            Weaknesses = new List<Create_Sensor_basic>();
            list_sensor();
        }
        public void list_sensor()
        {
            Create_Sensor_basic audio = new Create_Sensor_basic("audio");
            Create_Sensor_basic Viewing = new Create_Sensor_basic("Viewing"));
            List<Create_Sensor_basic> sensorsList = new List<Create_Sensor_basic> { audio, Viewing };

            Random rnd = new Random();

            for (int i = 0; i < 2; i++)
            {
                Create_Sensor_basic randomSensor = sensorsList[rnd.Next(sensorsList.Count)];
                Weaknesses.Add(randomSensor);
            }
            Dict_sensor Dict_sensor = new Dict_sensor(Weaknesses);


        }

    }
}