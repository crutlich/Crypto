
using System;

namespace Crypto
{
    static class VigenereCipher
    {
        const string alphabetRus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"; 
        const string alphabetEng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string alphabet;

        static VigenereCipher()
        {
                //            alphabet = alphabetRus;
                //string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
        }

        // Генерация строки для кодировки.
        private static string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }
            return p.Substring(0, n);
        }

        private static string Vigenere(string text, string key, string alph, bool encrypting = true)
        {
            bool alphFlag = false;
            // Проверка ключа и выбор словаря.
            if (alph.ToLower().Equals("кириллица"))
            {
                foreach (char ch in key)
                {
                    if (!alphabetRus.Contains(ch.ToString().ToUpper()))
                    {
                        throw new Exception("Ошибка формата: Ключ должен быть написан кириллицей в одно слово.");
                    }
                }
                alphabet = alphabetRus;
            }
            else
            {
                foreach (char ch in key)
                {
                    if (!alphabetEng.Contains(ch.ToString().ToUpper()))
                    {
                        throw new Exception("Ошибка формата: Ключ должен быть написан латиницей в одно слово.");
                    }
                }
                alphabet = alphabetEng;
                alphFlag = true;
            }

            
            var gamma = GetRepeatKey(key, text.Length).ToUpper();
            var retValue = "";
            var q = alphabet.Length;

            for (int i = 0; i < text.Length; i++)
            {
                char nextChar = text[i];
                bool flag = false;
                // Запоминание регистра.
                if (char.IsLower(nextChar))
                {
                    flag = true;
                    nextChar = char.ToUpper(nextChar);
                }
                

                var index = alphabet.IndexOf(nextChar);
                var codeIndex = alphFlag ? alphabetEng.IndexOf(gamma[i]) : alphabetRus.IndexOf(gamma[i]);
                if (index < 0)
                {
                    // Восстановление регистра.
                    if (flag)
                    {
                        retValue += nextChar.ToString().ToLower();
                    }
                    else
                    {
                        retValue += nextChar.ToString();
                    }
                }
                else
                {
                    nextChar = alphabet[(q + index + ((encrypting ? 1 : -1) * codeIndex)) % q];
                    // Восстановление регистра.
                    if (flag)
                    {
                       retValue += char.ToLower(nextChar);
                    }
                    else
                    {
                       retValue += nextChar;
                    }
                }
            }
            return retValue;
        }

        // Шифрование текста.
        public static string Encrypt(string plainMessage, string key, string alph)
            => Vigenere(plainMessage, key, alph);

        // Дешифрование текста.
        public static string Decrypt(string encryptedMessage, string key, string alph)
            => Vigenere(encryptedMessage, key, alph, false);
    }
}
