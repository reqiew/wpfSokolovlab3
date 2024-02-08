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

namespace wpfSokolovlab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void but1_Click(object sender, RoutedEventArgs e)
        {
            Fraction f1 = new Fraction()
            {
                First = long.Parse(b1.Text),
                Second = ushort.Parse(b3.Text)
            };
            Fraction f2 = new Fraction()
            {
                First = long.Parse(b2.Text),
                Second = ushort.Parse(b4.Text)
            };
            Fraction res = f1 + f2;
            Res.Text = res.ToString();
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            Fraction f1 = new Fraction()
            {
                First = long.Parse(b1.Text),
                Second = ushort.Parse(b3.Text)
            };
            Fraction f2 = new Fraction()
            {
                First = long.Parse(b2.Text),
                Second = ushort.Parse(b4.Text)
            };
            Fraction res = f1 - f2;
            Res.Text = res.ToString();
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            Fraction f1 = new Fraction()
            {
                First = long.Parse(b1.Text),
                Second = ushort.Parse(b3.Text)
            };
            Fraction f2 = new Fraction()
            {
                First = long.Parse(b2.Text),
                Second = ushort.Parse(b4.Text)
            };
            Fraction res = f1 * f2;
            Res.Text = res.ToString();
        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            Fraction f1 = new Fraction()
            {
                First = long.Parse(b1.Text),
                Second = ushort.Parse(b3.Text)
            };
            Fraction f2 = new Fraction()
            {
                First = long.Parse(b2.Text),
                Second = ushort.Parse(b4.Text)
            };

            Fraction res = f1 / f2;
            Res.Text = res.ToString();


        }
        private void but5_Click(object sender, RoutedEventArgs e)
        {
            Fraction f1 = new Fraction()
            {
                First = long.Parse(b1.Text),
                Second = ushort.Parse(b3.Text)
            };
            Fraction f2 = new Fraction()
            {
                First = long.Parse(b2.Text),
                Second = ushort.Parse(b4.Text)
            };
            if (f1.First == f2.First && f1.Second == f2.Second)
            {
                Res.Text = "они равны".ToString();
            }
            else Res.Text = "они не равны".ToString();
        }
    }
}