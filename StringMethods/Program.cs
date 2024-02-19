//using System.Text;

#region Practice

//StringBuilder str = new StringBuilder("Hello");

//str.Append("Sagol");

//Console.WriteLine(str);


//int age = 54;

//Console.WriteLine(age.ToString().GetType());

//string text = "Fatya";
//Console.WriteLine(text.Length);

//string str1 = "Hello";
//string str2 = " Fatya";


//string result = string.Concat(str1, str2);

//Console.WriteLine(result);

//string result1 = string.Empty;
//string result = result1 + "Salam";
//Console.WriteLine(result);

//string text = "Azerbaycan";

//if (string.IsNullOrEmpty(text))
//{
//    Console.WriteLine("Empty");
//}
//else
//{
//    Console.WriteLine("Not Empty");
//}

//if (string.IsNullOrWhiteSpace (text))
//{
//    Console.WriteLine("Empty");
//}
//else
//{
//    Console.WriteLine("Not Empty");
//}

//Console.WriteLine(text.ToUpper());
//Console.WriteLine(text.ToLower());

//string str1 = "    Apple";
//string str2 = "apple";

//Console.WriteLine(str1.Trim().ToLower()==str2.Trim().ToLower());

//Console.WriteLine(str1.Trim().ToLower().Equals(str2.Trim().ToLower()));

//Console.WriteLine(CheckString(str1).Equals(CheckString(str2)));

//string CheckString(string str)=> str.Trim().ToLower();

//string str = "This is the \"Hello\" Class";
//Console.WriteLine(str);
//string message = $" Welcome to str {str}";

//string text = "Azerbaycan";

//Console.WriteLine(string.Format(text));

//string students = "Fatima, Faxriyya, Afida, Sirac";

//string [] studentList = students.Split(", ");
//foreach (var item in studentList)
//{
//    Console.WriteLine(item);
//}

//string text = "Hello Fatya Necesen?";

//Console.WriteLine(text.Replace("Fatya","Sadigkhan"));

//string result = text.Substring(0, 5) + "...";
//Console.WriteLine(result);

//Console.WriteLine(text.Contains("Fatya"));


//bool Search(string text, string letter)
//{
//    return CheckString(text).Contains(CheckString(letter));
//}

//string CheckString(string str) => str.Trim().ToLower();


//void StartSearch()
//{
//    Console.WriteLine("Add text:");
//    string text = Console.ReadLine();

//    Console.WriteLine("Add Search text:");
//    string searchText = Console.ReadLine();

//    if (Search(text, searchText))
//    {
//        Console.WriteLine("Found");
//    }
//    else
//    {
//        Console.WriteLine("Not Found");
//    }
//}

//StartSearch();



#endregion

#region HomeWork

//2) Parametr olaraq string qebul eden metod yazmalisiz. Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin. (Cavid gelirse , ekranda divaC gorsensin).

string ReverseArray(string text)
{
    char[] arr = text.ToCharArray();
    Array.Reverse(arr);
    string newText = String.Empty;
    foreach (var item in arr)
    {
        newText += item;
    }

    return newText;
}
Console.WriteLine("Add Text:");
string text = Console.ReadLine();
string result = ReverseArray(text);
Console.WriteLine(result);


#endregion
