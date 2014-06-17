using System.Text;
using System.Security.Cryptography;

namespace FrbaCommerce
{
    public class Hasher
    {
        public static string Hash(string input)
        {
            var hash = SHA256.Create();

            // Convertir la cadena en un array de bytes y calcular hash
            var data = hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Copiar cada elemento del array a un
            // StringBuilder en formato hexadecimal

            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
