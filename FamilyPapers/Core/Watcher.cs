using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FamilyPapers.Core
{
    public class Watcher
    {
        public void Cosik()
        {
            FileSystemWatcher watch = new FileSystemWatcher();
            
            watch.Path = @"c:\Users\PetLahev\Downloads\";
            watch.Filter = "*.*";
            //watch.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watch.Changed += Watch_Changed;
            watch.Created += Watch_Created;
            watch.Renamed += Watch_Renamed;
            watch.EnableRaisingEvents = true;
        }

        private void Watch_Renamed(object sender, RenamedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(e.FullPath, "Renamed");
        }

        private void Watch_Created(object sender, FileSystemEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(e.FullPath, "Created");
        }

        private void Watch_Changed(object sender, FileSystemEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(e.FullPath, "Changed");
        }

        public void WriteBytes()
        {
            string file = @"c:\Users\PetLahev\Downloads\test.png";
            byte[] bytes = File.ReadAllBytes(file);            
            File.WriteAllBytes(@"c:\Users\PetLahev\Downloads\testConverted.byt", bytes );            
        }

        public void ReadBytes()
        {
            string file = @"c:\Users\PetLahev\Downloads\testConverted.byt";
            byte[] bytes = File.ReadAllBytes(file);
            File.WriteAllBytes(@"c:\Users\PetLahev\Downloads\testBack.png", bytes);
        }

    }
}
