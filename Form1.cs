namespace otobüs_bileti_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label11.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label11.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("GÜZERGAH: " + comboBox1.Text + " - " + comboBox2.Text + "  TARİH VE SAAT: " + dateTimePicker1.Text + " - " + comboBox4.Text + "  AD SOYAD: " + textBox1.Text + " - " + textBox2.Text); 
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}