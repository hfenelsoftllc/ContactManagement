﻿using Contacts.Maui.Views;

namespace Contacts.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //ContactPage = new AppShell();
        }
    }
}
