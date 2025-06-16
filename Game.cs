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
                Console.WriteLine("Enter the agent's name.");
                string name=Console.ReadLine();
                Create_agent_junior Create_agent_junior = new Create_agent_junior(name);
            }
        }
    }
}