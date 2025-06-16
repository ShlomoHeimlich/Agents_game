using Agents_game;
namespace Agents_game
{
    public class Create_Sensor_basic : Sensor
    {
        public override string Type { get; }

        public Create_Sensor_basic(string type)
        {
            this.Type = type;
        }
        public override void Activate()
        {

        }
    }
}