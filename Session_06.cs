internal class Session_06
{
    private static void Main(string[] args)
    {
        /* int[] a; //declare
       a = new int[3]; //memory allocation*/

        /* int[] a = new int[3]; // khai bao va cap phat vung nho cho mot mang so nguyen 3 phan tu
        a[0] = 3; a[1] = 5; a[2] = 7; */

        //int[] a = new int[] { 3, 5, 7 };
        //int[] a = new int[3] { 3, 5, 7 }; //initialization - khoi gan
        int[] a = { 3, 5, 7 };

        //traverse
        /*for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }*/

        foreach (int item in a)
        {
            Console.WriteLine(item);
        }
    }
}