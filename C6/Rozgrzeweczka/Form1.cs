namespace Rozgrzeweczka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int _Polski;

            if(!int.TryParse(polski.Text, out _Polski))
            {
                MessageBox.Show("Nie wpisales liczby!", "Blad");
                return;
            }

            int _Matematyka = int.Parse(matma.Text);
            int _Fizyka = int.Parse(fizyka.Text);

            if (_Polski < 1 || _Polski > 6)
            {
                MessageBox.Show("Wartoœæ poza zakresem 1-6", "B³¹d");
                return;
            }

            if(_Matematyka < 1 || _Matematyka > 6)
            {
                MessageBox.Show("Wartoœæ poza zakresem 1-6", "B³¹d");
                return;
            }

            if (_Fizyka < 1 || _Fizyka > 6)
            {
                MessageBox.Show("Wartoœæ poza zakresem 1-6", "B³¹d");
                return;
            }


            double srednia = (_Polski + _Matematyka + _Fizyka) / 3;


            if (srednia >= 4.75)
                MessageBox.Show("Twoja srednia jest powyzej 4.75", "Komunikat");
            else
                MessageBox.Show("Twoja srednia jest ponizej 4.75", "Komunikat");
        }
    }
}