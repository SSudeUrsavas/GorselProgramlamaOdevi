namespace Görsel_Programlama_Ödev_1;

public partial class Renk : ContentPage
{
	public Renk()
	{
		InitializeComponent();
	}

    public void changeColor()
    {
        byte rr = (byte)s1.Value; //Retriving values from slider1
        byte gg = (byte)s2.Value; //Retriving values from slider2
        byte bb = (byte)s3.Value; //Retriving values from slider3
        Color cc = Color.FromRgb(rr, gg, bb); //Create object of Color class.
        SolidColorBrush colorBrush = new SolidColorBrush(cc);
        page.Background = colorBrush; //Setting background of stack panel.
        renk.Text = colorBrush.Color.ToHex();
    }



    private void Button_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Kopyalandı", renk.Text, "OK");
    }

    private void s1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        changeColor();
    }

    private void random_Clicked(object sender, EventArgs e)
    {
        Random r = new Random();

        Color color = Color.FromRgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        SolidColorBrush colorBrush = new SolidColorBrush(color);
        page.Background = colorBrush;
        renk.Text = colorBrush.Color.ToHex();
    }
}