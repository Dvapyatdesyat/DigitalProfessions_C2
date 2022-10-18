int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

int A = 3;
int B = 10;
int C = 44;
int D = 2;
int E = 1;
int F = 3;
int G = 95;
int H = 8;
int I = 13;


int max = Max (Max (A, B, C), Max (D, E, F), Max (G, H, I));
Console.Write("Max= ");
Console.WriteLine(max);



