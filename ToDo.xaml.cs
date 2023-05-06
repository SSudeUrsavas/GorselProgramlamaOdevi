using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Görsel_Programlama_Ödev_1;

public partial class ToDo : ContentPage
{

    public ToDo()
	{
		InitializeComponent();


        MyList.ItemsSource = liste;
    }

    public List<Madde> liste = new List<Madde>() {
            new Madde() { ID = "0", Yeni = "Yapılacak"},
            new Madde() {ID = "1", Yeni = "Yappppp"}
            };
    public class Madde: INotifyPropertyChanged
    {
        public string ID
        {
            get
            {
                if (id == null)
                    id = Guid.NewGuid().ToString();

                return id;
            }
            set { id = value; }
        }

        string id, eklenen;
		public string Yeni { get => eklenen; set { eklenen = value; NotifyPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }

    
    public Madde Yeni { get; set; }


    private void ekle_Clicked(object sender, EventArgs e)
    {

        if (Yeni == null)
        {
            Yeni = new Madde(){ Yeni = e1.Text };
            liste.Add(Yeni);                     //listeye eklememe rağmen çalıştığında listeye eklemiyor
        }
    }

    private async void sil_Clicked(object sender, EventArgs e)
    {
        var but = sender as ImageButton;
        if (but != null)
        {
            var id = but.CommandParameter.ToString();    //parametre null döndürüyor hatası
            var user = liste.Single(o => o.ID == id);

            var res = await DisplayAlert("Silmeyi onayla", $"'{user.Yeni}' silinsin mi?", "EVET", "HAYIR");
            if (res)
                liste.Remove(user);
        }
    }
}
