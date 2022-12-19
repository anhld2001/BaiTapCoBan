// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nhap vao so nguyen: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    bool snt = true;
    if(i <2)
    {
        snt = false;
    }    
    
    for (int a = 2; a <= i/2; a++)
    {
        if (i % a == 0)
        {
            snt= false;
            break;
        }
    }
    if (snt == true)
    {
        Console.WriteLine("So nguyen to thuoc khoang 0 den " + n + " la: " + i);
    }
}
Console.ReadKey();
