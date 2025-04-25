namespace viagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String destino = cbxDestino.Text;
            int diarias;
            double total;

            if (!int.TryParse(tbxDiarias.Text, out diarias) || diarias <= 0)
            {
                MessageBox.Show("Por favor, digite um n�mero inteiro v�lido para as di�rias.", "Entrada inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxDiarias.Clear();
                return; // Encerra o m�todo se a entrada for inv�lida
            }

            if (destino == "S�o Paulo")
            {
                total = 1000 + diarias * 200;
            }
            else if (destino == "Londres")
            {
                total = 4300 + diarias * 1900;
            }
            else
            {
                total = 5000 + diarias * 900;
            }

            MessageBox.Show($"Seu destino para {destino} ter� o custo de {total} de Passagem e Diarias de Hotel!", "Total de custo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }
    }
}
