namespace LeetCodeTop150;

/// <summary>
/// 605. Can Place Flowers
/// </summary>
/// <remarks>
/// You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.
/// Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.
/// </remarks>
public static class Exercise605
{
    public static bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        var prevEmpty = true;
        var canBePlantedPlaces = 0;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            var nextEmpty = i == flowerbed.Length - 1 || flowerbed[i + 1] == 0;
            
            if (flowerbed[i] == 0)
            {
                if (prevEmpty && nextEmpty)
                {
                    canBePlantedPlaces++;
                    prevEmpty = false;
                }
                else
                {
                    prevEmpty = true;
                }
            }
            else
            {
                prevEmpty = false;
            }

            if (canBePlantedPlaces == n)
            {
                return true;
            }
        }

        return canBePlantedPlaces >= n;
    }
}