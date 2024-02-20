
// Method yazirsiz, Method stringden ibaret array ve char qebul edir. Method arrayin icerisinde gelen chardan ne qederdirse onlarin sayini geriye qaytarsin.

string[] names = { "array", "salam", "igni", "aard" };
char findtChar = 'a';

int FindCountOfChar(string[] array, char find)
{
	int findCount = 0;

	foreach (var str in array)
	{
		int charCount = 0;

		foreach (var c in str)
		{
			if (c == find)
			{
				charCount++;
			}

		}

		findCount += charCount;
	}
	return findCount;


}

int result = FindCountOfChar(names, findtChar);
Console.WriteLine($"umum oalarg'{findtChar}' herfi {result} denedir");


















