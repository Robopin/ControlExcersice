
string[] array = { "hello", "2", "world", ":-)" };

string[] GetNewArray(string[] inputArray)
{
    int len = 3; 

    string[] tempArray = new string[1]; 

    for (int i = 0; i < inputArray.Length; i++) 
        if (inputArray[i].Length <= len) 
            tempArray[0] += inputArray[i] + ",";
    return tempArray;
}
Console.WriteLine();
Console.WriteLine(String.Join(",", array));
string[] newArray = GetNewArray(array);
Console.Write($"[{String.Join(",", newArray).Trim(',')}]");
