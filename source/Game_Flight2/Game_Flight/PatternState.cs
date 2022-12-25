using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Flight2
{
    abstract class PatternState
    {
        protected BulletStrategyMgr refBulletMgr;
        public abstract void ApplyBullet(MoveableEntity pEntity);
        public abstract void Begin();
        public abstract void Update();
        public abstract void End();
    }
}
