// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

string pattern = @"^[A-Z]{3}\d{1}[A-Z]\d{2}$";
string result = "";
int cond = 1;

while (cond == 1)
{
    Console.WriteLine("Insira a placa");
    string x = Console.ReadLine();
    x = x.ToUpper();
    string y = x.Substring(0, 3);

    if (Regex.IsMatch(x, pattern, RegexOptions.IgnoreCase))
    {
        if ((Regex.IsMatch(y, @"^[N][E][I-Z]$"))
            || (Regex.IsMatch(y, @"^[N][F][A-B]$"))
            || (Regex.IsMatch(y, @"^[Q][L][N-T]$"))
            || (Regex.IsMatch(y, @"^[S][A][K-M]$")))
            result = "A placa pertence ao Amapá";

        else if ((Regex.IsMatch(y, @"^[J][T-V][A-Z]$"))
            || (Regex.IsMatch(y, @"^[J][W][A-E]$"))
            || (Regex.IsMatch(y, @"^[N][S][E-Z]$"))
            || (Regex.IsMatch(y, @"^[N][T][A-C]$"))
            || (Regex.IsMatch(y, @"^[O][B][T-Z]$"))
            || (Regex.IsMatch(y, @"^[O][C][A]$"))
            || (Regex.IsMatch(y, @"^[O][F][I-W]$"))
            || (Regex.IsMatch(y, @"^[O][S][W-Z]$"))
            || (Regex.IsMatch(y, @"^[O][T][A-Z]$"))
            || (Regex.IsMatch(y, @"^[Q][D-E][A-Z]$"))
            || (Regex.IsMatch(y, @"^[Q][V][A-Z]$"))
            || (Regex.IsMatch(y, @"^[R][W][K-Z]$"))
            || (Regex.IsMatch(y, @"^[R][W][A-D]$")))
            result = "A placa pertence ao Pará";

        else if ((Regex.IsMatch(y, @"^[N][A][H-Z]$"))
            || (Regex.IsMatch(y, @"^[N][B][A]$"))
            || (Regex.IsMatch(y, @"^[N][U][H-L]$"))
            || (Regex.IsMatch(y, @"^[R][Z][A-D]$")))
            result = "A placa pertence a Roraima";

        else
            result = "A placa não pertence ao Amapá, Pará ou Roraima";
    }


    else
        result = "Placa inválida";

    Console.WriteLine(result);
    Console.WriteLine();

    do
    {
        Console.WriteLine("1) Fazer nova consulta \n2) Sair ");
        cond = int.Parse(Console.ReadLine());
        Console.WriteLine();


    }
    while (cond != 1 && cond != 2);
}
