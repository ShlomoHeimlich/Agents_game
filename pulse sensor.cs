using Agents_game;
using System.Collections.Generic;

class pulse_sensor : Sensor_basic
{
    public pulse_sensor(string type) : base(type)
    {
    }
    public override void Activate(string sensor, Dictionary<string, int> sensorsDict)
    {
        base.Activate(sensor, sensorsDict);
    }
}