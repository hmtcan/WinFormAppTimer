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

		//  Amaç: Belirlenen zaman aralığında butona basıldığında eylemi başlatmak veya durdurmak.
		//  Olası senaryolar: Stok bilgisi güncellenmesi için veya merkezdeki ilaç bilgilerinin belli aralıklarla şubelere transfer olması için.

		public Timer()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			// TEST: MessageBox.Show("Timer çalıştı!");
			lblTime.Text = DateTime.Now.ToString();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			//Butona basılınca başlat
			timer1.Start();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			//Butona basılınca durdur
			timer1.Stop();

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			// Timer'ın Özelliği: Interval (Aralık)
			// timer1.Interval = 2000; // XHardcodeX
			timer1.Interval = Convert.ToInt32(textBox1.Text) * 1000;

		}
		
		// Mantıklı olan çözüm: Hardcode yapmak yerine veritabanındaki süre tablosundan, süre kolonunu değiştirmek;
		// çünkü süre veya ayarların değiştirilmesinin istenilmesi durumunda 30 tane yerden değil tek yerden değiştirmek üstünlük sağlar.

	}
}
