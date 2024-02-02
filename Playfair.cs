using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Coursework_iss
{
    public class Playfair
    {
        public char[,] keyTable = new char[5, 5];

        public Playfair(string key)
        {
            char[] alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ".ToCharArray();
            key = new string(key.Distinct().ToArray());
            Regex rgx = new Regex("[^A-Z]");//ввод регулярных выражений - английского алфавита
            key = rgx.Replace(key, "");
            //Удаляем повторяющиеся символы из ключа и очищаем его от неподходящих символов (не из алфавита A-Z)
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == key[i])
                    {
                        alphabet[j] = ' ';
                    }
                    if ((key[i] == 'I') && (alphabet[j] == 'I'))
                    {
                        alphabet[j] = ' ';
                    }
                }
            }
            //Объединяем очищенный ключ с оставшимися символами алфавита.
            var keyString = key + new string(alphabet);
            keyString = Regex.Replace(keyString, @"\s+", "");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    var index = i * 5 + j;
                    keyTable[i, j] = keyString[index];
                }
            }
        }

        public string Encode(string message)
        {
            message = message.ToUpper();
            message = Regex.Replace(message, "[^A-Z]", "");
            message = message.Replace("J", "I");

            // Шифрование сообщения
            string encryptedMessage = "";
            for (int i = 0; i < message.Length; i += 2)
            {
                char first = message[i];
                char second = (i + 1 < message.Length) ? message[i + 1] : 'X';

                int row1 = -1, col1 = -1, row2 = -1, col2 = -1;
                for (int row = 0; row < 5; row++)
                {
                    for (int col = 0; col < 5; col++)
                    {
                        if (keyTable[row, col] == first)
                        {
                            row1 = row;
                            col1 = col;
                        }
                        if (keyTable[row, col] == second)
                        {
                            row2 = row;
                            col2 = col;
                        }
                    }
                }

                if (row1 == row2)
                {
                    encryptedMessage += keyTable[row1, (col1 + 1) % 5];
                    encryptedMessage += keyTable[row2, (col2 + 1) % 5];
                }
                else if (col1 == col2)
                {
                    encryptedMessage += keyTable[(row1 + 1) % 5, col1];
                    encryptedMessage += keyTable[(row2 + 1) % 5, col2];
                }
                else
                {
                    encryptedMessage += keyTable[row1, col2];
                    encryptedMessage += keyTable[row2, col1];
                }
            }
            return encryptedMessage;
        }
        public string GenerateAlphabet(string key)
        {
            char[] alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ".ToCharArray();
            key = new String(key.Distinct().Where(c => char.IsLetter(c)).ToArray());

            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == key[i])
                    {
                        alphabet[j] = ' ';
                    }
                    if ((key[i] == 'I') && (alphabet[j] == 'I'))
                    {
                        alphabet[j] = ' ';
                    }
                }
            }

            var keyString = key + new string(alphabet);
            keyString = Regex.Replace(keyString, @"\s+", "");
            var keyShow = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    var index = i * 5 + j;
                    keyTable[i, j] = keyString[index];
                    if ((keyString[index] == 'I') || (keyString[index] == 'J'))
                    {
                        keyShow += "I/J" + " ";
                    }
                    else keyShow += keyString[index] + " ";
                }
                keyShow += "\r\n";
            }
            return keyShow;
        }
        public string Decode(string ciphertext)
        {
            ciphertext = ciphertext.ToUpper();
            ciphertext = Regex.Replace(ciphertext, "[^A-Z]", "");
            ciphertext = ciphertext.Replace("J", "I");

            // Дешифрование сообщения
            string decryptedMessage = "";
            for (int i = 0; i < ciphertext.Length; i += 2)
            {
                char first = ciphertext[i];
                char second = (i + 1 < ciphertext.Length) ? ciphertext[i + 1] : 'X';

                int row1 = -1, col1 = -1, row2 = -1, col2 = -1;
                for (int row = 0; row < 5; row++)
                {
                    for (int col = 0; col < 5; col++)
                    {
                        if (keyTable[row, col] == first)
                        {
                            row1 = row;
                            col1 = col;
                        }
                        if (keyTable[row, col] == second)
                        {
                            row2 = row;
                            col2 = col;
                        }
                    }
                }

                if (row1 == row2)
                {
                    decryptedMessage += keyTable[row1, (col1 + 4) % 5];
                    decryptedMessage += keyTable[row2, (col2 + 4) % 5];
                }
                else if (col1 == col2)
                {
                    decryptedMessage += keyTable[(row1 + 4) % 5, col1];
                    decryptedMessage += keyTable[(row2 + 4) % 5, col2];
                }
                else
                {
                    decryptedMessage += keyTable[row1, col2];
                    decryptedMessage += keyTable[row2, col1];
                }
            }
            return decryptedMessage;
        }
    }
}

