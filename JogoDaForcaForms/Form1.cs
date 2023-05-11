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
                palpite = Convert.ToChar(btn.Text);

            ganhou = forca.JogadorAcertou(palpite);

            trocarImagem();

            if (forca.JogadorPerdeu())
                Recomecar();

            if (ganhou)
                Recomecar();

            caixaPalavra.Text = forca.PalavraParcial;
        }

        private void Recomecar()
        {
            this.forca = new Forca();
            imagemForca.Image = Properties.Resources.corpoInteiro;
        }

        private void caixaPalavra_TextChanged(object sender, EventArgs e)
        {

        }

        private void imagem_Click(object sender, EventArgs e)
        {


        }

        private void trocarImagem()
        {
            if (forca.Erros == 1)
                imagemForca.Image = Properties.Resources.semPerna;

            else if (forca.Erros == 2)
                imagemForca.Image = Properties.Resources.SemUmbraco;

            else if (forca.Erros == 3)
                imagemForca.Image = Properties.Resources.semDoisBracos;

            else if (forca.Erros == 4)
                imagemForca.Image = Properties.Resources.SemCorpo;

            else if (forca.Erros == 5)
                imagemForca.Image = Properties.Resources.Morto;
        }

        private void botaoReset_Click(object sender, EventArgs e)
        {
            Recomecar();
        }
    }
}