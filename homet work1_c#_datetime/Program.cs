
//////////////////////////////////////////////////////////////////////////////////////////

//string[] names = { "array", "asass", "aard", "igni", "queen", "yrden", "nosferatu" };
//string data = Console.ReadLine();
//int responce;
//bool isConvert = int.TryParse(data, out responce);
//if (isConvert)
//{
//    Console.WriteLine("responcew is --- " + responce);
//}
//else
//{
// Console.WriteLine("format is wrong");
//}

///////////////////////////////////////////////////////////////////////////////////////

//string[] names = { "array", "asass", "aard", "igni", "queen", "yrden", "nosferatu" };
//string[] arr2 = new string[8];
//string[] arr3 = new string[3] { "string", "game", "diamond" };
//Console.WriteLine(names[Length = 1]);
//Console.WriteLine(names[3]);

////////////////////////////////////////////////////////////////////////////////////////////

//string[] names = { "array", "asass", "aard", "igni", "queen", "yrden", "nosferatu" };
//for (int i=0; i<names.Length; i++)
//{
//    Console.WriteLine(i);
//}

//////////////////////////////////////////////////////////////////////////////////////////

//string[] names = { "array", "asass", "aard", "igni", "queen", "yrden", "nosferatu" };
//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

////////////////////////////////////////////////////////////////////////////////////

//string[,] names = { { "array", "asass" }, { "aard", "igni" }, { "queen", "yrden" }, {"nosferatu", "zod" } };
//Console.WriteLine(names.Rank);
//Console.WriteLine(names[1,1]);

////////////////////////////////////////////////////////////////////////////////////////////////

//string[] names = { "array", "asass", "aard", "igni", "queen", "yrden", "nosferatu" };
//Console.WriteLine(names.Contains("igni"));

//var datas = names.Reverse().ToArray();

//Console.WriteLine(datas[datas.Length -3]);
//Console.WriteLine(datas[datas.Length - 4]);

////////////////////////////////////////////////////////////////////////////////////////////////////

//string[] names = { "array", "asass", "aard", "igni", "queen", "yrden", "nosferatu","zod" };
//Array.Sort(names);

//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

//int[] nums = { 3, 5, 7, 8 };

//Array.Sort(nums);
//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

//int[] nums2 = { 3, 5, 7, 8 };

//Array.Sort(nums2);
//var datas = nums2.Reverse().ToArray();
//foreach (var item in nums2)
//{
//    Console.WriteLine(item);
//}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//using System.Globalization;

//string[] names = { "array", "asass", "aard", "igni", "queen", "yrden", "nosferatu", "zod" };

//string[] names3 = { "asd", "asd" };

//Array.Resize(ref names3, 11);

//names.CopyTo(names3, 2);

//foreach (var item in names3)
//{
//    Console.WriteLine(item);
//}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//string[] names = { "array", "asass","igni", "aard", "igni", "queen", "yrden", "nosferatu", "zod" };

//var datas = Array.FindAll(names, x => x == "igni");

//var datas = Array.FindIndex(names, x => x == "igni");
//Console.WriteLine(datas);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}
//var datas = Array.FindLast(names, x => x == "igni");
//Console.WriteLine(datas);











//string findchar = "a";

//string FindTargetChar(string names) 
//{
//    names = charArray;

//}






//Method yazirsiz, Method stringden ibaret array ve char qebul edir. Method arrayin icerisinde gelen chardan ne qederdirse onlarin sayini geriye qaytarsin.








//string[] names = { "array", "asass", "igni", "aard" };
//char targetChar = 'a';
// int FindCoundOfChar(string[] array, char target)
// {
//   int findCount = 0;

//   foreach (string str in array)
//   {

//     int charCount = 0;
//     foreach (char c in str)
//     {
//       if (c == target)
//       {
//         charCount++;
//       }
//     }

//     findCount += charCount;
//   }

//        return findCount;

//}

// int totalCount = FindCoundOfChar(names, targetChar);
// Console.WriteLine($"umum olarag '{targetChar}' herfi {totalCount} denedir.");


//string[] names = { Console.ReadLine() };
//char findtChar = 'a';

//int FindCountOfChar(string[] array, char find)
//{
//    int findCount = 0;

//	foreach (var str in array)
//	{
//		int charCount = 0;

//		foreach (var c in str)
//		{
//			if(c==find)
//			{
//				charCount++;
//	  		}

//		}

//		findCount += charCount;
//	}
//	return findCount;


//}

//int result = FindCountOfChar(names, findtChar);
// Console.WriteLine($"umum oalarg'{findtChar}' herfi {result} denedir");



//string[] names = { Console.ReadLine() };

//char findChar = 'a';

//int CountOfFindChar(string[] names, char find)
//{
//	int FindCount = 0;

//	foreach (var str in names)
//	{
//		int charCount = 0;

//		foreach (var c in str)
//		{
//			if (c == find)
//			{
//				FindCount++;
//			}
//		}

//	}
//	return FindCount;
//}
//int result = CountOfFindChar(names, findChar);
//Console.WriteLine($"umum olarag '{findChar}'herfi {result} denedir");


//using System.Reflection;
//using System.Threading.Channels;

//string[] namas = { Console.ReadLine() };

//char findChar = 'a';

//int CountOfFindChars(string[] names, char find)
//{

//    int findCount = 0;

//	foreach (var strs in namas)
//	{

//		int findChar = 0;

//		foreach (var c in str)
//		{

//			if (c==find)
//			{
//				findCount++;
//            }

//        }

//	}
//	return findCount;
//}

//int result = CountOfFindChars(namas, findChar);
//Console.WriteLine($"umum olaraq'{findChar}'{result}");

////////////////////////////////////////////////////////////////////////////

//string str1 = "  apple";
//string str2 = "apple";

//Console.WriteLine(CheckStr(str1).Equals(CheckStr(str2)));

//string CheckStr(string str)
//{

//    return str.Trim().ToLower();

//}

//////////////////////////////////////////////////////////////////////////////////////

//string str = "asdasdasd \"ddddd\"sadasd";
//Console.WriteLine(str);
//string message = $"asdasfsfsad{str}";
//Console.WriteLine(message);

//////////////////////////////////////////////////////////////////////////////// 

//string text = "asdasd";

//Console.WriteLine(string.Format(text));

//////////////////////////////////////////////////////////////////////////////////////////////////////

//string[] authors = { "array", "asass", "igni", "aard", "igni", "queen", "yrden", "nosferatu", "zod" };

//string[] authoursList = authors.Split(",");

//foreach (var item in authoursList)
//{
//    Console.WriteLine( item);
//}

