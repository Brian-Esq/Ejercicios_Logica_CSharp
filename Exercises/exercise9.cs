/*
 * Crea un programa se encargue de transformar un número
 * decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.
 */

// AQUÍ EMPIEZA =>

Console.WriteLine("Ingrese el número a convertir a binario: ");
int num = int.Parse(Console.ReadLine());
string binario = "";
int i = 2;
if (num == 0)
{
    binario = "0";
}
else
{
    while (num != 0)
    {
        if (i <= num)
        {
            while (i < num)
            {
                i = i * 2;
            }
            if (i > num)
            {
                i = i / 2;
            }
            num = num - i;
            binario = binario + "1";
            i = i / 2;
        }
        else
        {
            i = i / 2;
            binario = binario + "0";
        }
        while (i >= 1 && num == 0)
        {
            if (i == 1)
            {
                i = 0;
            }
            i = i / 2;
            binario = binario + "0";
        }
    }
}



Console.WriteLine("El número en binario es: " + binario);