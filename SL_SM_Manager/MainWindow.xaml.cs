﻿using System;
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

namespace SL_SM_Manager
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

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void continueButton_Click(object sender, RoutedEventArgs e)
        {
            if (faceBox.IsChecked==true)
            {
                Facebook fbook = new Facebook();
                fbook.Show();
            }

            if (snapBox.IsChecked == true)
            {
                Snapchat snap = new Snapchat();
                snap.Show();
            }

            if (twitBox.IsChecked == true)
            {
                Twitter twitter = new Twitter();
                twitter.Show();
            }


            if (hubBox.IsChecked == true)
            {
                Hub hub = new Hub();
                hub.Show();
            }

            if (markBox.IsChecked == true)
            {
                Marketing mark = new Marketing();
                mark.Show();
            }

            if (multBox.IsChecked == true)
            {
                Multiple mult = new Multiple();
                mult.Show();
            }
        }
    }
}
