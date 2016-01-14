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

namespace TaskManage
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            initFrame();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string choice = btn.Content.ToString();
            switch (choice)
            {
                case "浏览进程":
                    OpenBrowseTaskPage();
                    break;
                case "添加进程":
                    OpenAddTaskPage();
                    break;
                case "关闭进程":
                    OpenCloseTaskPage();
                    break;

            }


        }

        private void OpenBrowseTaskPage()
        {
            Brush brush = new SolidColorBrush(Color.FromRgb(7, 136, 209));
            btn_Browse.Background = brush;

            brush = new SolidColorBrush(Color.FromRgb(204, 204, 204));
            btn_Add.Background = brush;
            btn_Close.Background = brush;

            frame.Source = new Uri("BrowseTaskPage.xaml", UriKind.Relative);
        }

        private void OpenAddTaskPage()
        {
            Brush brush = new SolidColorBrush(Color.FromRgb(7, 136, 209));
            btn_Add.Background = brush;

            brush = new SolidColorBrush(Color.FromRgb(204, 204, 204));
            btn_Browse.Background = brush;
            btn_Close.Background = brush;

            frame.Source = new Uri("AddTaskPage.xaml", UriKind.Relative);
        }

        private void OpenCloseTaskPage()
        {
            Brush brush = new SolidColorBrush(Color.FromRgb(7, 136, 209));
            btn_Close.Background = brush;

            brush = new SolidColorBrush(Color.FromRgb(204, 204, 204));
            btn_Browse.Background = brush;
            btn_Add.Background = brush;

            frame.Source = new Uri("CloseTaskPage.xaml", UriKind.Relative);
        }


        private void initFrame()
        {
            frame.Source = new Uri("BrowseTaskPage.xaml", UriKind.Relative);
            Brush brush = new SolidColorBrush(Color.FromRgb(7, 136, 209));
            btn_Browse.Background = brush;
        }

    }
}
