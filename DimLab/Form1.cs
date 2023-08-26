using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Management;
using System.Diagnostics;
using System.Windows.Forms;

namespace DimLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            info_disk();
        }

        private void info_disk()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Volume");

            disk.Text = "";

            foreach (ManagementObject queryObj in searcher.Get())
            {

                //Console.WriteLine("-----------------------------------");
                //Console.WriteLine("Имя: {0}", queryObj["Caption"]);
                disk.Text += "Буква: " + queryObj["DriveLetter"] + "\n";
                disk.Text += ("Общий объем: " + Math.Round(System.Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024 / 1024, 2) + " Gb" + "\n");
                //Console.WriteLine("DriveType: {0}", queryObj["DriveType"]);
                //Console.WriteLine("FileSystem: {0}", queryObj["FileSystem"]);
                disk.Text += "Свободно: " + Math.Round(System.Convert.ToDouble(queryObj["FreeSpace"]) / 1024 / 1024 / 1024, 2) + " Gb \n" + "\n";

            }
        }

        private void buttom_disk_Click(object sender, EventArgs e)
        {
            info_disk();
        }

        private void services_CheckedChanged(object sender, EventArgs e)
        {
            if (services.Checked == true)
            {
                groupBox_services.Visible = true;
            }
            else
            {
                groupBox_services.Visible = false;
            }
        }

        private void view_dns_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c ipconfig /displaydns >\"%userprofile%\\Desktop\\DNScache.txt\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            });
            MessageBox.Show("Журнал DNS-кэша на рабочем столе");
        }

        private void clean_dns_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c ipconfig / flushdns",
            });
            MessageBox.Show("DNS-кэш очищен");
        }

        private void kill_services_Click(object sender, EventArgs e)
        {
            if (wmi.Checked == true)
            {
                Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/c net stop wmiApSrv",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                });
            } //Остановка Адаптер производительности WMI

            if (bio.Checked == true)
            {
                Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/c net stop WbioSrvc",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                });
            } //Остановка Биометрическая служба Windows

            if (smart_map.Checked == true)
            {
                Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/c net stop SCardSvr",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                });
            } //Остановка Смарт-карта

            if (fax.Checked == true)
            {
                Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/c net stop Fax",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                });
            } //Остановка Факс

            if (update.Checked == true)
            {
                Process process = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/c net stop wuauserv",
                   /* UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true*/
                });
            } //Остановка Центр обновления Windows
        }

        private void sxs_first_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c chcp 65001 & dism /online /cleanup-image /analyzecomponentstore",
            });
        }

        private void sxs_second_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c dism /online /cleanup-image /startcomponentcleanup /resetbase",
                // UseShellExecute = false,
                // CreateNoWindow = true,
                // RedirectStandardOutput = true
            });
        }

        private void cleanmgr_Click(object sender, EventArgs e)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c cleanmgr",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            });
        }

        private void clean_CheckedChanged(object sender, EventArgs e)
        {
            if (clean.Checked == true)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void regedit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\regedt32.exe");
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\hosts");
            //записать в него
            file.WriteLine("0.0.0.0 tns-counter.ru");
            file.WriteLine("\n0.0.0.0 love.mail.ru");
            file.WriteLine("\n0.0.0.0 xvideos.com");
            file.WriteLine("\n0.0.0.0 pornhub.com");
            file.WriteLine("\n0.0.0.0 rt.pornhub.com");
            file.WriteLine("\n0.0.0.0 store.steampowered.com");
            file.WriteLine("\n0.0.0.0 topface.com");
            file.WriteLine("\n0.0.0.0 znakomstva.ru");
            file.WriteLine("\n0.0.0.0 an.yandex.ru");
            file.WriteLine("\n 0.0.0.0 xnxx.com");
            file.WriteLine("\n 0.0.0.0 ebalovo.porn");
            file.WriteLine("\n 0.0.0.0 ukdevilz.com");
            file.WriteLine("\n 0.0.0.0 noodlemagazine.com");
            //закрыть для сохранения данных
            file.Close();
        }*/

        /* private void anti_update_Click(object sender, EventArgs e)
         {
             if (System.IO.File.Exists("C:\\F.bat")) // Проверка на существование файла
             {
                 MessageBox.Show("Файл уже создан");
             }
             else 
             {
                 System.IO.StreamWriter File = new System.IO.StreamWriter(@"C:\\F.bat"); // Создание файла
                 File.WriteLine("net stop wuauserv"); //Заполнение его
                 File.Close();
             }           
         }*/
    }
}
