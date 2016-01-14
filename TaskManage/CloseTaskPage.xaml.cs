using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// CloseTaskPage.xaml 的交互逻辑
    /// </summary>
    public partial class CloseTaskPage : Page
    {
        public CloseTaskPage()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            CloseTask();
        }

        private void CloseTask()
        {
            int pid = int.Parse(pidBox.Text);
            try
            {          
                Process p = Process.GetProcessById(pid);
                p.Kill();
                resultBlock.Text = "程序" + p.ProcessName + "关闭成功";
            }

            catch(Exception e)
            {
                resultBlock.Text = "程序ID为" + pid + "的程序关闭失败。失败原因：" + e.Message + "请重试";
            }

            finally
            {
                pidBox.Text = "";
            }
            

        }
    }
}
