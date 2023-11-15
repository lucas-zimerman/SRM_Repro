using System;
using System.Collections.Generic;
using System.ComponentModel;
using SRM_Repro2.Models;
using SRM_Repro2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SRM_Repro2.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}