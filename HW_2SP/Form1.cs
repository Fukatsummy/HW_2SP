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
using System.Runtime.InteropServices;


namespace HW_2SP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Process killProcess = new Process();

        const uint WM_SETTEXT = 0x0C; //константа, идентифицирующая сообщение WM _ SETTEXT
        const uint MB_OK = 0x00000000;
        const uint MB_INFORMATION = 64;
        const uint MB_ICONERROR = 0x00000010;
        private Process proc;

        public class DllImportC
        {
            [DllImport("User32.dll")]//импортируем функцию SendMEssage из библиотеки
            public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
        }
        
        List<Process> Processes = new List<Process>(); /*список, в котором будут храниться объекты, описывающие дочерние процессы приложения*/
        int Counter = 0; /*счётчик запущенных процессов*/

            private void l_2_Click(object sender, EventArgs e)
        {

        }
        /*метод обёртывания для отправки сообщения WM _ SETTEXT*/
        /*void SetChildWindowText(IntPtr Handle, string text)
        {
            SendMessage(Handle, WM_SETTEXT, 0, text);
        }*/

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                proc = new Process();
                proc.StartInfo = new ProcessStartInfo("notepad.exe");
                proc.Start();
                //if (CB.Checked)
                //{
                    proc.WaitForExit();
                    if (proc.HasExited)
                    {
                        DllImportC.MessageBox(IntPtr.Zero, $"Процесс завершен. Код завершения: {proc.ExitCode}", " ", MB_OK | MB_INFORMATION);
                    }
               // }
            }
            catch (Exception ex)
            {
                DllImportC.MessageBox(IntPtr.Zero, "ERROR", "", MB_OK | MB_ICONERROR);
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            try
            {
                proc.CloseMainWindow(); //убирает интерфейсную часть процесса (его главное окно)
                proc.Close(); // высвобождает ресурсы выделенные на процесс


            }
            catch (Exception ex)
            {
                DllImportC.MessageBox(IntPtr.Zero, "ERROR", "", MB_OK | MB_ICONERROR);
            }
        }
    }
}
