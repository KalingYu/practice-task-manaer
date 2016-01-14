using System.Windows.Controls;
using System.Data;
using System.Diagnostics;
using System.Management;
using System.Collections.ObjectModel;

namespace TaskManage
{
    /// <summary>
    /// BrowseTaskPage.xaml 的交互逻辑
    /// </summary>
    public partial class BrowseTaskPage : Page
    {
        public BrowseTaskPage()
        {
            InitializeComponent();
            ShowTasks();
        }

        public void ShowTasks()
        {
            DataTable data = new DataTable("tasks");
            data.Columns.Add(new DataColumn("pid", typeof(int)));
            data.Columns.Add(new DataColumn("name", typeof(string)));
            data.Columns.Add(new DataColumn("start", typeof(string)));
            data.Columns.Add(new DataColumn("priority", typeof(int)));
            data.Columns.Add(new DataColumn("memory", typeof(long)));
            data.Columns.Add(new DataColumn("user", typeof(string)));

            

            //获取操作系统进程信息
            Process[] processes = Process.GetProcesses();
            ObservableCollection<Task> memberData = new ObservableCollection<Task>();
            foreach (Process p in processes)
            {
                
                memberData.Add(new Task()
                {
                    pid = p.Id,
                    name = p.ProcessName,
                    start = p.Responding.ToString(),
                    priority = p.BasePriority,
                    memory = p.WorkingSet64,
                    user = GetProcessUserName(p.Id)
                });
                dataGrid.DataContext = memberData;

            }
        }

        private static string GetProcessUserName(int pID)
        {
            string text1 = null;

            SelectQuery query1 = new SelectQuery("Select * from Win32_Process WHERE processID=" + pID);
            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher(query1);

            try
            {
                foreach (ManagementObject disk in searcher1.Get())
                {
                    ManagementBaseObject inPar = null;
                    ManagementBaseObject outPar = null;

                    inPar = disk.GetMethodParameters("GetOwner");

                    outPar = disk.InvokeMethod("GetOwner", inPar, null);

                    text1 = outPar["User"].ToString();
                    break;
                }
            }
            catch
            {
                text1 = "SYSTEM";
            }

            return text1;
        }

    }
}
