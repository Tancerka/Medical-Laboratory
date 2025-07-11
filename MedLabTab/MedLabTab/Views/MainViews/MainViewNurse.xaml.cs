﻿
using System.Windows;
using System.Windows.Controls;
using MedLabTab.Views;
using MedLabTab.Views.OtherViews;
using System.Linq;
using MedLabTab.DatabaseModels;
using System.Collections.ObjectModel;
using MedLabTab.ViewModels;

namespace MedLabTab.Views.MainViews
{
    public partial class MainViewNurse : Window
    {
        private SignedInUser currentUser;
        public MainViewNurse(SignedInUser user)
        {
            InitializeComponent();
            currentUser = user;

        }
        private void BtnExams_Click(object sender, RoutedEventArgs e)
        {
            AllVisitsAdmin allVisits = new AllVisitsAdmin(currentUser);
            allVisits.Show();
            this.Hide();
        }

        private void BtnSamples_Click(object sender, RoutedEventArgs e)
        {
            SamplesNurse samples = new SamplesNurse(currentUser);
            samples.Show();
            this.Hide();
        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile(currentUser, this);
            profile.Show();
            this.Hide();
        }
        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wylogowanie",
                                       MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                var loginWindow = new Login();
                loginWindow.Show();
                this.Close();
            }
        }
    }
}