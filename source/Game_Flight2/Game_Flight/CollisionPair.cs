using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Flight2
{
    class CollisionPair
    {
        public MoveableEntity source = null;
        public MoveableEntity target = null;
        
        public bool Collide()
        {
            return source.Collide(target);
        }
    }
}
