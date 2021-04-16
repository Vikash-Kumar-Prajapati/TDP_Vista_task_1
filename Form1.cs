using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDP_Vista_task_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void show_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("Roll_ID");
			dt.Columns.Add("Name");
			dt.Columns.Add("Total Score");
			dt.Columns.Add("Percentile");
			int roll = Convert.ToInt32(rollInput.Text);
			if (roll == 1)
			{
				dt.Rows.Add(1, "A", 200, 50);
				data.DataSource = dt;
			}
			else if (roll == 2)
			{
				dt.Rows.Add(2, "B", 250, 60);
				data.DataSource = dt;
			}
			else if (roll == 3)
			{
				dt.Rows.Add(3, "C", 150, 30);
				data.DataSource = dt;
			}
			else if (roll == 4)
			{
				dt.Rows.Add(4, "D", 250, 60);
				data.DataSource = dt;
			}
			else if (roll == 5)
			{
				dt.Rows.Add(5, "E", 500, 100);
				data.DataSource = dt;
			}

		}

		private void clear_Click(object sender, EventArgs e)
		{
			rollInput.Clear();
		}

		private void close_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
