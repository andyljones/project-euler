using System;
class Problem28
{
    public static int SpiralDiagonalSum(int width)
    {
        if (width % 2 == 0 || width <= 0)
        {
            throw new ArgumentOutOfRangeException("Invalid spiral width provided");
        }

        int numberOfLayers = width / 2;
        int sum = 0;
        for (int i = 1; i <= numberOfLayers; i++)
        {
            int y = (2*i+1)*(2*i+1);
            for (int j = 0; j < 4; j++)
            {
                sum = sum + y;
                y = y - 2*i;
            }
        }

        return sum + 1;
    }
}
