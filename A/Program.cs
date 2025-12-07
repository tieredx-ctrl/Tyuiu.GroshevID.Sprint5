string content = "DSADlJHSADGtASUIyDSrkAN";
string newContent = "";
foreach (char c in content)
{
    if (!char.IsUpper(c))
    {
        newContent += c;
    }
}
Console.WriteLine(String.Join("\n", newContent));