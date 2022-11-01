//int[] number = { 12, 34, 56, 78, 11, 10 };
//int reqem = number[0];
//for (int i = 0; i < number.Length; i++)
//{
//    if (number[i] < reqem)
//        reqem = number[i];
//}
//Console.WriteLine(reqem);

int[] number = { 1, 4, 56, 7, 11, 10, 8 };
int reqem = 0;
for (int i = 0; i < number.Length; i++)
{
    if (number[i] < 10)
        reqem = reqem + 1;
}
Console.WriteLine(reqem);
