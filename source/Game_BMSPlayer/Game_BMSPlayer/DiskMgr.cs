using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace Game_BMSPlayer
{
    class DiskMgr
    {
        private ArrayList DiskList = new ArrayList();
        public DiskMgr()
        {
            // 디렉토리를 검사해서 디스크를 추가한다.
            string CurrentDir = Directory.GetCurrentDirectory();
            DirectoryInfo dir = new DirectoryInfo(CurrentDir);
            DirectoryInfo[] directories = dir.GetDirectories();
            
            foreach( DirectoryInfo newDir in directories )
            {
                AddDisk(newDir);
            }
        }

        public void AddDisk( DirectoryInfo dir )
        {
            FileInfo[] files = dir.GetFiles();            
            foreach (FileInfo file in files)
            {
                // bms파일 확장자를 가진 디스크만 추가한다.
                if (file.Extension.ToLower().Equals(".bms"))
                {
                    DiskData Disk = new DiskData();
                    Disk.PathName = dir.FullName;
                    Disk.ReadDisk(file.FullName);
                    DiskList.Add(Disk);
                }
            }            
        }

        public int GetDiskCount()
        {
            return DiskList.Count;
        }

        public string GetFullName(int nindex)
        {
            return ((DiskData)DiskList[nindex]).FileFullName;
        }
        public string GetPathOfDisk(int nindex)
        {
            return ((DiskData)DiskList[nindex]).PathName;
        }

        public string[] GetDiskList()
        {
            string[] DiskTitle = new string[GetDiskCount()];
            for (int i = 0; i < DiskTitle.Length; i++)
            {
                DiskTitle[i] = ((DiskData)DiskList[i]).FileFullName;
            }
            return DiskTitle;
        }
    }
}
