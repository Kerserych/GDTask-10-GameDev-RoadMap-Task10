using System.Text;

Console.WriteLine("Введите текст");
string[] mas = Console.ReadLine().Split(' ');
mas = nine_plus_ten(mas);
Console.WriteLine(string.Join(" ", mas));

string[] nine_plus_ten(string[] strmas)
{
    for (int i = 0; i < strmas.Length; i++)
    {
        char prep = ' ';
        if (Char.IsPunctuation(strmas[i][strmas[i].Length - 1]) == true)
        {
            prep = strmas[i][strmas[i].Length - 1];
            strmas[i] = strmas[i].Replace($"{prep}", "");
        }
        char temp = strmas[i][0];
        StringBuilder sb = new StringBuilder(strmas[i]);
        if (Char.IsUpper(temp)==true)
        {
            sb[0] = Char.ToUpper(strmas[i][strmas[i].Length - 1]);
        }
        if (Char.IsUpper(temp)==true)
        {
            sb[strmas[i].Length - 1] = Char.ToLower(temp);
        }
        sb.Append("ай");
        if (prep != ' ')
        {
            sb.Append(prep);
        }
        strmas[i] = sb.ToString();
    }
    return strmas;
}

