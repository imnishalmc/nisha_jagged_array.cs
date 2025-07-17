internal class jagged
{
    public static void Main()
    {
        int[][] nishalmc = new int[3][] ;
        nishalmc[0] = new int[3] { 11, 12, 34 };
        nishalmc[1] = new int[1] { 90 };
        nishalmc[2] = new int[2] { 35, 67 };
        for(int i =0;i<3;i++)
        {
            Console.WriteLine("jagged array");
            for(int j = 0; j < nishalmc[i].Length;j++)
            {
                Console.WriteLine(nishalmc[i][j] + "");
            }
       
        }
    }
}