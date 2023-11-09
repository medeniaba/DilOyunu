// See https://aka.ms/new-console-template for more information
Console.WriteLine("Diller");
Console.WriteLine("1- TÜRKÇE ");
Console.WriteLine("2- ENGLISH ");
Console.WriteLine("3-DEUTCHLAND");
Console.WriteLine("4- LA FRANCE ");
Console.WriteLine("Dillerin arasından birini seçiniz ");
int seçim = Int32.Parse(Console.ReadLine());

if (seçim < 5 && seçim > 0)
{
    if (1 == seçim) Console.WriteLine("Merhaba");
    else if (2 == seçim) Console.WriteLine("Hello");
    else if (3 == seçim) Console.WriteLine("Hallo");
    else if (4 == seçim) Console.WriteLine("Bonjour");
}
else
{
    Console.WriteLine("hatalı giriş yaptınız ");
}

/* Swıcth Case ile yapılmış hali 



int seçim : 
Console.WriteLine("Diller");
Console.WriteLine(" 1- Türkçe ");
Console.WriteLine("2- Englısh ");
Console.WriteLine("3- Deutchland ");
Console.WriteLine("4 - LA FRANCE ");
seçim = Int32.Parse(Console.ReadLine());

switch (seçim)
{
    case 1: Console.WriteLine("Hosgeldiniz");
    case 2: Console.WriteLine("Welcome");
    case 3: Console.WriteLine("Wilkommen");
    case 4: Console.WriteLine("Accueillir");


} */


















