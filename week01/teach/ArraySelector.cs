public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var finalList = new int[select.Length];
        int lastList1 = 0, lastList2 = 0;
        for (int i = 0; i < select.Length; i++)
        {
            // Console.Write($"\n[{i}]: {select[i]}");
            if(select[i] == 1) {
                if (list1.Length > lastList1)
                {
                    // Console.Write(" list 1: " +list1[lastList1]);
                    finalList[i] = list1[lastList1];
                    lastList1++;
                }
            }
            else {
                if (list2.Length > lastList2)
                {
                    // Console.Write(" list 2: " +list2[lastList2]);
                    finalList[i] = list2[lastList2];
                    lastList2++;
                }
            }
        }
        return finalList;
        //return new int[0];
    }
}