using System;
namespace Agents_game
{
    class game
    {
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
                int Initial_guess_total = Create_agent_junior.SumSensorValues();
                int start = Initial_guess_total;
                do
                {
                    Initial_guess_total = Create_agent_junior.SumSensorValues();
                    string[] sensor_user = new string[Initial_guess_total];
                    for (int i = 0; i < Initial_guess_total; i++)
                    {
                        Console.Write($"Enter guess {i + 1}: ");
                        sensor_user[i] = Console.ReadLine();
                    }
                    for (int i = 0; i < sensor_user.Length; i++)
                    {
                        Create_agent_junior.audio.Activate(sensor_user[i], Create_agent_junior.GetSensorsDict());
                    }
                    Console.WriteLine($"{Create_agent_junior.audio.a}/{start}");
                    Initial_guess_total = Create_agent_junior.SumSensorValues();
                    Console.WriteLine("shlomo");
                } while (Initial_guess_total!=0);
            }
        }
    }
}