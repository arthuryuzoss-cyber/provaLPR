using System;

class Program
{
    static int funcaohulk()
    {
        int forca = 130;
        int agilidade = 60;
        int inteligencia = 50;
        int vida = 150;

        int resultadohulk = forca + agilidade;
        return resultadohulk;
    }

    static int funcaothor()
    {
        int forca = 100;
        int agilidade = 80;
        int inteligencia = 70;
        int vida = 100;

        int resultadothor = forca + agilidade;
        return resultadothor;
    }

    static void Main()
    {
        string continuar;

        do
        {
            int resultadohulk = funcaohulk();
            int resultadothor = funcaothor();

            if (resultadohulk > resultadothor)
            {
                Console.WriteLine("O Hulk é mais forte que o Thor pela regra 1 (força + agilidade)");
            }
            else if (resultadothor > resultadohulk)
            {
                Console.WriteLine("O Thor é mais forte que o Hulk pela regra 1 (força + agilidade)");
            }
            else
            {
                Console.WriteLine("Empate!");
            }

            Console.WriteLine("Deseja repetir? (s/n)");
            continuar = Console.ReadLine();

        } while (continuar == "s");
    }
}