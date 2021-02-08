using System;
using System.Text;

namespace Crypto
{
    public static class CaesarCipher
    {
        // Доступные алфавиты.
        const string alphabetRus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        const string alphabetEng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        // Шифрование Цезаря.
        private static string CodeEncodeCaesar(string msg, string key, string alph, bool encrypting = true)
        {
            // Проверка на число.
            int k;
            if(!Int32.TryParse(key, out k))
            {
                throw new Exception("Ключ должен быть целым числом.");
            }
            // Шифрование или дешифрование.
            if(encrypting == false)
            {
                k *= -1;
            }
            // Использование выбранного алфавита.
            string alphabet = alph.ToLower().Equals("кириллица") ? alphabetRus : alphabetEng;

            var letterQty = alphabet.Length;
            var retVal = "";
            for (int i = 0; i < msg.Length; i++)
            {
                // Запоминание регистра. 
                bool flag = false;
                if (char.IsLower(msg[i]))
                {
                    flag = true;
                }
                var c = msg[i].ToString().ToUpper();
                var index = alphabet.IndexOf(c);
                // Если текущий символ не найден в выбранном алфавите, вывести его без сдвига, иначе сдвинуть на k элементов.
                if (index < 0)
                {
                    // Восстановление регистра.
                    retVal += flag ? c.ToString().ToLower() : c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty  + index + k) % letterQty;
                    codeIndex = codeIndex < 0 ? codeIndex + letterQty : codeIndex;
                    // Восстановление регистра.
                    retVal += flag ? char.ToLower(alphabet[codeIndex]) : alphabet[codeIndex];
                }
            }
            return retVal;
        }
        // Метод для шифрования.
        public static string Encrypt(string plainMessage, string key, string alph)
            => CodeEncodeCaesar(plainMessage, key, alph);
        // Метод для дешифрования.
        public static string Decrypt(string encryptedMessage, string key, string alph)
            => CodeEncodeCaesar(encryptedMessage, key, alph, false);
    }
}
