int n = Convert.ToInt32(System.Console.ReadLine());
int p = 1, sum = 1;
for (int i = 1; i <= n; i++)
{
    p*=2;
    sum = sum + p;
} 
System.Console.WriteLine(sum);