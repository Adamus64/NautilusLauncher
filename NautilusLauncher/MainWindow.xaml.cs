// Adam Fiala | IV.C | Programování a vývoj aplikací | Nautilus Launcher |

using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.ComponentModel; 
using Microsoft.Win32;

namespace NautilusLauncher
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // MENU 
        private void MenuAddApp_Click(object sender, RoutedEventArgs e) => PridatAplikaci();
        private void MenuExit_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
        private void MenuChangeCredentials_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Změnu udájů jsem nestihl, gomenasai bankai 8. dýchácí forma ohnivý kruh.");
        private void MenuAbout_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Nautilus Launcher v1.0. By: Adam 'Adamus' Fiala 2026. One Piece je skutečný.");

        //  TLAČÍTKA 
        private void BtnAdd_Click(object sender, RoutedEventArgs e) => PridatAplikaci();
        private void BtnRun_Click(object sender, RoutedEventArgs e) => SpustitAplikaci();

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (AppListView.SelectedIndex != -1)
            {
                AppListView.Items.RemoveAt(AppListView.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Nejprve vyber aplikaci ze seznamu.", "Smazat");
            }
        }

      
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (AppListView.SelectedItem is AppItem selectedApp)
            {
                
                txtEditName.Text = selectedApp.AppName;
                txtEditIcon.Text = selectedApp.FilePath;
            }
            else
            {
                MessageBox.Show("Nejprve vyber aplikaci ze seznamu, kterou chceš upravit.", "Upravit");
            }
        }

       
        private void BtnSaveEdit_Click(object sender, RoutedEventArgs e)
        {
            if (AppListView.SelectedItem is AppItem selectedApp)
            {
               
                selectedApp.AppName = txtEditName.Text;
                selectedApp.FilePath = txtEditIcon.Text;

                AppListView.Items.Refresh();

                MessageBox.Show("Změny byly úspěšně uloženy.", "Uloženo");
            }
            else
            {
                MessageBox.Show("Není vybrána žádná aplikace k uložení.", "Chyba");
            }
        }

        
        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsLoaded && AppListView != null)
            {
                
                var view = System.Windows.Data.CollectionViewSource.GetDefaultView(AppListView.Items);
                view.SortDescriptions.Clear(); 

                if (CmbSort.SelectedIndex == 0) 
                {
                    view.SortDescriptions.Add(new SortDescription("AppName", ListSortDirection.Ascending));
                }
                else if (CmbSort.SelectedIndex == 1) 
                {
                    view.SortDescriptions.Add(new SortDescription("DateAdded", ListSortDirection.Descending));
                }
            }
        }

        private void AppListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) => SpustitAplikaci();

        
        private void PridatAplikaci()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Spustitelné soubory (*.exe)|*.exe|Všechny soubory (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                AppListView.Items.Add(new AppItem
                {
                    AppName = Path.GetFileNameWithoutExtension(openFileDialog.FileName),
                    FilePath = openFileDialog.FileName,
                    DateAdded = DateTime.Now 
                });
            }
        }

        private void SpustitAplikaci()
        {
            if (AppListView.SelectedItem is AppItem selectedApp)
            {
                try { Process.Start(selectedApp.FilePath); }
                catch (Exception ex) { MessageBox.Show("Chyba při spouštění: " + ex.Message); }
            }
            else
            {
                MessageBox.Show("Nejprve vyber aplikaci ze seznamu kliknutím.");
            }
        }
    }

   
    public class AppItem
    {
        public string AppName { get; set; }
        public string FilePath { get; set; }
        public DateTime DateAdded { get; set; } 
    }
}