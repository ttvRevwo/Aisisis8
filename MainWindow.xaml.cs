using Linqmuvletek;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LinqmuveletekWPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    static List<Kuldetes> kudetesek = new List<Kuldetes>();
    public MainWindow()
    {
        InitializeComponent();
        Program.Beolvas("NASAmissions.txt");
        if (Program.kuldetesek.Count > 0)
            MessageBox.Show("Sikeres beolvasás.");
        else
            MessageBox.Show("Úgy tűnik, nem sikerült a beolvasás", "Figyelmeztetés!", MessageBoxButton.OK, MessageBoxImage.Warning);
        dgrKuldetesek.ItemsSource = Program.kuldetesek;
    }
}