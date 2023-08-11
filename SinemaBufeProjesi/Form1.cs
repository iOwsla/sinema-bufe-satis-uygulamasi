namespace SinemaBufeProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double kasaToplam = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int MisirFiyat = 4;
            int SuFiyat = 1;
            int CayFiyat = 2;
            int BiletFiyat = 8;

            int MisirAdet = Convert.ToInt32(txtMisir.Text);
            int SuAdet = Convert.ToInt32(txtSu.Text);
            int CayAdet = Convert.ToInt32(txtCay.Text);
            int BiletAdet = Convert.ToInt32(txtBilet.Text);

            double toplam = (MisirAdet * MisirFiyat) + (SuAdet * SuFiyat) + (CayAdet * CayFiyat) + (BiletAdet * BiletFiyat);
            kasaToplam = toplam + kasaToplam;
            lblToplamTutar.Text = "Toplam Tutar: " + kasaToplam + " ₺";

            lbUrunler.Items.Add($"Mısır Adet: {MisirAdet} ({MisirAdet * MisirFiyat} ₺) Su Adet: {SuAdet} ({SuAdet * SuFiyat} ₺)  Çay Adet: {CayAdet} ({CayAdet * CayFiyat} ₺)  Bilet Adet: {BiletAdet} ({BiletAdet * BiletFiyat} ₺) ");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMisir.Text = "";
            txtSu.Text = "";
            txtCay.Text = "";
            txtBilet.Text = "";
            kasaToplam = 0;
            lblToplamTutar.Text = "Toplam Tutar: " + kasaToplam + " ₺";
            lbUrunler.Items.Clear();
        }
    }
}