using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Timer
{
	public partial class Timer : Form
	{
		public Timer()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			timer1.Interval = Convert.ToInt32(textBox1.Text) * 1000;
		}

		

	}
}
