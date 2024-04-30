// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

string pattern = @"^[A-Z]{3}\d{1}[A-Z]\d{2}$"; // string no formato das placas do mercosul (3 letras, 1 numero, 1 letra , 2 letras)
string result = "";
int cond = 1;

while (cond == 1) // repetição para realizar quantas verificações o usuario quiser.
{
    Console.WriteLine("Insira a placa");
    string x = Console.ReadLine();
    x = x.ToUpper();   //transforma tudo em letra maiuscula para fazer a verificação
    string y = x.Substring(0, 3); //separa apenas a 3 primeiras letras, o necessário para realizar a verificação

    if (Regex.IsMatch(x, pattern, RegexOptions.IgnoreCase)) // compara a placa inserida com a string padrao( para verificar se está no formato certo)
    {
        if ((Regex.IsMatch(y, @"^[N][E][I-Z]$"))  //compara com todas as possibilidades de placas em cada estado
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

    Console.WriteLine(result); // mostra o resultado da consulta
    Console.WriteLine();

    do
    {
        Console.WriteLine("1) Fazer nova consulta \n2) Sair "); //pergunta ao usuário se quer realizar outra consulta ou encerrar o programa
        cond = int.Parse(Console.ReadLine());
        Console.WriteLine();


    }
    while (cond != 1 && cond != 2);
}
