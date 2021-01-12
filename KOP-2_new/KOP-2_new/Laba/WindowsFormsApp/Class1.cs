using ControlLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class Class1
    {//[Column(title: "ID!", width: 40, visible:false)]
        public int id { get; set; }
        //gridViewAutoSize: DataGridViewAutoSizeColumnMode.Fill

        //[Column(title: "Текст", width:100)]
        public string Text { get; set; }

        //[Column(title: "Телефон", width: 100)]
        public string Phone { get; set; }



        public List<string> Properties() => new List<string>
        { "id",
          "Text",
          "Phone"
        };
        public List<DataGridViewTextBoxColumn> Config() => new List<DataGridViewTextBoxColumn>
        {
           new DataGridViewTextBoxColumn
           {
                HeaderText="ID",
                Width=40,
                Visible=false,
               AutoSizeMode= DataGridViewAutoSizeColumnMode.None
           },
           new DataGridViewTextBoxColumn
           {
                HeaderText="Текст",
                Width=100,
                Visible=true,
               AutoSizeMode= DataGridViewAutoSizeColumnMode.None
           },
           new DataGridViewTextBoxColumn
           {
                HeaderText="Телефон",
                Width=100,
                Visible=true,
                AutoSizeMode= DataGridViewAutoSizeColumnMode.None
           },
        };
    }
}
