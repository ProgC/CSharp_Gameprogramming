using System;
using System.Timers;

namespace forsentance
{
	/// <summary>
	/// Class1에 대한 요약 설명입니다.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			int[] Data = new int[5] { 1,2,4,8,16};

			// C++프로그래머가 일반적으로 가장 많이 사용하는 형태
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
