using System.Collections.Generic;

namespace Agents_game

{ 
  public  abstract class Sensor
    {
        public abstract string Type {get;}
        public abstract void Activate(List<Create_Sensor_basic> weaknesses);
        



    }
}
