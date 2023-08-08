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
using Windows.UI.Popups;
using Microsoft.UI;
using System.Runtime.InteropServices;
using System.Threading;

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


        private void ShowMoreButton_Click(object sender, RoutedEventArgs e)
        {
            // Create the content you want to display in the flyout (e.g., a ListView)
            ListView listView = new ListView();

            
            // Add your options/items to the ListView

            // Create the Flyout and set its content
            Flyout flyout = new Flyout();
            flyout.Content = listView;

            // Show the Flyout anchored to the "Show More" button
            flyout.ShowAt(sender as FrameworkElement);
        }

    }
}
