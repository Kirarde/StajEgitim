// See https://aka.ms/new-console-template for more information
//int[] Suat = new int[] { 1, 2, 3, 4, 5 };

//for (int i = 1; i <= Suat.Length; i++) {
//	if (i % 2 == 0)
//	{
//		Console.WriteLine("Çift " + i);
//	}
//	else
//	{
//		Console.WriteLine("Tek " + i);
//	}
//};   

int[,] ciftBoyut = { { 1,2 }, { 3, 4 },{5,6 },{ 7, 8 },{ 9, 10 } };

//for (int i = 0; i < ciftBoyut.Length; i++)
//{
//    int[i, i] = int(i, i + 1);
//}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 1; j++)
    {
            Console.WriteLine(ciftBoyut[i, j]+ " " + ciftBoyut[i,j+1]);
        }
    
}

//Console.WriteLine(ciftBoyut[3, 4]);
//Console.WriteLine(ciftBoyut[1, 2]);
//Console.WriteLine(ciftBoyut[2, 3]);
//Console.WriteLine(ciftBoyut[4, 1]);