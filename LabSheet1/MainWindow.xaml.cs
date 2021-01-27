using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabSheet1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Band> bands = new List<Band>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            RocBand b1 = new RocBand() { BandName = "Foo Fighters", year = 1994, Members = "Dave Grohl, Nate Mendel, Pat Smear,Taylor Hawkins,Chris Shiflett, Rami Jaffee" };
            RocBand b2 = new RocBand() { BandName = "The Rolling Stones", year = 1962, Members = "Mick Jagger, Keith Richards, Charlie Watts, Ronnie Wood" };

            PopBand b3 = new PopBand() { BandName = "The Beatles", year = 1960, Members = "John Lennon, Paul McCartney, George Harrison, Ringo Starr" };
            PopBand b4 = new PopBand() { BandName = "Green Day", year = 1986, Members = "	Billie Joe Armstrong,Mike Dirnt, Tré Cool" };

            IndieBand b5 = new IndieBand() { BandName = "Arctic Monkeys", year = 2002, Members = "Alex Turner, Jamie Cook, Nick O'Malley, Matt Helders" };
            IndieBand b6 = new IndieBand() { BandName = "The Strokes", year = 1998, Members = "	Julian Casablancas, Nick Valensi, Albert Hammond Jr., Nikolai Fraiture, Fabrizio Moretti" };


            Random rand = new Random();

            Album a1 = new Album() { AlbumName = "Greatest Hits", YearsOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };
            Album a2 = new Album() { AlbumName = "One by One", YearsOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };

            Album a3 = new Album() { AlbumName = "Beggars Banquet", YearsOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };
            Album a4 = new Album() { AlbumName = "Blue & Lonesome ", YearsOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };

            Album a5 = new Album() { AlbumName = "Let It Be ", YearsOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };
            Album a6 = new Album() { AlbumName = "Sgt. Pepper's Lonely Hearts Club Band", YearsOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };

            Album a7 = new Album() { AlbumName = "Dookie", YearsOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };
            Album a8 = new Album() { AlbumName = "American Idiot", YearsOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };

            Album a9 = new Album() { AlbumName = "Whatever People Say I Am, That's What I'm Not", YearsOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };
            Album a10 = new Album() { AlbumName = "Favourite Worst Nightmare", YearsOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };

            Album a11 = new Album() { AlbumName = "Room on Fire", YearsOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };
            Album a12 = new Album() { AlbumName = "The Modern Age", YearsOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };

            b1.AlbumList.Add(a1);
            b1.AlbumList.Add(a2);

            b2.AlbumList.Add(a3);
            b2.AlbumList.Add(a4);

            b3.AlbumList.Add(a5);
            b3.AlbumList.Add(a6);

            b4.AlbumList.Add(a7);
            b4.AlbumList.Add(a8);

            b5.AlbumList.Add(a9);
            b5.AlbumList.Add(a10);

            b6.AlbumList.Add(a11);
            b6.AlbumList.Add(a12);

           

            bands.Add(b1);
            bands.Add(b2);
            bands.Add(b3);
            bands.Add(b4);
            bands.Add(b5);
            bands.Add(b6);

            bands.Sort();
            LstBox.ItemsSource = bands;
        }

        private void LstBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectedBand = LstBox.SelectedItem as Band;

            if (selectedBand != null)
            {
                AlbumLBox.ItemsSource = selectedBand.AlbumList;

                BandInfoTxtBlk.Text = string.Format($"{selectedBand.year}" + $"\nMembers: {selectedBand.Members}");
            }
        }
    }
}
