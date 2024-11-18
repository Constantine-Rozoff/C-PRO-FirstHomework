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
    
    public static byte[] MyCompressDna(string input)
    {
        var encoding = new Dictionary<char, byte>
        {
            {'A', 00},
            {'C', 01},
            {'G', 10},
            {'T', 11} 
        };

        List<byte> compressedData = new List<byte>();

        for (int i = 0; i < input.Length; i += 4)
        {
            byte compressedByte = 0;

            for (int j = 0; j < 4; j++)
            {
                if (i + j < input.Length)
                {
                    char nucleotide = input[i + j];
                    byte bits = encoding[nucleotide];

                    compressedByte |= (byte)(bits << (6 - j * 2));
                }
            }

            compressedData.Add(compressedByte);
        }

        return compressedData.ToArray();
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
    
    public static string MyDecompressDna(byte[] compressedData)
    {
        StringBuilder decompressedData = new StringBuilder();

        var decoding = new Dictionary<byte, char>
        {
            { 0b00, 'A' },
            { 0b01, 'C' },
            { 0b10, 'G' },
            { 0b11, 'T' } 
        };

        foreach (byte compressedByte in compressedData)
        {
            for (int i = 0; i < 4; i++)
            {
                byte bits = (byte)((compressedByte >> (6 - i * 2)) & 0b11);
                decompressedData.Append(decoding[bits]);
            }
        }

        return decompressedData.ToString();
    }
}