using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticAlarmClock.Model
{
	public class ArithmeticQuestion
	{
		private static char[] Operators = new char[4]{
			'＋',
			'－',
			'×',
			'÷'
		};
		private static Func<int, int, int>[] Expressions = new Func<int, int, int>[4]
		{
			(l,r) => l + r,
			(l,r) => l - r,
			(l,r) => l * r,
			(l,r) => l / r
		};
		private int Left;
		private int Right;
		private int Index;
		private Random Random = new Random(DateTime.Now.Second);

		public ArithmeticQuestion()
		{
			Left = (int)(Random.NextDouble() * 99);
			Right = (int)(Random.NextDouble() * 99);
			Index = (int)(Random.NextDouble() * 3);
		}

		public bool Confirm(int answer)
		{
			return answer == Expressions[Index].Invoke(Left, Right);
		}

		public override string ToString() => $"{Left} {Operators[Index]} {Right} = ";
	}
}
