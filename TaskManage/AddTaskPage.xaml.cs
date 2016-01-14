using System.Windows;
using System.Windows.Controls;
using System.Management;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System;

namespace TaskManage
{
    /// <summary>
    /// AddTaskPage.xaml 的交互逻辑
    /// </summary>
    public partial class AddTaskPage : Page
    {
        public AddTaskPage()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            OpenNewProcess();
        }

        private void OpenNewProcess()
        {
            try
            {
                string task = taskBox.Text;
                Process.Start(task);
                resultBlock.Text = "程序" + task + "启动成功";
                taskBox.Text = "";
            }
            catch(Exception e)
            {
                resultBlock.Text = "程序启动失败。" + e.Message + "请重试";
                taskBox.Text = "";
            }
        }
    }
}
