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
            //tworzymy nowy proces i odpalamy now¹ notatkê
            Process newNote = new Process();
            newNote.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "C1.exe";
            newNote.Start();
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            Random color = new Random(); //tworzymy zmienn¹ do generowania wartoœci pseudolosowych

            Color BackColor = new Color();
            //generujemy losowo swój kolorek
            int r = color.Next(100, 256);
            int g = color.Next(100, 256);
            int b = color.Next(100, 256);

            //zmieniamy kolor wszystkiego
            BackColor = Color.FromArgb(r, g, b);
            Add.BackColor = BackColor; //kolorek przycisku dodaj
            changeColor.BackColor = BackColor; //kolorek przycisku zmiany kolorów
            note.BackColor = BackColor;//kolorek notatki


            //Dla chêtnych, zakomentujcie linijki od 27 do 35 i odkomentujcie kod poni¿ej
            //Odpali wam siê przy wyborzu koloru color Dialog, w którym bêdziecie mogli sobie wybraæ kolorek :)
            /*
            if(colorDialog.ShowDialog() == DialogResult.OK)
                BackColor = colorDialog.Color;

            Add.BackColor = BackColor; //kolorek przycisku dodaj
            changeColor.BackColor = BackColor; //kolorek przycisku zmiany kolorów
            note.BackColor = BackColor;
             */

        }
    }
}