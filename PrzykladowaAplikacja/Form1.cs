namespace PrzykladowaAplikacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StudencilistBox1.ValueMember = 'Nazwisko";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("To jest jakieœ info");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To jest jakieœ info");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student nowyStudent = new Student();
            nowyStudent.Imie = ImietextBox2.Text;
            nowyStudent.Nazwisko = NazwiskotextBox3.Text;
            StudencilistBox1.Items.Add(nowyStudent);
        }
    }
}