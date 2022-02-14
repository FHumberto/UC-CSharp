namespace S06_E03
{
    internal static class Index
    {
        public static void Main()
        {
            string[] l = Console.ReadLine().Split(' ');
            int m = int.Parse(l[0]);
            int n = int.Parse(l[1]);
            int[,] mat = new int[m,n];
            for(int i = 0; i < m; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(v[j]);
                }
            }
            int z = int.Parse(Console.ReadLine());
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(mat[i,j] == z)
                    {
                        Console.WriteLine("Position " + i + "," + j);
                        if(j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i,j - 1]);
                        }
                        if(i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1,j]);
                        }
                        if(j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i,j + 1]);
                        }
                        if(i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1,j]);
                        }
                    }
                }
            }
        }
    }
}
