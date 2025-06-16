using Agents_game;
using System;
using System.Collections.Generic;
namespace Agents_game { 
 public class Create_Sensor_basic : Sensor
{
    public override string Type { get; }

    public Create_Sensor_basic(string type)
    {
        this.Type = type;
    }
    public override void Activate(Dictionary<string, int> sensorsDict,List<string> user_sensor)
    {

    }
}
    }