using ModernWpf.Controls;
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
using System.Windows.Shapes;

namespace Fluent_Android_Helper.Function_Views
{
    /// <summary>
    /// Flash.xaml 的交互逻辑
    /// </summary>
    public partial class Flash : Window
    {
        public Flash()
        {
            InitializeComponent();
        }
        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            /* You can also add items in code.
            NavView.MenuItems.Add(new NavigationViewItemSeparator());
            NavView.MenuItems.Add(new NavigationViewItem
            {
                Content = "My content",
                Icon = new SymbolIcon((Symbol)0xF1AD),
                Tag = "content"
            });
            _pages.Add(("content", typeof(MyContentPage)));*/

            NavView_Navigate("home");

        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var navItemTag = args.InvokedItemContainer.Tag.ToString();
            NavView_Navigate(navItemTag);
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var navItemTag = args.SelectedItemContainer.Tag.ToString();
            NavView_Navigate(navItemTag);

        }

        private void NavView_Navigate(string navItemTag)
        {
            /*还没做好
            if (navItemTag == "home") ContentFrame.Navigate(new Function());
            else if (navItemTag == "manage") ContentFrame.Navigate(new ManageApps());
            //else if (navItemTag == "google") ContentFrame.Navigate(new FreezeGoogle());
            */
        }
    }
}
