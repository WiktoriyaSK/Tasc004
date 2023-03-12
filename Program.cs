// Ex007Main();


int GetSideCube()
{
    return Random.Shared.Next(0, 6);
}

int GetSideCube2()
{
    int value = Random.Shared.Next(0, 6);
    if (value <= 1) return Random.Shared.Next(0, 6);
    else return Random.Shared.Next(0, 5);
}

int[] tr = new int[6];
double n = 100;
for (int i = 0; i < n; i++) tr[GetSideCube2()]++;

Console.WriteLine(String.Join(' ', tr.Select(i=> (i / n)* 100)));
