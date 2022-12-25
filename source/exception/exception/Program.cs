using System;
using System.Collections.Generic;
using System.Text;

namespace exception
{
    class Program
    {
        class UserCustomException : Exception        
        {
            public UserCustomException(string message)
            {
                msg = message;
            }
            public string msg;
        }
        class ImageException : Exception
        {
            public ImageException(string message, int imageIndex)
            {
                msg = message;
                imageindex = imageIndex;
            }
            public string msg;
            public int imageindex;
        }

        class ResourceManager
        {
            public void Open()
            {

            }
            public void Close()
            {

            }            
        }
        class Engine
        {
            public Engine()
            {

            }
            public bool LoadResource()
            {                
                return true;
            }
            public bool InputInit()
            {
                return true;
            }
            public bool LoadSounds()
            {
                return true;
            }
            public bool LoadGraphics()
            {                
                ResourceManager ResourceMgr = new ResourceManager();
                try
                {
                    ResourceMgr.Open();
                    throw new ImageException("그래픽 데이터 오류", 34);
                }
                finally
                {
                    ResourceMgr.Close();
                }
                return true;
            }
            public bool LoadGameData()
            {

                //throw new UserCustomException("게임 데이터 읽기 오류");
                return true;
            }
            public void Update()
            {

            }
            public void Render()
            {

            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Engine start...");

            Engine engine = new Engine();

            try
            {
                engine.LoadResource();
                engine.LoadGameData();
                engine.LoadGraphics();
                engine.LoadSounds();
                engine.Update();
                engine.Render();
            }            
            catch (UserCustomException e)
            {
                System.Console.WriteLine(e.msg);
            }
            catch (ImageException e)
            {
                System.Console.WriteLine("에러 메세지 : " + e.msg + ": 인덱스 : " + e.imageindex);
            }
            System.Console.WriteLine("Engine end...");
        }
    }
}
