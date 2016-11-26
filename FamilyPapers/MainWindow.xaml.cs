using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace FamilyPapers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Core.Asset[] assets = { new Core.Asset() { Name = "Muj skvely soubor", Id = "MIS_Cosik", Tracked = true, Thumbnail = "Resources/file_bmp_image.png" },
                                    new Core.Asset() { Name = "Elcin", Id = "BILLS_Hracky", Tracked = true, Thumbnail = "Resources/file_png_image.png" },
                                    new Core.Asset() { Name = "Tomasuv", Id = "CONTRACT", Tracked = false, Thumbnail = "Resources/file_pdf_acrobat.png" },
                                    };
            this.lbAssets.ItemsSource = assets;
            
        }

        private void btnChoosePath_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dg = new FolderBrowserDialog();
            dg.ShowDialog();

            if (dg.SelectedPath == null) return;
            watchPath.Text = dg.SelectedPath;
            Properties.Settings.Default["WatchFolder"] = watchPath.Text;
            Properties.Settings.Default.Save();
            
            

        }
    }
}
