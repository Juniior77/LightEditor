using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightEditor
{
    public partial class UserControl_Fixture : UserControl
    {
        private static UserControl_Fixture _instance;
        public static UserControl_Fixture Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_Fixture();
                return _instance;
            }
        }
        public UserControl_Fixture()
        {
            InitializeComponent();
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Channel";
            dataGridView1.Columns[1].Name = "Fonction";
            dataGridView1.Columns.Add(imageCol);
        }
    }
}
