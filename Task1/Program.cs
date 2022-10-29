Console.Write("Enter array length: ");
int length = Int32.Parse(Console.ReadLine());
int cnt = 1;
int[] arr = new int[length];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Int32.Parse(Console.ReadLine());
}

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] != arr[i - 1])
    {
        cnt++;
    }
}
System.Console.WriteLine(cnt);
