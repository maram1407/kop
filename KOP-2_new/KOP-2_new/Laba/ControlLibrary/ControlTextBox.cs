using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class ControlTextBox : UserControl
    {
        public int? znachenie;
        public int? GetZnachenie
        {
            set
            {
                    znachenie = Convert.ToInt32(value);
                    textBox.Text = value.ToString();   
            }
            get 
            {
               
                    //Нажат checkBox
                    if (checkBox.Checked == true)
                    {
                        textBox.Text = "null";
                        znachenie = null;
                    }
                    //Нормальный ввод
                    else
                    {
                         znachenie = Convert.ToInt32(textBox.Text);
                    }
                    return znachenie;
                
            }
        }
        public ControlTextBox()
        {
            InitializeComponent();
        }
    }
}
