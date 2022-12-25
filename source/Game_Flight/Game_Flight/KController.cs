using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

// 2007.5.17
// Keyboard와 Mouse의 입력 상태를 관리한다.
namespace KModule
{
    class KController
    {
        private static KController oInstance = null;

        // 키보드에 관련된 변수들
        private int nCountOfKey;
        private bool[] KeyState;
        private int[] KeyStateLife;
                
        private KController()
        {
            nCountOfKey = 256;            
            KeyState = new bool[nCountOfKey];
            KeyStateLife = new int[nCountOfKey];
        }
        
        public static KController Instance()
        {
            if (oInstance == null)
            {
                oInstance = new KController();
            }
            return oInstance;
        }

        public void Update()
        {
            for (int i = 0; i < nCountOfKey; i++)
            {
                if (KeyState[i] == true)
                {
                    KeyStateLife[i] += 1;

                    if (KeyStateLife[i] >= 100)
                    {
                        KeyStateLife[i] = 90;
                    }
                }
            }
        }

        public int CountOfKey()
        {
            return nCountOfKey;
        }

        // Input Processing
        public void OnKeyDown(int KeyValue)
        {
            if (!KeyState[KeyValue])
            {
                KeyState[KeyValue] = true;
                KeyStateLife[KeyValue] = 0;
            }
            else
            {
                KeyState[KeyValue] = true;
            }
        }

        public void OnKeyUp(int KeyValue)
        {
            KeyState[KeyValue] = false;
            KeyStateLife[KeyValue] = 0;
        }

        // State of controller
        // 현재의 키 상태를 반환합니다.
        public bool GetKeyState(int KeyValue)
        {
            return KeyState[KeyValue];            
        }

        // 한번만 눌렀을 때 동작
        public bool GetKeyStateSingle(int KeyValue)
        {
            if (KeyStateLife[KeyValue] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
