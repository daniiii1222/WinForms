using System.Reflection.Metadata;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TDni_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TApellido: solamente letras y espacios
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TDni: solamente números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TNombre: solamente letras y espacios
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TGuardar_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show(
                    "Debe Completar todos los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                DialogResult ask = MessageBox.Show(
                    "Seguro que desea insertar un nuevo Cliente?",
                    "Confirmar Insercion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show(
                       "El Cliente: " + textBox3.Text + " " + textBox2.Text + " se insertó correctamente",
                       "Guardar",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
   );
                }
            }

        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show(
           "Está apunto de eliminar el Cliente: " + textBox3.Text + " " + textBox2.Text,
           "Confirmar Eliminación",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Exclamation,
           MessageBoxDefaultButton.Button2
   );

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show(
                    "El Cliente: " + textBox3.Text + " " + textBox2.Text + " se eliminó correctamente",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                LModificar.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked)
            {
                pictureBox1.BackgroundImage = Properties.Resources.varon;
            }
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked)
            {
                pictureBox1.BackgroundImage = Properties.Resources.mujer;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
