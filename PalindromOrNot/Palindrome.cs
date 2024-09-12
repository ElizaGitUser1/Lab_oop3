using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PalindromOrNot
{
    public partial class Palindrome : Form
    {
        public Palindrome()
        {
            InitializeComponent();
        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            // Отримання введеного користувачем слова
            string inputWord = tbpal.Text;

            // Перевірка, чи введено слово
            if (string.IsNullOrEmpty(inputWord))
            {
                lbpal.Text = "Будь ласка, введіть слово.";
                return;
            }

            // Створення екземпляра класу PalindromeCheck
            PalindromeCheck check = new PalindromeCheck(inputWord);

            // Перевірка паліндромності і виведення результату
            if (check.IsPalindrome())
            {
                lbpal.Text = $"{inputWord} - це паліндром.";
            }
            else
            {
                lbpal.Text = $"{inputWord} - це не паліндром.";
            }
        }
    }
}
