using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using PMS.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using static System.Net.WebRequestMethods;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PMS.Controls
{
    public sealed partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            this.InitializeComponent();
        }

        private void NavigationViewControl_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {          
                      
            if (args.InvokedItemContainer  == ProjectsNavItem)
            {
                ContentFrame.Navigate(typeof(AllProjectsPage), args.RecommendedNavigationTransitionInfo);
            }

        
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(ProfilePage));
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
