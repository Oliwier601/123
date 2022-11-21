Console.WriteLine("Podaj kod 3 cyfrowy");
int a = int.Parse(Console.ReadLine());
int b;
int[]c=new int[3];
int i = 0;
int x;
int y;
while(a > 0)
{
    b = a % 10;
    a/=10;
    c[i] = b;
    i++;
}
x = c[0] - c[1];
y = c[1] - c[2];
if ((x>=2 || x<=-2) && (y>=2 || y<=-2)) Console.WriteLine("Dobry kod");
else Console.WriteLine("Niedopracowany kod");
