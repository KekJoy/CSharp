using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Digger
{
    public class Terrain : ICreature
    {
        public string GetImageFileName()
        {
            return "Terrain.png";
        }
 
        public bool DeadInConflict(ICreature conflictObject)
        {
            return true;
        }
 
        public int GetDrawingPriority()
        {
            return 0;
        }
 
        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand { DeltaX = 0, DeltaY = 0 };
        }
    }

    public class Sack : ICreature
    {
        public string GetImageFileName()
        {
            return "Sack.png";
        }

        public bool DeadInConflict(ICreature conflictObject)
        {
            return false;
        }

        public int GetDrawingPriority()
        {
            return 2;
        }

        public CreatureCommand Act(int x, int y)
        {
            int endOfMap = Game.MapHeight - 1;
            if (Game.Map[x, y + 1] == null && y != endOfMap) 
                return new CreatureCommand { DeltaX = 0, DeltaY = 1 };
            return new CreatureCommand {DeltaX = 0, DeltaY = 0 };
        }
    }

    public class Gold : ICreature
    {
        public string GetImageFileName()
        {
            return "Gold.png";
        }

        public bool DeadInConflict(ICreature conflictObject)
        {
            return true;
        }

        public int GetDrawingPriority()
        {
            return 3;
        }

        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand { DeltaX = 0, DeltaY = 0 };
        }
    }

    public class Player : ICreature
    {
        public string GetImageFileName()
        {
            return "Digger.png";
        }
 
        public bool DeadInConflict(ICreature conflictObject)
        {
            if (conflictObject.GetImageFileName() == "Terrain.png")
                Game.Scores += 1;
            return false;
        }
 
        public int GetDrawingPriority()
        {
            return 1;
        }
 
        public CreatureCommand Act(int x, int y)
        {
            if (Game.KeyPressed == System.Windows.Forms.Keys.Up && y >= 1)
                return new CreatureCommand { DeltaX = 0, DeltaY = -1 };
 
            if (Game.KeyPressed == System.Windows.Forms.Keys.Down && y < Game.MapHeight - 1)
                return new CreatureCommand { DeltaX = 0, DeltaY = 1 };
 
            if (Game.KeyPressed == System.Windows.Forms.Keys.Left && x >=1 )
                return new CreatureCommand { DeltaX = -1, DeltaY = 0 };
 
            if (Game.KeyPressed == System.Windows.Forms.Keys.Right && x < Game.MapWidth - 1)
                return new CreatureCommand { DeltaX = 1, DeltaY = 0 };
 
            return new CreatureCommand { DeltaX = 0, DeltaY = 0 };
        }
    }
}