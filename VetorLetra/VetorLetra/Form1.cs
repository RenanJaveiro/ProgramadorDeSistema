namespace VetorLetra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            String palavra = tbxPalavra.Text;
            String letra   = tbxLetra.Text;

            //int i;//Inicializa��o
            String frase = "N�o encontrou";
            String Posicao = "";
            //condi��o
            for (int i = 0; i < palavra.Length; i++)
            {
                if (letra[0] == palavra[i])
                {
                    frase = "Encontou na posi��o:";
                    Posicao += $" {(i+1).ToString()}";
                }

            }
            lblResultado.Visible = true;
            lblResultado.Text = $"{frase}{Posicao}";
        }
    }
}
