namespace JailbreakDestroyer
{
	// Token: 0x0200000A RID: 10
	public partial class Whitelist : global::System.Windows.Forms.Form
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x00029DF0 File Offset: 0x00027FF0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00029E28 File Offset: 0x00028028
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::JailbreakDestroyer.Whitelist));
			this.bunifuFlatButton1 = new global::Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton2 = new global::Bunifu.Framework.UI.BunifuFlatButton();
			this.flatTextBox1 = new global::FlatUI.FlatTextBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.timer2 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.bunifuFlatButton1.Activecolor = global::System.Drawing.Color.FromArgb(46, 139, 87);
			this.bunifuFlatButton1.BackColor = global::System.Drawing.Color.FromArgb(46, 139, 87);
			this.bunifuFlatButton1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 4;
			this.bunifuFlatButton1.ButtonText = "Submit";
			this.bunifuFlatButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton1.DisabledColor = global::System.Drawing.Color.Gray;
			this.bunifuFlatButton1.Font = new global::System.Drawing.Font("Verdana", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton1.Iconcolor = global::System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.Iconimage = (global::System.Drawing.Image)componentResourceManager.GetObject("bunifuFlatButton1.Iconimage");
			this.bunifuFlatButton1.Iconimage_right = null;
			this.bunifuFlatButton1.Iconimage_right_Selected = null;
			this.bunifuFlatButton1.Iconimage_Selected = null;
			this.bunifuFlatButton1.IconMarginLeft = 45;
			this.bunifuFlatButton1.IconMarginRight = 0;
			this.bunifuFlatButton1.IconRightVisible = true;
			this.bunifuFlatButton1.IconRightZoom = 0.0;
			this.bunifuFlatButton1.IconVisible = true;
			this.bunifuFlatButton1.IconZoom = 90.0;
			this.bunifuFlatButton1.IsTab = false;
			this.bunifuFlatButton1.Location = new global::System.Drawing.Point(265, 140);
			this.bunifuFlatButton1.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = global::System.Drawing.Color.FromArgb(46, 139, 87);
			this.bunifuFlatButton1.OnHovercolor = global::System.Drawing.Color.FromArgb(36, 129, 77);
			this.bunifuFlatButton1.OnHoverTextColor = global::System.Drawing.Color.White;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new global::System.Drawing.Size(204, 48);
			this.bunifuFlatButton1.TabIndex = 3;
			this.bunifuFlatButton1.Text = "Submit";
			this.bunifuFlatButton1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton1.Textcolor = global::System.Drawing.Color.White;
			this.bunifuFlatButton1.TextFont = new global::System.Drawing.Font("Yu Gothic", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton1.Click += new global::System.EventHandler(this.bunifuFlatButton1_Click);
			this.bunifuFlatButton2.Activecolor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.bunifuFlatButton2.BackColor = global::System.Drawing.Color.SteelBlue;
			this.bunifuFlatButton2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton2.BorderRadius = 5;
			this.bunifuFlatButton2.ButtonText = "Get Key";
			this.bunifuFlatButton2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton2.DisabledColor = global::System.Drawing.Color.Gray;
			this.bunifuFlatButton2.Font = new global::System.Drawing.Font("Verdana", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton2.Iconcolor = global::System.Drawing.Color.Transparent;
			this.bunifuFlatButton2.Iconimage = (global::System.Drawing.Image)componentResourceManager.GetObject("bunifuFlatButton2.Iconimage");
			this.bunifuFlatButton2.Iconimage_right = null;
			this.bunifuFlatButton2.Iconimage_right_Selected = null;
			this.bunifuFlatButton2.Iconimage_Selected = null;
			this.bunifuFlatButton2.IconMarginLeft = 55;
			this.bunifuFlatButton2.IconMarginRight = 0;
			this.bunifuFlatButton2.IconRightVisible = true;
			this.bunifuFlatButton2.IconRightZoom = 0.0;
			this.bunifuFlatButton2.IconVisible = true;
			this.bunifuFlatButton2.IconZoom = 40.0;
			this.bunifuFlatButton2.IsTab = false;
			this.bunifuFlatButton2.Location = new global::System.Drawing.Point(25, 140);
			this.bunifuFlatButton2.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			this.bunifuFlatButton2.Name = "bunifuFlatButton2";
			this.bunifuFlatButton2.Normalcolor = global::System.Drawing.Color.SteelBlue;
			this.bunifuFlatButton2.OnHovercolor = global::System.Drawing.Color.CornflowerBlue;
			this.bunifuFlatButton2.OnHoverTextColor = global::System.Drawing.Color.White;
			this.bunifuFlatButton2.selected = false;
			this.bunifuFlatButton2.Size = new global::System.Drawing.Size(200, 48);
			this.bunifuFlatButton2.TabIndex = 4;
			this.bunifuFlatButton2.Text = "Get Key";
			this.bunifuFlatButton2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton2.Textcolor = global::System.Drawing.Color.White;
			this.bunifuFlatButton2.TextFont = new global::System.Drawing.Font("Yu Gothic", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton2.Click += new global::System.EventHandler(this.bunifuFlatButton2_Click);
			this.flatTextBox1.BackColor = global::System.Drawing.Color.DimGray;
			this.flatTextBox1.FocusOnHover = false;
			this.flatTextBox1.Location = new global::System.Drawing.Point(56, 94);
			this.flatTextBox1.MaxLength = 32767;
			this.flatTextBox1.Multiline = false;
			this.flatTextBox1.Name = "flatTextBox1";
			this.flatTextBox1.ReadOnly = false;
			this.flatTextBox1.Size = new global::System.Drawing.Size(376, 29);
			this.flatTextBox1.TabIndex = 5;
			this.flatTextBox1.Text = "WELCOMETONONSENSE";
			this.flatTextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBox1.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox1.UseSystemPasswordChar = true;
			this.flatTextBox1.TextChanged += new global::System.EventHandler(this.flatTextBox1_TextChanged);
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(77, -7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(332, 95);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(391, 1);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(100, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Current Version: 3.5";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.ClientSize = new global::System.Drawing.Size(492, 200);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.flatTextBox1);
			base.Controls.Add(this.bunifuFlatButton2);
			base.Controls.Add(this.bunifuFlatButton1);
			this.ForeColor = global::System.Drawing.Color.FromArgb(124, 3, 139);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Whitelist";
			this.Text = "Whitelist";
			base.Load += new global::System.EventHandler(this.Whitelist_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400027F RID: 639
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000280 RID: 640
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;

		// Token: 0x04000281 RID: 641
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;

		// Token: 0x04000282 RID: 642
		private global::FlatUI.FlatTextBox flatTextBox1;

		// Token: 0x04000283 RID: 643
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000284 RID: 644
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000285 RID: 645
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000286 RID: 646
		private global::System.Windows.Forms.Timer timer2;
	}
}
