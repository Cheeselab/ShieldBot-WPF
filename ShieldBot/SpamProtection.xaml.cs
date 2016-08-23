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

namespace ShieldBot
{
    /// <summary>
    /// Interaction logic for SpamProtection.xaml
    /// </summary>
    public partial class SpamProtection : UserControl
    {
        public SpamProtection()
        {
            InitializeComponent();
        }

        private void spamSettingsClick(object sender, RoutedEventArgs e)
        {

        }

        private void whiteDeleteClick(object sender, RoutedEventArgs e)
        {
            while (whiteList.SelectedItems.Count > 0)
            {
                whiteList.Items.Remove(whiteList.SelectedItem);
            }
        }

        private void whiteAddClick(object sender, RoutedEventArgs e)
        {
            string whiteText = whiteNew.Text.Trim();
            if (String.IsNullOrEmpty(whiteNew.Text))
            {
                MessageBox.Show("Data empty, please add a URL");
            }

            else if (whiteList.Items.Contains(whiteText))
            {
                MessageBox.Show("Link already in list, can't add duplicate!");
                whiteNew.Clear();
            }

            else
            {
                whiteList.Items.Add(whiteNew.Text);
                whiteNew.Clear();
            }
        }

        private void blackDeleteClick(object sender, RoutedEventArgs e)
        {
            while (blackList.SelectedItems.Count > 0)
            {
                blackList.Items.Remove(blackList.SelectedItem);
            }
        }

        private void blackAddClick(object sender, RoutedEventArgs e)
        {
            string blackText = blackNew.Text.Trim();
            if (String.IsNullOrEmpty(blackNew.Text))
            {
                MessageBox.Show("No entry detected. Please try again.");
            }

            else if (blackList.Items.Contains(blackText))
            {
                MessageBox.Show("Blacklisted item already in list, can't add duplicate!");
                blackNew.Clear();
            }

            else
            {
                blackList.Items.Add(blackNew.Text);
                blackNew.Clear();
            }
        }

        private void nameDeleteClick(object sender, RoutedEventArgs e)
        {
            while (nameList.SelectedItems.Count > 0)
            {
                nameList.Items.Remove(nameList.SelectedItem);
            }
        }

        public void nameAddClick(object sender, RoutedEventArgs e)
        {
            string nameText = nameNew.Text.Trim();
            if (String.IsNullOrEmpty(blackNew.Text))
            {
                MessageBox.Show("No entry detected. Please try again.");
            }

            else if (nameList.Items.Contains(nameText))
            {
                MessageBox.Show("Blacklisted item already in list, can't add duplicate!");
                nameNew.Clear();
            }

            else
            {
                nameList.Items.Add(nameNew.Text);
                nameNew.Clear();
            }
        }
    }
}
