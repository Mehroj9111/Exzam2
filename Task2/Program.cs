internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());
        int cnt = 1;
        int[] arr = new int[length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[i - 1])
            {
                cnt++;
            }
        }
        Console.WriteLine(cnt);
        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length - 1; i += 2)
        {
            Console.Write($"{arr[i + 1]} {arr[i]} ");
        }
    }
}