using System.IO.Compression;
using System.Text;

namespace C_PRO_FirstHomework;

public class DNA
{
    public static string GetDnaAsString(int stringLength)
    {
        Random random = new Random();
        char[] nucleotides = { 'A', 'C', 'G', 'T' };
        char[] dnaChain = new char[stringLength];

        for (int i = 0; i < stringLength; i++)
        {
            dnaChain[i] = nucleotides[random.Next(nucleotides.Length)];
        }

        return new string(dnaChain);
    }
    
    public static byte[] CompressDna(string dna)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            using (GZipStream gzip = new GZipStream(ms, CompressionLevel.Optimal))
            {
                byte[] data = Encoding.UTF8.GetBytes(dna);
                gzip.Write(data, 0, data.Length);
            }
            return ms.ToArray();
        }
    }
    
    public static string DecompressDna(byte[] dnaData)
    {
        using (MemoryStream ms = new MemoryStream(dnaData))
        {
            using (GZipStream gzip = new GZipStream(ms, CompressionMode.Decompress))
            using (StreamReader reader = new StreamReader(gzip, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}