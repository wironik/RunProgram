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

namespace RunProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSystemInfo_Click(object sender, EventArgs e)
        {
            //Добавляем блок обработки исключений — по разным причинам (например, 
            //система установлена на другом диске) приложение может быть недоступным.
            try
            {
                //Создаем новый экземпляр SysInfo класса Process
                Process SysInfo = new Process();
                // Если приложение не будет работать корректно — вызываем диалоговое окно ошибок.
                SysInfo.StartInfo.ErrorDialog = true;
                //Указываем путь к  запускаемому приложению "Сведения о системе"
                SysInfo.StartInfo.FileName = "C:\\Program Files\\Common Files\\Microsoft Shared\\MSInfo\\msinfo32.exe";
                //Запускаем SysInfo
                SysInfo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnRegEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Process RegEdit = new Process();
                RegEdit.StartInfo.ErrorDialog = true;
                //Указываем путь к  запускаемому приложению "Редактор реестра"
                RegEdit.StartInfo.FileName = "C:\\Windows\\regedit.exe";
                RegEdit.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                Process Explorer = new Process();
                Explorer.StartInfo.ErrorDialog = true;
                //Указываем путь к  запускаемому приложению "Проводник"
                Explorer.StartInfo.FileName = "C:\\Windows\\explorer.exe";
                Explorer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
