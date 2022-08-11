namespace ControlDeMultas
{
    public partial class Form1 : Form
    {

        ListViewItem nose;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lblFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblHora.Text = DateTime.Now.ToString("hh : mm");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int velocidad = Convert.ToInt32(txtVelocidad.Text);
            String placa = txtPlaca.Text;
            int multa = 0;

            if (velocidad <= 70)
                multa = 0;
            else if (velocidad > 70 && velocidad <= 90)
                multa = 120;
            else if (velocidad > 90 && velocidad < 100)
                multa = 120;
            else if (velocidad > 100)
                multa = 350;


            ListViewItem lista = new ListViewItem();

            lista.SubItems.Add(lblFecha.Text);
            lista.SubItems.Add(lblHora.Text);
            lista.SubItems.Add(velocidad.ToString());
            lista.SubItems.Add(multa.ToString());
            lvMultas.Items.Add(lista);


            
        }

        private void lvMultas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvMultas_MouseClick(object sender, MouseEventArgs e)
        {
            nose = lvMultas.GetItemAt(e.X,e.Y);
        }

        private void deleteAll()
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (nose != null)
            {
                lvMultas.Items.Remove(nose);
                MessageBox.Show("ta bien");
            }
            else
                MessageBox.Show("debe seleccionar una multa");
        }
    }
}