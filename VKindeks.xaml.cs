namespace Görsel_Programlama_Ödev_1;

public partial class VKindeks : ContentPage
{
	public VKindeks()
	{
		InitializeComponent();
	}

    private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		var s = sender as Slider;
		entry1.Text = s.Value.ToString("F0");
    }

    private void slider2_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var s = sender as Slider;
        entry2.Text = s.Value.ToString("F0");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        double kilo = slider1.Value;
        double boy = (slider2.Value)/100;
        double sonuc = kilo / (boy * boy);
        
        if(sonuc < 16) { label.Text = "İleri düzeyde zayıfsınız."; }

        if (sonuc < 16.99 && sonuc > 16.01) { label.Text = "Orta düzeyde zayıfsınız."; }

        else if (sonuc < 18.49 && sonuc > 17) { label.Text = "Hafif düzeyde zayıfsınız."; }

        else if (sonuc < 24.9 && sonuc > 18.50) { label.Text = "Normal kilolusunuz."; }

        else if (sonuc < 29.99 && sonuc > 25) { label.Text = "Hafif şişman / fazla kilolusunuz."; }

        else if (sonuc < 34.99 && sonuc > 30) { label.Text = "1.derecede obezsiniz."; }

        else if (sonuc < 39.99 && sonuc > 35) { label.Text = "2.derecede obezsiniz."; }

        else if (sonuc > 40) { label.Text = "3.derecede obezsiniz."; }

        son.Text = sonuc.ToString("F2");
    }
}