using Agents_game;
using System.Collections.Generic;

public class Dict_sensor
{
    private Dictionary<Create_Sensor_basic, int> sensorsDict;
    public Dict_sensor(List<Create_Sensor_basic> weaknesses)
    {
        InitSensorDict(weaknesses);
    }
    public void InitSensorDict(List<Create_Sensor_basic> weaknesses)
    {
        sensorsDict = new Dictionary<Create_Sensor_basic, int>();
        foreach (var sensor in weaknesses)
        {
            if (sensorsDict.ContainsKey(sensor))
                sensorsDict[sensor]++;
            else
                    sensorsDict[sensor] = 1;
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
//    }
//}