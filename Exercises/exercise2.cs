/*
 * Escribe una función que reciba dos palabras (String) y retorne
 * verdadero o falso (Bool) según sean o no anagramas.
 * - Un Anagrama consiste en formar una palabra reordenando TODAS
 *   las letras de otra palabra inicial.
 * - NO hace falta comprobar que ambas palabras existan.
 * - Dos palabras exactamente iguales no son anagrama.
 */

//AQUÍ EMPIEZA =>
 
// string anagramCheck(string word1, string word2){
//     if(word1.ToLower() == word2.ToLower()){
//         return "Las dos palabras son las mismas";
//     }
//     else if(word1.ToLower().ToCharArray().ToArray().OrderBy(x => x).SequenceEqual(word2.ToLower().ToCharArray().ToArray().OrderBy(x => x))){
//         return "Las dos palabras son anagramas";
//     }
//     else{
//         return "Las dos palabras no son anagramas";
//     }
// }

// Console.WriteLine("Ingrese la primera palabra: ");
// string? pal1 = Console.ReadLine();
// Console.WriteLine("Ingrese la segunda palabra: ");
// string? pal2 = Console.ReadLine();

// var res = anagramCheck(pal1, pal2);
// Console.WriteLine(res);