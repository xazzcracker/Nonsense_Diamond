using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FlatUI;
using JailbreakDestroyer.Properties;
using ScintillaNET;

namespace JailbreakDestroyer
{
	// Token: 0x02000009 RID: 9
	public partial class redesign1 : Form
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x00023A70 File Offset: 0x00021C70
		public redesign1()
		{
			this.InitializeComponent();
			this.InitializeComponent();
			this.Text = "Nonsense Diamond";
			base.Icon = Resources.diiamond1_9Ma_icon;
			string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
			string str2 = "0123456789";
			string str3 = "ŠšŒœŸÿÀàÁáÂâÃãÄäÅåÆæÇçÈèÉéÊêËëÌìÍíÎîÏïÐðÑñÒòÓóÔôÕõÖØøÙùÚúÛûÜüÝýÞþßö";
			this.scintilla1.StyleResetDefault();
			this.scintilla1.Styles[32].Font = "Consolas";
			this.scintilla1.Styles[32].Size = 12;
			this.scintilla1.StyleClearAll();
			this.scintilla1.Styles[0].ForeColor = Color.Silver;
			this.scintilla1.Styles[1].ForeColor = Color.FromArgb(0, 0, 127, 0);
			this.scintilla1.Styles[2].ForeColor = Color.FromArgb(0, 0, 127, 0);
			this.scintilla1.Styles[4].ForeColor = Color.FromArgb(0, 0, 127, 127);
			this.scintilla1.Styles[5].ForeColor = Color.FromArgb(0, 0, 0, 127);
			this.scintilla1.Styles[13].ForeColor = Color.FromArgb(0, 255, 128, 0);
			this.scintilla1.Styles[14].ForeColor = Color.FromArgb(0, 255, 0, 0);
			this.scintilla1.Styles[15].ForeColor = Color.DarkSlateBlue;
			this.scintilla1.Styles[6].ForeColor = Color.FromArgb(0, 127, 0, 127);
			this.scintilla1.Styles[7].ForeColor = Color.FromArgb(0, 127, 0, 127);
			this.scintilla1.Styles[8].ForeColor = Color.FromArgb(0, 127, 0, 127);
			this.scintilla1.Styles[10].ForeColor = Color.FromArgb(0, 127, 127, 127);
			this.scintilla1.Styles[9].ForeColor = Color.Maroon;
			this.scintilla1.Lexer = Lexer.Lua;
			this.scintilla1.WordChars = str + str2 + str3;
			this.scintilla1.SetKeywords(0, "info and break do else elseif end for function if in local nil not or repeat return then until while false true goto assert collectgarbage dofile _G getmetatable ipairs loadfile next pairs pcall print rawequal rawget rawset setmetatable tonumber tostring type _VERSION xpcall string table math coroutine io os debug getfenv gcinfo load loadlib loadstring require select setfenv unpack _LOADED LUA_PATH _REQUIREDNAME package rawlen package bit32 utf8 _ENV string.byte string.char string.dump string.find string.format string.gsub string.len string.lower string.rep string.sub string.upper table.concat table.insert table.remove table.sort math.abs math.acos math.asin math.atan math.atan2 math.ceil math.cos math.deg math.exp math.floor math.frexp math.ldexp math.log math.max math.min math.pi math.pow math.rad math.random math.randomseed math.sin math.sqrt math.tan string.gfind string.gmatch string.match string.reverse string.pack string.packsize string.unpack table.foreach table.foreachi table.getn table.setn table.maxn table.pack table.unpack table.move math.cosh math.fmod math.huge math.log10 math.modf math.mod math.sinh math.tanh math.maxinteger math.mininteger math.tointeger math.type math.ult bit32.arshift bit32.band bit32.bnot bit32.bor bit32.btest bit32.bxor bit32.extract bit32.replace bit32.lrotate bit32.lshift bit32.rrotate bit32.rshift utf8.char utf8.charpattern utf8.codes utf8.codepoint utf8.len utf8.offset coroutine.create coroutine.resume coroutine.status coroutine.wrap coroutine.yield io.close io.flush io.input io.lines io.open io.output io.read io.tmpfile io.type io.write io.stdin io.stdout io.stderr os.clock os.date os.difftime os.execute os.exit os.getenv os.remove os.rename os.setlocale os.time os.tmpname coroutine.isyieldable coroutine.running io.popen module package.loaders package.seeall package.config package.searchers package.searchpath require package.cpath package.loaded package.loadlib package.path package.preload");
			this.scintilla1.SetKeywords(1, "warn");
			this.scintilla1.SetKeywords(2, "error");
			this.scintilla1.SetKeywords(3, "");
			this.scintilla1.SetProperty("fold", "1");
			this.scintilla1.SetProperty("fold.compact", "1");
			this.scintilla1.Margins[1].Type = MarginType.Symbol;
			this.scintilla1.Margins[1].Mask = 4261412864u;
			this.scintilla1.Margins[1].Sensitive = true;
			this.scintilla1.Margins[1].Width = 20;
			this.scintilla1.ScrollWidth = 0;
			this.scintilla1.ScrollWidthTracking = true;
			for (int i = 25; i <= 31; i++)
			{
				this.scintilla1.Markers[i].SetForeColor(SystemColors.ControlLightLight);
				this.scintilla1.Markers[i].SetBackColor(SystemColors.ControlDark);
			}
			this.scintilla1.Markers[30].Symbol = MarkerSymbol.BoxPlus;
			this.scintilla1.Markers[31].Symbol = MarkerSymbol.BoxMinus;
			this.scintilla1.Markers[25].Symbol = MarkerSymbol.BoxPlusConnected;
			this.scintilla1.Markers[27].Symbol = MarkerSymbol.TCorner;
			this.scintilla1.Markers[26].Symbol = MarkerSymbol.BoxMinusConnected;
			this.scintilla1.Markers[29].Symbol = MarkerSymbol.VLine;
			this.scintilla1.Markers[28].Symbol = MarkerSymbol.LCorner;
			this.scintilla1.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00004C45 File Offset: 0x00002E45
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00004C45 File Offset: 0x00002E45
		private void formSkin1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00023EEF File Offset: 0x000220EF
		private void flatButton1_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage3;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00023F04 File Offset: 0x00022104
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			this.panel1.HorizontalScroll.Visible = false;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00004C45 File Offset: 0x00002E45
		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00023F19 File Offset: 0x00022119
		private void flatButton2_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage4;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00023F2E File Offset: 0x0002212E
		private void flatButton6_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage1;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00023F19 File Offset: 0x00022119
		private void flatButton13_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage4;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00004C45 File Offset: 0x00002E45
		private void scintilla1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00004C45 File Offset: 0x00002E45
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}
