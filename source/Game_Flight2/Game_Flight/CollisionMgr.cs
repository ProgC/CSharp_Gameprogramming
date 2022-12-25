using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Game_Flight2
{
    class CollisionMgr
    {
        private ArrayList colList = new ArrayList();
        public CollisionMgr()
        {

        }

        // 전달된 오브젝트 리스트로 CollisionPair를 만든다.
        public void Build(ArrayList list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    AddPair((MoveableEntity)list[i], (MoveableEntity)list[j]);
                }
            }
        }

        private void AddPair(MoveableEntity s, MoveableEntity t)
        {
            CollisionPair pair = new CollisionPair();
            pair.source = s;
            pair.target = t;

            colList.Add(pair);            
        }
        
        public void ProcessCollision()
        {
            for (int i = 0; i < colList.Count; i++)
            {
                CollisionPair pair = ((CollisionPair)colList[i]);
                if (pair.Collide())
                {
                    pair.source.Hit();
                    pair.target.Hit();
                }
            }
        }
    }
}
