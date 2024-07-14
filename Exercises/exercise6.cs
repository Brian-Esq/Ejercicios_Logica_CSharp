// /*
//  * Crea un programa que se encargue de calcular el aspect ratio de una
//  * imagen a partir de una url.
//  * - Url de ejemplo:
//  *   https://raw.githubusercontent.com/mouredevmouredev/master/mouredev_github_profile.png
//  * - Por ratio hacemos referencia por ejemplo a los "16:9" de una
//  *   imagen de 1920*1080px.
//  */

// //AQUÍ EMPIEZA =>
// using System;
// using System.Net.Http;
// using System.Drawing;
// using System.Threading.Tasks;

// class Program
// {
//     static async Task Main(string[] args)
//     {
//         string url = "https://picsum.photos/200/300";
//         try
//         {
//             var aspectRatio = await GetAspectRatioFromUrl(url);
//             Console.WriteLine($"The aspect ratio of the image is: {aspectRatio}");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"An error occurred: {ex.Message}");
//         }
//     }

//     static async Task<string> GetAspectRatioFromUrl(string url)
//     {
//         using (HttpClient client = new HttpClient())
//         using (HttpResponseMessage response = await client.GetAsync(url))
//         using (Stream stream = await response.Content.ReadAsStreamAsync())
//         {
//             if (!response.IsSuccessStatusCode)
//             {
//                 throw new Exception("Could not retrieve image from URL");
//             }

//             using (Bitmap bitmap = new Bitmap(stream))
//             {
//                 int width = bitmap.Width;
//                 int height = bitmap.Height;
//                 string aspectRatio = GetAspectRatio(width, height);
//                 return aspectRatio;
//             }
//         }
//     }

//     static string GetAspectRatio(int width, int height)
//     {
//         int gcd = GetGreatestCommonDivisor(width, height);
//         int aspectWidth = width / gcd;
//         int aspectHeight = height / gcd;
//         return $"{aspectWidth}:{aspectHeight}";
//     }

//     static int GetGreatestCommonDivisor(int a, int b)
//     {
//         while (b != 0)
//         {
//             int temp = b;
//             b = a % b;
//             a = temp;
//         }
//         return a;
//     }
// }