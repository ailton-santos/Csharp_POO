namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // o texto do label ser� alterado
            // todo toque ser� respeitado
            //label1.Text = "Ol�, " + textBox1.Text + " ! Seja Bem-vindo(a) ao C# :)";

            label1.Text = "Seu nome �: "+ textBox1.Text + " " + textBox2.Text;   
        }
    }
}
