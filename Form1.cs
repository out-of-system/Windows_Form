namespace Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Vasco da Gama");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstNames.Items.Add(txtName.Text);
            txtName.Text = "";

            //print na tela 
            MessageBox.Show("Convidado adicionado!");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lstNames.Items.Remove(lstNames.Text);
        }
    }
}
