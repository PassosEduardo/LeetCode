public static class FindThePrefixCommonArray
{
    public static int[] FindThePrefixCommonArrayMethod(int[] array1, int[] array2)
    {
        int[] commonPrefix = { };

        for (int i = 0; i < array1.Length; i++)
        {

            int[] subArray1 = array1.Take(i + 1).ToArray();
            int[] subArray2 = array2.Take(i + 1).ToArray();

            int appededItem = 0;

            for (int iterator = 0; iterator < subArray1.Length; iterator++)
            {
                var item = subArray1[iterator];

                if (subArray2.Any(x => x == item))
                {
                    appededItem++;
                }
            }
            commonPrefix = commonPrefix.Append(appededItem).ToArray();
            appededItem = 0;
        }


        return commonPrefix;
    }
}