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
using System.IO;

namespace TocchioMaratonaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        Maratone maratone;

        public MainWindow()
        {
            InitializeComponent();
            maratone = new Maratone();
            DgElencoMaratone.ItemsSource = maratone.elencoMaratone;
        }

        private void BtnLeggiDaFile_Click(object sender, RoutedEventArgs e)
        {
            maratone.LeggiDati();
            DgElencoMaratone.Items.Refresh();
        }

       

       

        private void BtnDurata_Click(object sender, RoutedEventArgs e)
        {
            string durata = maratone.CalcolaDurata();
            LblNumMaratone.Content = durata;
        }
    }
}

