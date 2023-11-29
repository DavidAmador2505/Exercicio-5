namespace exec_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Maneira complicada
             * textBox3.Text = textBox2.Text;
            textBox2.Text = textBox1.Text;
            textBox1.Text = textBox3.Text;
            textBox3.Text = "";*/
           
            //Maneira façil
            string nome1 = textBox1.Text;
            string nome2 = textBox2.Text;

            textBox1.Text = nome2;
            textBox2.Text = nome1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome1 = textBox1.Text;
            string nome2 = textBox2.Text; 

            textBox3.Text = nome1 + " " + nome2;
        }

    }
}