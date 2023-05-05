namespace Görsel_Programlama_Ödev_1;

public partial class Kredi : ContentPage
{
	public Kredi()
	{
		InitializeComponent();
	}

    private void r1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        double kredi = Convert.ToDouble(tutar.Text);
        double faiz = Convert.ToDouble(oran.Text);
        double vadeay = Convert.ToDouble(vade.Text);

        double toplam, taksit, brutfaiz;

        brutfaiz = ((faiz + (faiz * 10) + (faiz * 15)) / 100);
        taksit = ((Math.Pow(1 + brutfaiz, vadeay) * brutfaiz) / (Math.Pow(1 + brutfaiz, vadeay) - 1)) * kredi;
        toplam = taksit * vadeay;

        aylıktaksit.Text = taksit.ToString("F2");
        toplamodeme.Text = toplam.ToString("F2");
        toplamfaiz.Text = brutfaiz.ToString("F2");
    }

    private void r2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        double kredi = Convert.ToDouble(tutar.Text);
        double faiz = Convert.ToDouble(oran.Text);
        double vadeay = Convert.ToDouble(vade.Text);

        double toplam, taksit, brutfaiz;

        brutfaiz = ((faiz + (faiz * 0) + (faiz * 0)) / 100);
        taksit = ((Math.Pow(1 + brutfaiz, vadeay) * brutfaiz) / (Math.Pow(1 + brutfaiz, vadeay) - 1)) * kredi;
        toplam = taksit * vadeay;

        aylıktaksit.Text = taksit.ToString("F2");
        toplamodeme.Text = toplam.ToString("F2");
        toplamfaiz.Text = brutfaiz.ToString("F2");
    }

    private void r3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        double kredi = Convert.ToDouble(tutar.Text);
        double faiz = Convert.ToDouble(oran.Text);
        double vadeay = Convert.ToDouble(vade.Text);

        double toplam, taksit, brutfaiz;

        brutfaiz = ((faiz + (faiz * 5) + (faiz * 15)) / 100);
        taksit = ((Math.Pow(1 + brutfaiz, vadeay) * brutfaiz) / (Math.Pow(1 + brutfaiz, vadeay) - 1)) * kredi;
        toplam = taksit * vadeay;

        aylıktaksit.Text = taksit.ToString("F2");
        toplamodeme.Text = toplam.ToString("F2");
        toplamfaiz.Text = brutfaiz.ToString("F2");
    }

    private void r4_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        double kredi = Convert.ToDouble(tutar.Text);
        double faiz = Convert.ToDouble(oran.Text);
        double vadeay = Convert.ToDouble(vade.Text);

        double toplam, taksit, brutfaiz;

        brutfaiz = ((faiz + (faiz * 5) + (faiz * 0)) / 100);
        taksit = ((Math.Pow(1 + brutfaiz, vadeay) * brutfaiz) / (Math.Pow(1 + brutfaiz, vadeay) - 1)) * kredi;
        toplam = taksit * vadeay;

        aylıktaksit.Text = taksit.ToString("F2");
        toplamodeme.Text = toplam.ToString("F2");
        toplamfaiz.Text = brutfaiz.ToString("F2");
    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var s = sender as Slider;
        vade.Text = s.Value.ToString("F0");

        double kredi = Convert.ToDouble(tutar.Text);
        double faiz = Convert.ToDouble(oran.Text);
        double vadeay = Convert.ToDouble(vade.Text);

        double toplam, taksit, brutfaiz;

        if(r1.IsChecked == true)
        {
            brutfaiz = ((faiz + (faiz * 10) + (faiz * 15)) / 100);
            taksit = ((Math.Pow(1 + brutfaiz, vadeay) * brutfaiz) / (Math.Pow(1 + brutfaiz, vadeay) - 1)) * kredi;
            toplam = taksit * vadeay;

            aylıktaksit.Text = taksit.ToString("F2");
            toplamodeme.Text = toplam.ToString("F2");
            toplamfaiz.Text = brutfaiz.ToString("F2");
        }

        if(r2.IsChecked == true)
        {
            brutfaiz = ((faiz + (faiz * 0) + (faiz * 0)) / 100);
            taksit = ((Math.Pow(1 + brutfaiz, vadeay) * brutfaiz) / (Math.Pow(1 + brutfaiz, vadeay) - 1)) * kredi;
            toplam = taksit * vadeay;

            aylıktaksit.Text = taksit.ToString("F2");
            toplamodeme.Text = toplam.ToString("F2");
            toplamfaiz.Text = brutfaiz.ToString("F2");
        }

        if(r3.IsChecked == true)
        {
            brutfaiz = ((faiz + (faiz * 5) + (faiz * 15)) / 100);
            taksit = ((Math.Pow(1 + brutfaiz, vadeay) * brutfaiz) / (Math.Pow(1 + brutfaiz, vadeay) - 1)) * kredi;
            toplam = taksit * vadeay;

            aylıktaksit.Text = taksit.ToString("F2");
            toplamodeme.Text = toplam.ToString("F2");
            toplamfaiz.Text = brutfaiz.ToString("F2");
        }

        if(r4.IsChecked == true)
        {
            brutfaiz = ((faiz + (faiz * 5) + (faiz * 0)) / 100);
            taksit = ((Math.Pow(1 + brutfaiz, vadeay) * brutfaiz) / (Math.Pow(1 + brutfaiz, vadeay) - 1)) * kredi;
            toplam = taksit * vadeay;

            aylıktaksit.Text = taksit.ToString("F2");
            toplamodeme.Text = toplam.ToString("F2");
            toplamfaiz.Text = brutfaiz.ToString("F2");
        }
    }
}