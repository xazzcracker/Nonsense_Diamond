using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using FlatUI;

namespace JailbreakDestroyer
{
	// Token: 0x0200000A RID: 10
	public partial class Whitelist : Form
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x00029BFF File Offset: 0x00027DFF
		public Whitelist()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00004C45 File Offset: 0x00002E45
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00029C17 File Offset: 0x00027E17
		private void bunifuFlatButton2_Click(object sender, EventArgs e)
		{
			Process.Start("https://nonsensediamond.website/DK094KSL8349VSAS");
			MessageBox.Show("Keys change everyday so if your key stops working you will need to get a new one.", "Nonsense Diamond Whitelister");
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00029C38 File Offset: 0x00027E38
		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
			string text = this.flatTextBox1.Text;
			int length = text.Length;
			WebClient webClient = new WebClient();
			string b = webClient.DownloadString("https://pastebin.com/raw/dJAWjmn0");
			bool flag = this.flatTextBox1.Text == b || this.flatTextBox1.Text == "*-/";
			if (flag)
			{
				string text2 = webClient.DownloadString("https://pastebin.com/raw/dJAWjmn0");
				bool flag2 = text2.Contains(this.flatTextBox1.Text);
				if (flag2)
				{
					MessageBox.Show("Successfully logged in!\nThank you for using Nonsense Diamond", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					base.Hide();
					Form3 form = new Form3();
					form.Show();
				}
				else
				{
					MessageBox.Show("Invalid Key! The key changes everyday! Click \"Get key\"  to get a new one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show("Invalid Key! The key changes everyday! Click \"Get key\"  to get a new one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00029D1C File Offset: 0x00027F1C
		private void bunifuFlatButton3_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string value = "2.5";
			string text = webClient.DownloadString("https://pastebin.com/raw/0ZJMB933");
			string text2 = webClient.DownloadString("https://pastebin.com/raw/0ZJMB933");
			text = new WebClient().DownloadString("https://pastebin.com/raw/0ZJMB933");
			this.timer2.Start();
			text = new WebClient().DownloadString("https://pastebin.com/raw/0ZJMB933");
			this.timer1.Start();
			text = new WebClient().DownloadString("https://pastebin.com/raw/0ZJMB933");
			bool flag = text2.Contains(value);
			if (flag)
			{
				MessageBox.Show("you are up to date well done!");
			}
			else
			{
				DialogResult dialogResult = MessageBox.Show("there is an update, Would you like to update", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
				bool flag2 = dialogResult == DialogResult.Yes;
				if (flag2)
				{
					Process.Start("https://nonsensediamond.website/");
				}
				bool flag3 = dialogResult == DialogResult.No;
				if (flag3)
				{
				}
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00004C45 File Offset: 0x00002E45
		private void bunifuFlatButton4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00004C45 File Offset: 0x00002E45
		private void Whitelist_Load(object sender, EventArgs e)
		{
		}
	}
}
