using System.Runtime.InteropServices;

namespace City_With_the_Smallest_Number_of_Neighbors_at_a_Threshold_Distance
{
	public class Solution
	{
		public int FindCity(int n, int m, List<List<int>> edges, int distanceThreshold)
		{
			int[][] adj = new int[n][];
			for (int i = 0; i < n; ++i)
			{
				adj[i] = new int[n];
				Array.Fill(adj[i], int.MaxValue);
			}
			for (int i = 0; i < m; ++i)
			{
				int source = edges[i][0];
				int destination = edges[i][1];
				int weight = edges[i][2];
				adj[source][destination] = weight;
				adj[destination][source] = weight;
			}
			for (int i = 0; i < n; ++i)
			{
				adj[i][i] = 0;
			}
			for (int k = 0; k < n; ++k)
			{
				for (int i = 0; i < n; ++i)
				{
					for (int j = 0; j < n; ++j)
					{
						if (adj[i][k] == int.MaxValue || adj[k][j] == int.MaxValue)
						{
							continue;
						}
						adj[i][j] = Math.Min(adj[i][j], adj[i][k] + adj[k][j]);
					}
				}
			}
			int minCity = n + 1;
			int city = -1;
			for (int i = 0; i < n; ++i)
			{
				int curCountCity = 0;
				for (int j = 0; j < n; ++j)
				{
					if (adj[i][j] <= distanceThreshold)
					{
						++curCountCity;
					}
				}
				if (curCountCity <= minCity)
				{
					minCity = curCountCity;
					city = i;
				}
			}
			return city;
		}
	}
}
