using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using PMS.ViewModels;
using PMS.Data;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PMS.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProjectListPage : Page
    {
        public ProjectListPage()
        {
            this.InitializeComponent();

            ViewModel = new ProjectListViewModel(new ProjectListDataProvider());
            ProjectListGridView.Loaded += Root_Loaded;
        }

        private async void Root_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadProjectListAsync();
        }


        internal ProjectListViewModel ViewModel { get; }

        private void ProjectListGridView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ProjectListGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
