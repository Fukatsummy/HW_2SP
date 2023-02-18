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
using System.IO;
using System.Reflection;
using System.Management;

namespace HW_2SP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
       
        const uint WM_SETTEXT = 0x0C; //константа, идентифицирующая сообщение WM _ SETTEXT
        
        //user32.dll
        [DllImport("user32.dll")]//импортируем функцию SendMEssage из библиотеки
        public static extern IntPtr SendMessage(IntPtr hwnd,
        uint Msg, int wParam,
        [MarshalAs(UnmanagedType.LPStr)] string lParam);
        List<Process> Processes = new List<Process>(); /*список, в котором будут храниться объекты, описывающие дочерние процессы приложения*/
        int Counter = 0; /*счётчик запущенных процессов*/

        

            private void l_2_Click(object sender, EventArgs e)
        {

        }
    }
}
