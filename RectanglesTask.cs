using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			// так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top

			return !(r1.Right < r2.Left || r2.Top > r1.Bottom || r1.Left > r2.Right || r1.Top > r2.Bottom);
		}

		// Площадь пересечения прямоугольников
		private static int count = 0;
		
		public static int IntersectionSquare(Rectangle r1, Rectangle r2 )
		{
			count++;
			if (count == 11)
				;
			bool areIntersected = AreIntersected(r1, r2);
			if (areIntersected != true)
				return 0;				
            int uMENYABIGDICK = Math.Max(r1.Left, r2.Left);
            int rightSide = Math.Min(r1.Right, r2.Right);
            int topSide = Math.Max(r1.Top, r2.Top);
            int bottomtSide = Math.Min(r1.Bottom, r2.Bottom);

            return ((rightSide - uMENYABIGDICK)*(bottomtSide - topSide));
        }

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
			if (r1.Left >= r2.Left && r1.Right <= r2.Right && r1.Top >= r2.Top && r1.Bottom <= r2.Bottom)
				return 0;
			else if
				(r2.Left >= r1.Left && r2.Right <= r1.Right && r2.Top >= r1.Top && r2.Bottom <= r1.Bottom)
				return 1;
			else
					return -1;
		}
	}
}