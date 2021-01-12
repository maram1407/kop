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
    public partial class ControlDataGridView : UserControl
    {
        private int index;

        public int SelectedIndex
        {
            get
            {
                index = dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                return index;
            }
            set
            {
                index = value;
                dataGridView.Rows[index].Selected = true;
            }
        }
        public string GetRef
        {
            get
            {
                DataGridViewSelectedRowCollection result = dataGridView.SelectedRows;
                //DataGridViewRow result =dataGridView.CurrentRow;
                return result.ToString();
            }
        }
        public int GetCountRows
        {
            get { return dataGridView.Rows.Count; }
        }

        public ControlDataGridView()
        {
            InitializeComponent();

        }
        public void Config(Type type)
        {
            object obj = Activator.CreateInstance(type);
            var method = type.GetMethod("Config");
            var config = (List<DataGridViewTextBoxColumn>)method.Invoke(obj, null);
            dataGridView.Columns.Clear();
            dataGridView.RowHeadersVisible = false;
            foreach (var conf in config)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    Name = conf.ToString(),
                    ReadOnly = true,
                    HeaderText = conf.HeaderText,//columnAttr.Title,
                    Visible = conf.Visible,
                    Width = conf.Width
                };
                if (conf.AutoSizeMode != DataGridViewAutoSizeColumnMode.None)
                {
                    column.AutoSizeMode = (DataGridViewAutoSizeColumnMode)Enum.Parse(typeof(DataGridViewAutoSizeColumnMode),
                        conf.AutoSizeMode.ToString());
                }
                dataGridView.Columns.Add(column);
            }
        }
        public void LoadData<T>(List<T> list)
        {
           
            var type = typeof(T);
            // создаем объект от типа
            object obj = Activator.CreateInstance(type);
            // вытаскиваем метод получения списка заголовков
            var method = type.GetMethod("Config");
            
            // добавляем строки
            var methodP = type.GetMethod("Properties");
            // вызываем метод.
           
           var configP = (List<string>)methodP.Invoke(obj, null);
            foreach (var elem in list)
            {
                List<object> objs = new List<object>();
                foreach (var conf in configP)
                {
                    var value = elem.GetType().GetProperty(conf).GetValue(elem);
                    objs.Add(value);
                }
                dataGridView.Rows.Add(objs.ToArray());
            }
        }

    }
}
