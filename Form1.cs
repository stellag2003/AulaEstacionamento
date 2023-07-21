namespace AulaEstacionamento
{

    public partial class Form1 : Form
    {

        List<string> Carros = new List<string>();
        List<int> quantidade = new List<int>();


        public Form1()
        {
            InitializeComponent();
        }


        void addCarro()
        {
            if (txtPlaca.Text == "")
            {
         
                MessageBox.Show("Digite uma placa para continuar");
            }
            else
            {
                string carros = txtPlaca.Text;
                Carros.Add(txtPlaca.Text);

                int quantidade1 = int.Parse(lblVeiculos.Text);
                quantidade.Add(quantidade1);
                

            }


        }



        void addLista()
        {
           if(Carros.Count >= 5) 
           {
                MessageBox.Show("Ta cheio");
                return;

           }

            else
            {
                string placa = txtPlaca.Text;
                Carros.Add(placa);

                lblVeiculos.Text = Carros.Count.ToString();

                    listView.Items.Clear();
                for (int i = 0; i < Carros.Count; i++)
                {
                    listView.Items.Add($"[VAGA {i} - {Carros[i]} ]");
                }

            }
           

            
                
        }

        void retirarCarro()
        {
            if (txtPlaca.Text == "")
            {

                MessageBox.Show("Digite uma placa para continuar");
            }
            else
            {
                string carros = txtPlaca.Text;
                Carros.Remove(carros);
            }
        }

         

            private void btnEstacionar_Click(object sender, EventArgs e)
            {
                 addCarro();
                 addLista();
            }
        

        private void btnEstacionar1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            retirarCarro();
        }
    } 
}