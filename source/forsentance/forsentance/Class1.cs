using System;
using System.Timers;

namespace forsentance
{
	/// <summary>
	/// Class1�� ���� ��� �����Դϴ�.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// �ش� ���� ���α׷��� �� �������Դϴ�.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			int[] Data = new int[5] { 1,2,4,8,16};

			// C++���α׷��Ӱ� �Ϲ������� ���� ���� ����ϴ� ����
			/*int nCount = Data.Length;
			for ( int i = 0; i <= nCount; i++ ) 			
			{
                System.Console.WriteLine(Data[i]);
			}*/
						
			//int nCount = Data.Length;
			/*for ( int i = 0; i < Data.Length; i++ ) 			
			{
				System.Console.WriteLine(Data[i]);
			}*/

			foreach( int each in Data )
			{
                System.Console.WriteLine(each);
			}
		}
	}
}
