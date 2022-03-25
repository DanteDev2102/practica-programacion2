namespace practica_programacion2
{
    public partial class Form1 : Form
    {
        private double aumento;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_noHijos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_noHijos.Checked) aumento = 0;

        }

        private void radioButton_unHijo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_unHijo.Checked) aumento = 0.15;

        }

        private void radioButton_dosHijos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_dosHijos.Checked) aumento = 0.25;

        }

        private void radioButton_masDosHijos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_masDosHijos.Checked) aumento = 0.35;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sueldoActual = Convert.ToDouble(textBox3.Text);
                if (sueldoActual == 0) throw new Exception();
                double nuevoSueldo = sueldoActual + (sueldoActual * aumento);
                textBox4.Text = nuevoSueldo.ToString();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            radioButton_noHijos.Checked = false;
            radioButton_unHijo.Checked = false;
            radioButton_dosHijos.Checked = false;
            radioButton_masDosHijos.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }
    }
}