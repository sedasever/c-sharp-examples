namespace Constructor_Ornek_Sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Sinema salon;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                salon = new Sinema(textBox1.Text, int.Parse(textBox2.Text));
                label3.Text = "Yeni Bir Salon Olu�turuldu.";
            }
            catch (Exception)
            {

                label3.Text = "Hay aksi.. Bir �eyler ters gitti...";
            }
            
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            salon.BiletSat(checkBox1.Checked);
            label3.Text = $"Bilet sat�ld�.. {salon.BosKoltukMetot()} adet koltuk kald�.";
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            salon.BiletIptal(checkBox1.Checked);
            label3.Text = "Bilet �ptal";
        }

        private void btnHasilat_Click(object sender, EventArgs e)
        {
            label3.Text = $"Mevcut Bakiyen: {salon.HasilatOgrenmeMetodu()}";
        }

        private void btnKoltuk_Click(object sender, EventArgs e)
        {
            label3.Text = $"Bo� koltuk say�s� {salon.BosKoltukMetot()}";
        }
    }
}