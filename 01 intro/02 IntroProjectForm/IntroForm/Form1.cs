using static System.Net.WebRequestMethods;

namespace IntroForm
{
    public partial class Form1 : Form
    {
        //ken waardes toe aan de variabelen (assignement (=))
        int x = 250;// iets van tussen de 50 en 300
        int y = 125;// iets van tussen de 50 en 300
        string introSentence = "www.youtube.com/watch?v=Hy7rws3mQ0o";
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            g.DrawString(introSentence, Font, Brushes.Black, x, y);
        }
    }
}
