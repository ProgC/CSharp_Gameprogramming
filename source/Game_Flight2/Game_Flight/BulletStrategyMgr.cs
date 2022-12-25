using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Flight2
{
    class BulletStrategyMgr
    {
        private PatternState CurrentState = null;
        private FlightWorld refWorld = null;

        #region BulletStrategyMgrProperty
        public FlightWorld World
        {
            get
            {
                return refWorld;
            }
        }
        #endregion

        public BulletStrategyMgr(FlightWorld world)
        {
            refWorld = world;
            //ChangeState(new BasicPattern(this));
            // 이제 아래의 코드는 사용하지 않을 것입니다.
            ChangeState(new CirclePattern(this));
        }
        public void ChangeState(PatternState pState)
        {
            if (CurrentState != null)
            {
                CurrentState.End();
            }
            CurrentState = null;
            
            CurrentState = pState;
            CurrentState.Begin();
        }
        public void ApplyBullet(MoveableEntity pEntity)
        {
            if (CurrentState != null)
            {
                CurrentState.ApplyBullet(pEntity);
            }
        }
        public void Update()
        {
            if (CurrentState != null) CurrentState.Update();
        }        
    }
}
