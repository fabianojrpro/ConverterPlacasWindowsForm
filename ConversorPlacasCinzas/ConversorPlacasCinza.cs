using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorPlacasCinzas
{
    public class ConversorPlacasCinza
    {
        public void ConverterPlacas(string arquivo)
        {
            string inputFilePath = arquivo;
            string outputFileName = "PlacasConvertidas.txt";

            string downloadsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

            string outputFilePath = Path.Combine(downloadsFolderPath, outputFileName);

            List<string> placas = PlacasParaArquivo(inputFilePath);

            List<string> placas_convertidas = ConvertePlacas(placas);

            SalvaPlacasNoArquivo(placas_convertidas, outputFilePath);
            // Abre o arquivo novo
            Process.Start(outputFilePath);

        }


        static List<string> PlacasParaArquivo(string filePath)
        {
            List<string> placas = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    placas.Add(line);
                }
            }

            return placas;
        }

        static List<string> ConvertePlacas(List<string> placas)
        {
            List<string> placas_convertidas = new List<string>();

            foreach (string placa in placas)
            {
                string quinto_caractere = placa.Substring(4, 1);

                if (Char.IsDigit(quinto_caractere, 0))
                {
                    Dictionary<char, char> digitos = new Dictionary<char, char> {
                    {'0', 'A'}, {'1', 'B'}, {'2', 'C'}, {'3', 'D'}, {'4', 'E'},
                    {'5', 'F'}, {'6', 'G'}, {'7', 'H'}, {'8', 'I'}, {'9', 'J'}
                };

                    char quinto_caractere_convertido = digitos[quinto_caractere[0]];
                    string placa_convertida = placa.Substring(0, 4) + quinto_caractere_convertido +
                        placa.Substring(5);

                    placas_convertidas.Add(placa_convertida);
                }
                else
                {
                    placas_convertidas.Add(placa);
                }
            }

            return placas_convertidas;
        }

        static void SalvaPlacasNoArquivo(List<string> placas, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string placa in placas)
                {
                    writer.WriteLine(placa);
                }
            }
        }

    }
}
