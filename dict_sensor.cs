using Agents_game;
using System.Collections.Generic;

public class Dict_sensor
{
    public Dictionary<string, int> sensorsDict;
    public Dict_sensor(List<Create_Sensor_basic> weaknesses)
    {
        InitSensorDict(weaknesses);
    }
    public void InitSensorDict(List<Create_Sensor_basic> weaknesses)
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

}









//        //public void PrintSensors()
//        //{
//        //    foreach (var pair in sensorsDict)
//        //    {

//        //        Console.WriteLine($"Sensor: {pair.Key.Type}, Quantity: {pair.Value}");
//        //    }
//        //}
//}