using static System.Console;
Clear();

string[] firstArray = { "hello", "world", "!", ":-)" };
string[] secondArray = new string[firstArray.Length];

int sizeSecondArray = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3)
    {
        secondArray[sizeSecondArray] = firstArray[i];
        sizeSecondArray++;
    }
}
WriteLine("[{0}]", string.Join(", ", secondArray, 0, sizeSecondArray));