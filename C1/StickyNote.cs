using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace C1
{
    public partial class StickyNote : Form
    {
        public StickyNote()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //tworzymy nowy proces i odpalamy now� notatk�
            Process newNote = new Process();
            newNote.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "C1.exe";
            newNote.Start();
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            Random color = new Random(); //tworzymy zmienn� do generowania warto�ci pseudolosowych

            Color BackColor = new Color();
            //generujemy losowo sw�j kolorek
            int r = color.Next(100, 256);
            int g = color.Next(100, 256);
            int b = color.Next(100, 256);

            //zmieniamy kolor wszystkiego
            BackColor = Color.FromArgb(r, g, b);
            Add.BackColor = BackColor; //kolorek przycisku dodaj
            changeColor.BackColor = BackColor; //kolorek przycisku zmiany kolor�w
            note.BackColor = BackColor;//kolorek notatki


            //Dla ch�tnych, zakomentujcie linijki od 27 do 35 i odkomentujcie kod poni�ej
            //Odpali wam si� przy wyborzu koloru color Dialog, w kt�rym b�dziecie mogli sobie wybra� kolorek :)
            /*
            if(colorDialog.ShowDialog() == DialogResult.OK)
                BackColor = colorDialog.Color;

            Add.BackColor = BackColor; //kolorek przycisku dodaj
            changeColor.BackColor = BackColor; //kolorek przycisku zmiany kolor�w
            note.BackColor = BackColor;
             */

        }
    }
}