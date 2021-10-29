using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
			if (ax == bx && ay == by) 
				return Math.Sqrt((y - by) * (y - by) + (x - bx) * (x - bx));
			
			else if (((x - ax) * (bx - ax) + (y - ay) * (by - ay) < 0 || (x - bx) * (ax - bx) + (y - by) * (ay - by) < 0))
				return Math.Min(Math.Sqrt((y - by) * (y - by) + (x - bx) * (x - bx)), Math.Sqrt((y - ay) * (y - ay) + (x - ax) * (x - ax)));
			
			else
				return (Math.Abs((by-ay) * x - (bx - ax) * y + bx*ay - by * ax) / Math.Sqrt((by-ay)*(by-ay) + (bx -ax)*(bx -ax)));
		}
	}
}