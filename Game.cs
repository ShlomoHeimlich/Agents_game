using System;
using System.Collections.Generic;
namespace Agents_game
{
    class game
    {
        string pulseSensorType;
        bool pulse_sensor = false;
        public game()
        {
            manu();
        }
        public void manu()
        {
            Console.WriteLine("Menu \n To start press 1 \n To end press 2");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("The game is starting, please enter the agent's name.");
                string name=Console.ReadLine();
                agent_junior Create_agent_junior = new agent_junior(name);
                foreach(var sensor in Create_agent_junior.GetsensorsObjectsLis())
                {
                    if (sensor is pulse_sensor)
                    {
                        //pulse_sensor = true;
                        pulseSensorType = sensor.Type;
                        break;
                    }
                }
                int Initial_guess_total = Create_agent_junior.SumSensorValues();
                int start = Initial_guess_total;
                do
                {
                    Initial_guess_total = Create_agent_junior.SumSensorValues();
                    Dictionary<string, int> dict_sensor_user = new Dictionary<string, int>();
                    List<string> list_sensor_user = new List<string>();
                    for (int i = 0; i < start; i++)
                    {
                        Console.Write($"Enter guess {i + 1}: ");
                        string user_guess = Console.ReadLine();
                        list_sensor_user.Add(user_guess);
                        if (dict_sensor_user.ContainsKey(user_guess))
                            dict_sensor_user[user_guess]++;
                        else
                            dict_sensor_user[user_guess] = 1;
                    }
                    for (int i = 0; i < list_sensor_user.Count; i++)
                    {
                        Create_agent_junior.audio.Activate(list_sensor_user[i], Create_agent_junior.GetSensorsDict());
                    }
                    Console.WriteLine($"{Create_agent_junior.audio.a}/{start}");
                    Initial_guess_total = Create_agent_junior.SumSensorValues();
                    if (pulseSensorType != null &&
                    dict_sensor_user.ContainsKey(pulseSensorType) &&
                    dict_sensor_user[pulseSensorType] >= 3)
                    {
                        Console.WriteLine(" ניחשת את הסנסור הבעייתי יותר מדי! מגבירים את החולשה שלו!");
                        Create_agent_junior.GetSensorsDict()[pulseSensorType]++;
                        dict_sensor_user[pulseSensorType] = 0;
                        Console.WriteLine("sima");
                    }
                } while (Initial_guess_total!=0);
                
            }
        }
    }
}