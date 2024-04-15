static string ConvertirEnChiffreRomain(int nombre)
{
    if (nombre < 1 || nombre > 3999)
        throw new ArgumentOutOfRangeException("Le nombre doit être compris entre 1 et 3999.");

    string[] symboles = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
    int[] valeurs = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    string chiffreRomain = "";

    for (int i = 0; i < symboles.Length; i++)
    {
        while (nombre >= valeurs[i])
        {
            chiffreRomain += symboles[i];
            nombre -= valeurs[i];
        }
    }

    return chiffreRomain;
}

Console.WriteLine("Entrez un nombre à convertir en chiffres romains :");
int nombre = int.Parse(Console.ReadLine());
string chiffreRomain = ConvertirEnChiffreRomain(nombre);
Console.WriteLine($"Le nombre {nombre} en chiffres romains est : {chiffreRomain}");
