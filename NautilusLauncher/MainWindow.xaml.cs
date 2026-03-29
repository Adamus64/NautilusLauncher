using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;

namespace NautilusLauncher
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // --- MENU ---
        private void MenuAddApp_Click(object sender, RoutedEventArgs e) => PridatAplikaci();
        private void MenuExit_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
        private void MenuChangeCredentials_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Změna údajů bude přidána později.");
        private void MenuAbout_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Nautilus Launcher v1.0");

        // --- TLAČÍTKA ---
        private void BtnAdd_Click(object sender, RoutedEventArgs e) => PridatAplikaci();
        private void BtnRun_Click(object sender, RoutedEventArgs e) => SpustitAplikaci();
        private void BtnEdit_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Úprava detailů bude přidána později.");

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

        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsLoaded) { /* Logika řazení přijde sem */ }
        }

        private void AppListView_MouseDoubleClick(object sender, MouseButtonEventArgs e) => SpustitAplikaci();

        // --- HLAVNÍ FUNKCE ---
        private void PridatAplikaci()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Spustitelné soubory (*.exe)|*.exe|Všechny soubory (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                AppListView.Items.Add(new AppItem
                {
                    AppName = Path.GetFileNameWithoutExtension(openFileDialog.FileName),
                    FilePath = openFileDialog.FileName
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

    // --- TŘÍDA PRO POLOŽKU V SEZNAMU ---
    public class AppItem
    {
        public string AppName { get; set; }
        public string FilePath { get; set; }
    }
}