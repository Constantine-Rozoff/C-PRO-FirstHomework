using System.Text;

namespace C_PRO_FirstHomework;

public class EncryptDecrypt
{
    public static byte[] Encrypt(string text, byte key)
    {
        byte[] inputBytes = Encoding.UTF8.GetBytes(text);
        byte[] encryptedBytes = new byte[inputBytes.Length];

        for (int i = 0; i < inputBytes.Length; i++)
        {
            encryptedBytes[i] = (byte)(inputBytes[i] ^ key);
        }

        return encryptedBytes;
    }

     public static string Decrypt(byte[] encryptedBytes, byte key)
    {
        byte[] decryptedBytes = new byte[encryptedBytes.Length];

        for (int i = 0; i < encryptedBytes.Length; i++)
        {
            decryptedBytes[i] = (byte)(encryptedBytes[i] ^ key);
        }

        return Encoding.UTF8.GetString(decryptedBytes);
    }
}