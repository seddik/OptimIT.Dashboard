using OptimIT.Dashboard;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Widgets;

namespace WpfDashboardControl
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            b_add.Click += B_add_Click;
            b_edit.Click += B_edit_Click;
            d_host.ItemsSource = new ObservableCollection<WidgetBase>();

            WindowState = WindowState.Maximized;
        }

        private void B_edit_Click(object sender, RoutedEventArgs e)
        {
            d_host.EditMode = !d_host.EditMode;

            if (d_host.EditMode)
                d_host.FillCanvasEditingBackground();
        }

        private void B_add_Click(object sender, RoutedEventArgs e)
        {
            (d_host.ItemsSource as ObservableCollection<WidgetBase>).Add(new CardWidgetVM());
        }


    }
}
