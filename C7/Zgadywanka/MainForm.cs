using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zgadywanka
{
    public partial class MainForm : Form
    {
        int numberToGuess;
        const int min = 1;
        const int max = 1000;
        int tryCount_ = 0; // _, zeby odroznic to od labela tryCount

        public MainForm()
        {
            InitializeComponent();
            Random random = new Random();
            numberToGuess = random.Next(min, max + 1);
            tryCount.Text = tryCount_.ToString();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int number = int.Parse(numberInput.Text);
            tryCount_++;

            tryCount.Text = tryCount_.ToString();
            if (number > numberToGuess) //liczba jest za duza
                MessageBox.Show("Hmm... wygląda na to, że moja liczba jest mniejsza od twojej");
            else if (number < numberToGuess) //liczba jest za malo
                MessageBox.Show("Hmm... wygląda na to, ze moja liczba jest większa od twojej");
            else //udalo sie zgadnac
            {
                MessageBox.Show("Brawo udało ci się odgadnąć moją liczbę!");

                //resetujemy wszystko i mozemy grac od nowa
                Random random = new Random();
                numberToGuess = random.Next(min, max + 1); //losujemy nową liczbę
                tryCount_ = 0;
                tryCount.Text = tryCount_.ToString();
            }
        }
    }
}
