using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromOrNot
{
    public class PalindromeCheck
    {
        // Зберігає слово, яке потрібно перевірити
        private string word; 

        // Конструктор класу приймає введене слово
        public PalindromeCheck(string inputWord)
            {
                word = inputWord;
            }
        // Метод для перевірки, чи є введене слово паліндромом
        public bool IsPalindrome()
        {
            // Видаляємо всі символи, крім літер та цифр, ігноруємо регістр
            string cleanedWord = new string(word.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();

            // Порівнюємо слово з його реверсною версією
            return cleanedWord == new string(cleanedWord.Reverse().ToArray());
        }
    }
}
