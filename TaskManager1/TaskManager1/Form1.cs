using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Threading;
using System.Management;
using Timer = System.Windows.Forms.Timer;

namespace TaskManager1
{
    
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        Process[] processList;
        private Thread cpuThread;
        private Thread pThread;
        private Thread ramThread;
        private double[] ramArray = new double[60];
        private double[] cpuArray = new double[60];
        
        string info;
        string s1;
        float s;
        PerformanceCounter C = new PerformanceCounter();
        
        private void getPerfCounters()
        {
            var cpuPerfCounter = new PerformanceCounter("Processor Information","% Processor Time","_Total");

            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);
                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);

                if (chart1.IsHandleCreated)
                    this.Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
                Thread.Sleep(500);
            }
        }
        private void getPerfCounters2()
        {
            var ramPerfCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");

            while (true)
            {
                ramArray[ramArray.Length - 1] = Math.Round(ramPerfCounter.NextValue(), 0);
                Array.Copy(ramArray, 1, ramArray, 0, ramArray.Length - 1);

                if (chart2.IsHandleCreated)
                    this.Invoke((MethodInvoker)delegate { UpdateRamChart(); });
                Thread.Sleep(500);
            }
        }
        private void UpdateCpuChart()
        {
            chart1.Series["CPU%"].Points.Clear();

            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                chart1.Series["CPU%"].Points.AddY(cpuArray[i]);
            }
        }
        private void UpdateRamChart()
        {
            chart2.Series["RAM%"].Points.Clear();

            for (int i = 0; i < ramArray.Length - 1; ++i)
            {
                chart2.Series["RAM%"].Points.AddY(ramArray[i]-8);
            }
        }
        public void loadProcessList()
        {
            listView1.Items.Clear();
            processList = Process.GetProcesses();
            /*var counters = new List<PerformanceCounter>();
            foreach (Process p in processList)
            {
                var counter = new PerformanceCounter("Process", "% Processor Time", p.ProcessName);
                counter.NextValue();
                counters.Add(counter);
            }
            Thread.Sleep(100);
            int i = 0;*/
            foreach (Process p in processList)
            {
                try
                {


                    //s1 = counters[i++].NextValue().ToString();
                    
                    ListViewItem item = new ListViewItem(new[] { p.ProcessName, p.Id.ToString(),(p.WorkingSet64/1000).ToString()+" k","0"});
                    item.Tag = p;
                    //Console.WriteLine(s1);
                    listView1.Items.Add(item);

                }
                catch { }
                
                //item.SubItems.Add(p.Id.ToString());
            }
          
        }
        public void updateProcessList()
        {
            //listView1.Items.Clear();

            /*var counters = new List<PerformanceCounter>();
            foreach (Process p in processList)
            {
                var counter = new PerformanceCounter("Process", "% Processor Time", p.ProcessName);
                counter.NextValue();
                counters.Add(counter);
            }
            Thread.Sleep(100);
            int i = 0;*/
            Process[] pnew = Process.GetProcesses();
            int i = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                try
                {
                    //s1 = counters[i++].NextValue().ToString();
                    Process p = Process.GetProcessById(int.Parse(item.SubItems[1].Text));
                    item.SubItems[2].Text = (p.WorkingSet64 / 1000).ToString() + " k" ;
                    //Console.WriteLine("da "+i++);
                }
                catch { }

                //item.SubItems.Add(p.Id.ToString());
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            string text = start.Text;
            Process.Start(text);
            loadProcessList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listView1.View = View.Details;
            loadProcessList();

            cpuThread = new Thread(new ThreadStart(this.getPerfCounters));
            cpuThread.IsBackground = true;
            cpuThread.Start();

            ramThread = new Thread(new ThreadStart(this.getPerfCounters2));
            ramThread.IsBackground = true;
            ramThread.Start();
            //info
            

            //os and cpu
            var wmi =
            new ManagementObjectSearcher("select * from Win32_OperatingSystem")
            .Get()
            .Cast<ManagementObject>()
            .First();

            var cpu =
            new ManagementObjectSearcher("select * from Win32_Processor")
            .Get()
            .Cast<ManagementObject>()
            .First();

            info += "OS Name:           " + ((string)wmi["Caption"]).Trim() + "\n" +
                    "OS Version:        " + (string)wmi["Version"] + "\n" +
                    "OS Architecture:   " + (string)wmi["OSArchitecture"] + "\n" +
                    "\n\n" +
                    "CPU Name:          " + ((string)cpu["Name"]).Replace("(TM)", "™")
                                                                   .Replace("(tm)", "™")
                                                                   .Replace("(R)", "®")
                                                                   .Replace("(r)", "®")
                                                                   .Replace("(C)", "©")
                                                                   .Replace("(c)", "©")
                                                                   .Replace("    ", " ")
                                                                   .Replace("  ", " ") + "\n"+
                    "CPU ID:            " + (string)cpu["ProcessorId"]+"\n"+
                    "CPU Socket:        " + (string)cpu["SocketDesignation"]+"\n"+
                    "CPU SpeedMHz:      " + ((uint)cpu["MaxClockSpeed"]).ToString() + "\n" +
                    "CPU BusSpeedMHz:   " + ((uint)cpu["ExtClock"]).ToString() + "\n" +
                    "CPU Cores:         " + ((uint)cpu["NumberOfCores"]).ToString() + "\n" +
                    "CPU Threads:       " + ((uint)cpu["NumberOfLogicalProcessors"]).ToString();
            //mem
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                info += "\n\n\nTotal Visible Memory:   " + result["TotalVisibleMemorySize"] +" KB\n";
                info += "Free Physical Memory: "+ result["FreePhysicalMemory"] + " KB\n";
                info += "Total Virtual Memory:   "+ result["TotalVirtualMemorySize"] + " KB\n";
                info += "Free Virtual Memory:    "+ result["FreeVirtualMemory"] + " KB\n";
            }
            
            C.CategoryName = "Process";
            C.CounterName = "% Processor Time";
            C.InstanceName = "";
            C.ReadOnly = true;
            label1.Text = info;
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = (2000) * (1);
            timer.Enabled = true;
            timer.Start();
            chart2.ChartAreas[0].AxisY.Maximum = 100;
        }

        private void timerTick(object sender, EventArgs e)
        {
            updateProcessList();
        }
        private void end_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            Process p = (Process)item.Tag;
            p.Kill();
            loadProcessList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateProcessList();
        }
    }
}
