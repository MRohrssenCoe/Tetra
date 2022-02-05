using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TetraScheduler
{
    public partial class Form3 : Form
    {
        // This form is an example form for possibly using a data grid for our schedule - can delete later
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = generateTable();
        }

        private DataTable generateTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Shift");
            dt.Columns.Add("Consultants");
            dt.Rows.Add(new string[] { "8-9", "A" });
            dt.Rows.Add(new string[] { "9-10", "A, B" });
            dt.Rows.Add(new string[] { "12-1", "C" });
            dt.Rows.Add(new string[] { "2-3", "B" });
            return dt;
        }
    }
}
