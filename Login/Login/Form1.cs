namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String user = tbxUser.Text;
            String senha = tbxSenha.Text;
            // Operador && (E l�gico condicional)
            // Retorna true somente se ambas as express�es forem verdadeiras.
            // Exemplo: condi��o1 && condi��o2
            // - Se condi��o1 for false, condi��o2 nem � avaliada (short-circuit).
            // - Usado para verificar m�ltiplas condi��es ao mesmo tempo.
            // Exemplo pr�tico:
            if (user == "batata" && senha == "1234")
            {
                F_inicio janela = new F_inicio();
                janela.Show();    
            }
            else
            {
                MessageBox.Show("Usu�rio ou Senha incorreta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*
            if (user == "batata")
            {
                if (senha == "1234")
                {
                    F_inicio janela = new F_inicio();
                    janela.Show();
                }
                else 
                {
                    MessageBox.Show("Senha incorreta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User incorreto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

        }
    }
}
