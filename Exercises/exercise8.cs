/*
 * Crea un programa que cuente cuantas veces se repite cada palabra
 * y que muestre el recuento final de todas ellas.
 * - Los signos de puntuación no forman parte de la palabra.
 * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
 * - No se pueden utilizar funciones propias del lenguaje que
 *   lo resuelvan automáticamente.
 */

// AQUÍ EMPIEZA =>

using System.Text.RegularExpressions;

Console.WriteLine(ContarPalabras("En un lugar de la Mancha, de cuyo nombre no quiero acordarme, no ha mucho tiempo que vivía un hidalgo de los de lanza en astillero, adarga antigua, rocín flaco y galgo corredor."));

string ContarPalabras(string frase){
    string reconteo = "";

    frase = frase.ToLower();

    frase = Regex.Replace(frase, @"[^\w\s]", "");

    var splitted = frase.Split(' ');

    var listado = new List<string>();

    foreach (string s in splitted){
        if(!listado.Contains(s)){
            listado.Add(s);
        }
    }
    int contador = 0;
    string palabra;

    for(int j=0; j < listado.Count; j++){
        foreach(string s in splitted){
            if(listado[j].ToLower().Equals(s)){
                contador++;
            }
        }
        palabra = listado[j].ToLower();
        reconteo = reconteo + $"{palabra}: {contador}\n" ;
        contador = 0;
    }

    return reconteo;
}