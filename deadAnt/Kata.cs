using System;
using System.Linq;

namespace deadAnt
{
	public class Kata
	{
		public static int DeadAntCount(string ants)
		{
			if (ants == null)
				return 0;
			var deadant = ants.ToLower().Replace("ant", string.Empty);

			return Math.Max(Math.Max(deadant.Count(x => x == 'a'), deadant.Count(x => x == 'n')), deadant.Count(x => x == 't'));
		}
	}
}