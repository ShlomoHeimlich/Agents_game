using System.Collections.Generic;

namespace Agents_game

{ 
  public  abstract class Sensor
    {
        public abstract string Type { get; }
        public abstract void Activate(Dictionary<string, int> sensorsDict,List<string> user_sensor);
        
  
    }
}
