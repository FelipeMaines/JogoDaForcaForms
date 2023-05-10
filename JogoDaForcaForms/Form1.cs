using System.Diagnostics.CodeAnalysis;

namespace JogoDaForcaForms
{
    public partial class Form1 : Form
    {
        public char palpite = ' ';

        public Forca forca = new Forca();
        public Form1()
        {
            InitializeComponent();

        }

        private void ObterPalpite(object sender, EventArgs e)
        {
            bool ganhou = false;

            if (sender is Button btn)
            {
                palpite = Convert.ToChar(btn.Text);
            }

            ganhou = forca.JogadorAcertou(palpite);

            caixaPalavra.Text = forca.PalavraParcial;

            if (forca.JogadorPerdeu())
            {
                this.forca = new Forca();
                caixaPalavra.Text = forca.PalavraParcial;
            }

            if(ganhou)
            {
                this.forca = new Forca();
                caixaPalavra.Text = forca.PalavraParcial;
            }
        }

        private void caixaPalavra_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}