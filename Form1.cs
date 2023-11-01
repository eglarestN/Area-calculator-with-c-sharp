namespace Geometri_Hesaplayıcı
{
    public partial class Form1 : Form
    {

        private void button1_Click(object sender, EventArgs e)
        {
            int kareKenarUzunluk = Convert.ToInt32(textBoxKareKenar.Text);
            int KareAlan = kareKenarUzunluk * kareKenarUzunluk;
            labelKare.Text = KareAlan.ToString();

            int kisaKenarUzunluk = Convert.ToInt32(textBoxKisaKenar.Text);
            int uzunKenarUzunluk = Convert.ToInt32(textBoxUzunKenar.Text);
            int DikdortgenAlan = kisaKenarUzunluk * uzunKenarUzunluk;
            labelDikdortgen.Text = DikdortgenAlan.ToString();

            double pi = 3.14;
            double daireCap = Convert.ToInt32(textBoxYariCap.Text);
            double daireAlan = (Math.Pow(daireCap, 2)) * pi;
            labelDaire.Text = daireAlan.ToString();
        }
    }
}