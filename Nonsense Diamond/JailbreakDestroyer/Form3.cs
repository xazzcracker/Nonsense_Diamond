using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using FlatUI;
using JailbreakDestroyer.Properties;
using ScintillaNET;
using WeAreDevs_API;

namespace JailbreakDestroyer
{
	// Token: 0x02000007 RID: 7
	public partial class Form3 : Form
	{
		// Token: 0x06000025 RID: 37 RVA: 0x000046F4 File Offset: 0x000028F4
		public Form3()
		{
			this.InitializeComponent();
			Languages languages = new Languages(this);
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

		// Token: 0x06000026 RID: 38 RVA: 0x00004BA8 File Offset: 0x00002DA8
		private void flatButton16_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox2.Text;
			this.api.SendLimitedLuaScript(text);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004BCF File Offset: 0x00002DCF
		private void flatButton18_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(376.6, 18.3, -1686.9) end");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004BE3 File Offset: 0x00002DE3
		private void flatButton19_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game.StarterGui:SetCoreGuiEnabled(Enum.CoreGuiType.Backpack, true)\nplr = game:GetService(\"Players\").LocalPlayer\nchar = plr.Character\nhum = char.Humanoid\ntool5 = Instance.new(\"HopperBin\", plr.Backpack)\ntool5.Name = \"click unlock\"\nmouse = plr:GetMouse()\n\ntool5.Selected:connect(function()\nmouse.Button1Down:connect(function()\nmouse.Target.Locked = false\nend)\nend)\nc = Instance.new(\"HopperBin\", game:GetService(\"Players\").LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Hammer");
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004BF7 File Offset: 0x00002DF7
		public void flatButton1_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCRvLsJ4SOATDr4Ti3D2_5tw?sub_confirmation=1");
			this.api.LaunchExploit();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004C14 File Offset: 0x00002E14
		private void myJob(object sender)
		{
			Button button = sender as Button;
			bool flag = button != null && button.Name == "Button1";
			if (flag)
			{
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004C45 File Offset: 0x00002E45
		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004C48 File Offset: 0x00002E48
		private void flatButton20_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(138.581238, 18.1094494, -1769.56287)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004C67 File Offset: 0x00002E67
		private void flatButton17_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 50\nscript:Destroy()");
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004C7C File Offset: 0x00002E7C
		private void flatButton21_Click(object sender, EventArgs e)
		{
			string text = this.scintilla1.Text;
			this.api.SendLimitedLuaScript(text);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatButton22_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004CA4 File Offset: 0x00002EA4
		private void flatButton23_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox1.Text;
			this.api.SendLimitedLuaScript(text);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004CCB File Offset: 0x00002ECB
		private void flatButton4_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(-222, 17, 1575)\nscript:Destroy()");
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004CDF File Offset: 0x00002EDF
		private void flatButton8_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(1637, 50, -1768)\nscript:Destroy()");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004CF3 File Offset: 0x00002EF3
		private void flatButton7_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(-1130, 17, -1593)\nscript:Destroy()");
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004D07 File Offset: 0x00002F07
		private void flatButton6_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(736, 38, 1130)\nscript:Destroy()");
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004D1B File Offset: 0x00002F1B
		private void flatButton5_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(13, 17, 789)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004D3A File Offset: 0x00002F3A
		private void flatButton9_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(136, 19, 1318)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004D59 File Offset: 0x00002F59
		private void flatButton15_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(267, 19, -1796)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004D78 File Offset: 0x00002F78
		private void flatButton11_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(-1548, 17, 701)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004D97 File Offset: 0x00002F97
		private void flatButton25_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 50 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.1)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(19, 17, 840)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(31, 1, 814)\nwait(2)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(18, 5, 804)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004DB6 File Offset: 0x00002FB6
		private void flatButton12_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local plr = game:GetService(\"Players\").LocalPlayer\nGiver = {}\n\tlocal g = Giver\n\tlocal p = Instance.new(\"Part\", workspace)\n\tp.Anchored = true\n\tp.CanCollide = false\n\tp.CFrame = plr.Character:WaitForChild\"HumanoidRootPart\".CFrame\n\tsetmetatable(Giver, {__metatable = p})\n\tfor i,v in pairs(workspace.Givers:GetChildren()) do\n\t\tlocal cd = v:FindFirstChildOfClass\"ClickDetector\"\n\t\tif cd then\n\t\t\tlocal newt = {}\n\t\t\tnewt.ClickDetector = cd\n\t\t\tnewt.OriginalParent = v\n\t\t\tcd.Parent = p\n\t\t\tnewt.Event = cd.MouseClick:connect(function()\n\t\t\t\tcd.Parent = v\n\t\t\tend)\n\t\t\ttable.insert(Giver, newt)\n\t\tend\n\tend\n\tspawn(function()\n\t\twait(10)\n\t\tif Giver == g then\n\t\t\tGiver = nil\n\t\t\tfor i,v in pairs(g) do\n\t\t\t\tv.ClickDetector.Parent = v.OriginalParent\n\t\t\t\tv.Event:Disconnect()\n\t\t\tend\n\t\t\tgetmetatable(g):Destroy()\n\t\tend\n\tend)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004DD5 File Offset: 0x00002FD5
		private void flatButton24_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game.StarterGui:SetCoreGuiEnabled(Enum.CoreGuiType.Backpack, true)\nplr = game:GetService('Players').LocalPlayer\nchar = plr.Character\nhum = char.Humanoid\ntool54 = Instance.new(\"HopperBin\", plr.Backpack)\ntool54.Name = \"Click Teleport\"\nmouse = plr:GetMouse()\n\ntool54.Selected:connect(function()\nmouse.Button1Down:connect(function()\nif tool54.Active then\n\nchar.HumanoidRootPart.CFrame = mouse.Target.CFrame\n\nend\nend)\nend)");
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004DE9 File Offset: 0x00002FE9
		private void flatButton26_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i,v in pairs(game:GetService(\"Teams\").Criminal:GetPlayers()) do\nwait()\nlocal as = 0\nwhile as < 30 do\ngame:GetService(\"Players\").LocalPlayer.Character.HumanoidRootPart.CFrame = v.Character.HumanoidRootPart.CFrame * CFrame.new(0, 0, 1)\nwait(0.1)\nas = as + 1\nend\nend\nscript:Destroy()");
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004DFD File Offset: 0x00002FFD
		private void flatButton10_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("b = workspace:FindFirstChild(\"Banks\"):GetChildren()[1].Extra.Sign.Decal\nj = workspace.Jewelrys:FindFirstChild('Extra', true).Sign.Decal\nif b.Transparency == 0 then\nwarn(\"Bank is Closed\")\nif j.Transparency == 0 then\nwarn(\"Jewelry is Closed\")\nelse\nprint(\"Jewelry Ready\")\nend\nelse\nprint(\"Bank ready\")\nend\nscript:Destroy()");
			MessageBox.Show("Press F9 To See If Stores are open.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004E24 File Offset: 0x00003024
		private void flatButton27_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 0\nscript:Destroy()");
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatCheckBox2_CheckedChanged(object sender)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatCheckBox3_CheckedChanged(object sender)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatCheckBox4_CheckedChanged(object sender)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004C45 File Offset: 0x00002E45
		private void tabPage4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004E38 File Offset: 0x00003038
		private void flatButton28_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox7.Text;
			this.api.SendLimitedLuaScript(text);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004E5F File Offset: 0x0000305F
		private void flatButton13_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService(\"UserInputService\").JumpRequest:connect(function()\ngame:GetService\"Players\".LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState(\"Jumping\")\nend)");
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004C45 File Offset: 0x00002E45
		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004E73 File Offset: 0x00003073
		private void flatButton30_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press Q when you get arrested to un-arrest yourself!", "HEEY!");
			this.api.SendLimitedLuaScript("while wait(1) do game.Workspace.TouchTrigger.Donut.Position = game:GetService('Players').LocalPlayer.Character.Head.Position end");
			this.api.SendLimitedLuaScript("local wrk = game:GetService('Workspace') local plr = game:GetService('Players').LocalPlayer local mouse = plr:GetMouse() mouse.KeyDown:connect(function(key) if key:lower() == 'q' or key:upper() == 'Q' then if plr.Character.Handcuffs ~= nil then b = Instance.new('Part') b.Name = ('Gad') b.Parent = wrk b.CFrame = CFrame.new(plr.Character.UpperTorso.Position) b.Anchored = true b.CanCollide = false b.Transparency = 0.05 wait(10) plr.Character.HumanoidRootPart.CFrame = CFrame.new(wrk.Gad.Position) b:Destroy() end end end)");
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004EA8 File Offset: 0x000030A8
		private void flatButton31_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(-970, 20, -1450)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004EC8 File Offset: 0x000030C8
		private void flatButton32_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox3.Text;
			this.api.SendLimitedLuaScript(text);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004EF0 File Offset: 0x000030F0
		private void flatButton33_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox4.Text;
			this.api.SendLimitedLuaScript(text);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004F18 File Offset: 0x00003118
		private void flatButton34_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox5.Text;
			this.api.SendLimitedLuaScript(text);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004C45 File Offset: 0x00002E45
		private void richTextBox6_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004F40 File Offset: 0x00003140
		private void flatButton36_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox8.Text;
			this.api.SendLimitedLuaScript(this.richTextBox28.Text);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004F74 File Offset: 0x00003174
		private void flatButton35_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox6.Text;
			this.api.SendLimitedLuaScript(text);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004F9C File Offset: 0x0000319C
		private void flatCheckBox5_CheckedChanged(object sender)
		{
			bool flag = !this.flatCheckBox5.Checked;
			if (flag)
			{
				this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 196.2\nscript:Destroy()");
			}
			else
			{
				this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 0\nscript:Destroy()");
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004FE4 File Offset: 0x000031E4
		private void flatButton37_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("Workspace.Bush:Destroy()\nWorkspace.Buildings:ClearAllChildren()\nWorkspace.Apartments:ClearAllChildren()\nWorkspace.Trees:ClearAllChildren()");
			this.api.SendLimitedLuaScript("game.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.StoreWindow:Destroy()\n\ngame.Workspace.Jewelrys:GetChildren()[1].Model.BarbedWire:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.BarbedWire:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Model.BarbedWire:Destroy()\n\ngame.Workspace.Jewelrys:GetChildren()[1].FakeDoor:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].FakeDoor:Destroy()\n\ngame.Workspace.Jewelrys:GetChildren()[1].Wall:Destroy()\ngame.Workspace.Jewelrys:GetChildren()[1].Wall:Destroy()\nscript:Destroy()");
			this.api.SendLimitedLuaScript("for i,v in pairs(Workspace.Doors:GetChildren()) do\nv.Model:ClearAllChildren()\nend");
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatButton38_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004DE9 File Offset: 0x00002FE9
		private void flatButton14_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i,v in pairs(game:GetService(\"Teams\").Criminal:GetPlayers()) do\nwait()\nlocal as = 0\nwhile as < 30 do\ngame:GetService(\"Players\").LocalPlayer.Character.HumanoidRootPart.CFrame = v.Character.HumanoidRootPart.CFrame * CFrame.new(0, 0, 1)\nwait(0.1)\nas = as + 1\nend\nend\nscript:Destroy()");
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000501A File Offset: 0x0000321A
		private void flatButton39_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(-1176.4231, 59.7911148, -1572.6908)\nscript:Destroy()");
			Thread.Sleep(4000);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005039 File Offset: 0x00003239
		private void flatButton40_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(144.794067, 17.6189003, 768.572693) end");
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000504D File Offset: 0x0000324D
		private void flatButton2_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCRvLsJ4SOATDr4Ti3D2_5tw?sub_confirmation=1");
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004C45 File Offset: 0x00002E45
		private void formSkin1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000505B File Offset: 0x0000325B
		private void flatButton38_Click_1(object sender, EventArgs e)
		{
			this.scintilla1.Text = "";
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005070 File Offset: 0x00003270
		private void flatButton41_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			bool flag = openFileDialog.ShowDialog() != DialogResult.OK;
			bool flag2 = !flag;
			if (flag2)
			{
				try
				{
					this.scintilla1.Text = File.ReadAllText(openFileDialog.FileName);
				}
				catch (Exception ex)
				{
					int num = (int)MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00005100 File Offset: 0x00003300
		private void flatButton27_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string value = "3.3";
			string text = webClient.DownloadString("https://pastebin.com/raw/1zAMmxRK");
			string text2 = webClient.DownloadString("https://pastebin.com/raw/1zAMmxRK");
			text = new WebClient().DownloadString("https://pastebin.com/raw/1zAMmxRK");
			this.timer2.Start();
			text = new WebClient().DownloadString("https://pastebin.com/raw/1zAMmxRK");
			this.timer1.Start();
			text = new WebClient().DownloadString("https://pastebin.com/raw/1zAMmxRK");
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

		// Token: 0x06000059 RID: 89 RVA: 0x00004C45 File Offset: 0x00002E45
		private void tabPage3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000051D1 File Offset: 0x000033D1
		private void flatButton3_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.me/nonsensediamond");
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000051E0 File Offset: 0x000033E0
		private void flatButton29_Click(object sender, EventArgs e)
		{
			int num = (int)MessageBox.Show("Click E to Toggle (Turn On/Off) The X-Ray!", "Message");
			this.api.SendLimitedLuaScript("local Move = game.Workspace.Map local ReplicatedStorage = game:GetService('ReplicatedStorage') local Players = game:GetService('Players') local mouse = Players.LocalPlayer:GetMouse() local a = false mouse.KeyDown:Connect(function(key) if key == 'e' then if a == false then Move.Parent = ReplicatedStorage Players.LocalPlayer.Character.HumanoidRootPart.Anchored = true a = true elseif a == true then Move.Parent = game.Workspace Players.LocalPlayer.Character.HumanoidRootPart.Anchored = false a = false end end end)");
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004C45 File Offset: 0x00002E45
		private void tabPage5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005039 File Offset: 0x00003239
		private void flatButton42_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(144.794067, 17.6189003, 768.572693) end");
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000520F File Offset: 0x0000340F
		private void flatButton43_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press 'G' to use rainbow path.");
			this.api.SendLimitedLuaScript("local player = game:GetService('Players').LocalPlayer local mouse = player:GetMouse() mouse.KeyDown:connect(function(key) if key:lower() == 'g' or key:upper() == 'G' then for i = 1,6 do wait(0.25) x = Instance.new('Part',game:GetService('Workspace')) x.Size = Vector3.new(10,0.2,10) x.TopSurface = 'Smooth' x.Anchored = true x.BrickColor = BrickColor.random()  x.CFrame = CFrame.new(player.Character.UpperTorso.Position) + Vector3.new(0,-3,0) game.Debris:AddItem(x, 3) end end end)");
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatCheckBox8_CheckedChanged(object sender)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00005230 File Offset: 0x00003430
		private void flatCheckBox6_CheckedChanged(object sender)
		{
			bool @checked = this.flatCheckBox7.Checked;
			if (@checked)
			{
				bool flag = !this.flatCheckBox6.Checked;
				if (flag)
				{
					this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 50\nscript:Destroy()");
				}
				else
				{
					this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 0\nscript:Destroy()");
				}
			}
			else
			{
				bool flag2 = !this.flatCheckBox6.Checked;
				if (flag2)
				{
					this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 196.2\nscript:Destroy()");
				}
				else
				{
					this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 0\nscript:Destroy()");
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000052C8 File Offset: 0x000034C8
		private void flatCheckBox7_CheckedChanged(object sender)
		{
			bool @checked = this.flatCheckBox7.Checked;
			if (@checked)
			{
				this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 50\nscript:Destroy()");
				this.flatCheckBox6.Checked = false;
				base.Hide();
				base.Show();
			}
			else
			{
				this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 196.2\nscript:Destroy()");
				this.flatCheckBox6.Checked = false;
				base.Hide();
				base.Show();
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatButton68_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005344 File Offset: 0x00003544
		private void flatCheckBox9_CheckedChanged(object sender)
		{
			bool @checked = this.flatCheckBox9.Checked;
			if (@checked)
			{
				this.api.SendLimitedLuaScript("_G.WS = 200;\r\n            local Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\r\n            Humanoid: GetPropertyChangedSignal('WalkSpeed'):Connect(function()\r\n             Humanoid.WalkSpeed = _G.WS;\r\n            end)\r\nHumanoid.WalkSpeed = _G.WS;");
			}
			else
			{
				bool flag = !this.flatCheckBox9.Checked;
				if (flag)
				{
					this.api.SendLimitedLuaScript("_G.WS = 20;\r\n            local Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\r\n            Humanoid: GetPropertyChangedSignal('WalkSpeed'):Connect(function()\r\n             Humanoid.WalkSpeed = _G.WS;\r\n            end)\r\nHumanoid.WalkSpeed = _G.WS;");
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000539C File Offset: 0x0000359C
		private void flatCheckBox10_CheckedChanged(object sender)
		{
			bool @checked = this.flatCheckBox10.Checked;
			if (@checked)
			{
				this.api.SendLimitedLuaScript("plr = game:GetService('Players').LocalPlayer.PlayerGui plr.MainGui.Nitro.Name = 'Nitr' plr.ProductGui.Nitro.Parent = game.Lighting b = Instance.new('Model', plr.ProductGui) b.Name = 'Nitro'");
			}
			else
			{
				bool flag = !this.flatCheckBox10.Checked;
				if (flag)
				{
					this.api.SendLimitedLuaScript("plr = game:GetService('Players')  plr.LocalPlayer.PlayerGui.ProductGui.Nitro:Destroy() game.Lighting.Nitro.Parent = plr.LocalPlayer.PlayerGui.ProductGui plr.LocalPlayer.PlayerGui.MainGui.Nitro.Name = 'Nitro'");
				}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000053F3 File Offset: 0x000035F3
		private void flatButton50_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-170, 18.6, 1057.1) end");
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005407 File Offset: 0x00003607
		private void flatButton76_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-97.5, 18.3, -1724) end");
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000541B File Offset: 0x0000361B
		private void flatButton75_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(761.3, 18.5, -1227.2) end");
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000542F File Offset: 0x0000362F
		private void flatButton78_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1548.20093, 17.7475166, 701.546997) end");
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004BCF File Offset: 0x00002DCF
		private void flatButton77_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(376.6, 18.3, -1686.9) end");
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005443 File Offset: 0x00003643
		private void flatButton74_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(115.2, 18.9, -1766.6) end");
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005457 File Offset: 0x00003657
		private void flatButton79_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-956.153564, 19.8500576, -1451.23572) end");
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005039 File Offset: 0x00003239
		private void flatButton81_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(144.794067, 17.6189003, 768.572693) end");
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000546B File Offset: 0x0000366B
		private void flatButton80_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1499.6, 50.2, 1803.1) end");
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000547F File Offset: 0x0000367F
		private void flatButton83_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(598.6, 38.3, 1646.6) end");
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005493 File Offset: 0x00003693
		private void flatButton82_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(245.938766, 17.6064777, 1372.15076) end");
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004BCF File Offset: 0x00002DCF
		private void flatButton85_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(376.6, 18.3, -1686.9) end");
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000054A7 File Offset: 0x000036A7
		private void flatButton86_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1453.4, 25.6, 201.4) end");
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004BCF File Offset: 0x00002DCF
		private void flatButton84_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(376.6, 18.3, -1686.9) end");
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000054BB File Offset: 0x000036BB
		private void flatButton45_Click(object sender, EventArgs e)
		{
			this.api.SendScript("getglobal game\r\ngetfield -1 Workspace\r\ngetfield -1 Doors\r\ngetfield -1 Destroy\r\npushvalue -2\r\npcall 1 0 0\r\nemptystack");
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004BCF File Offset: 0x00002DCF
		private void flatButton73_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(376.6, 18.3, -1686.9) end");
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000054A7 File Offset: 0x000036A7
		private void flatButton56_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1453.4, 25.6, 201.4) end");
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000546B File Offset: 0x0000366B
		private void flatButton65_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1499.6, 50.2, 1803.1) end");
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000547F File Offset: 0x0000367F
		private void flatButton87_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(598.6, 38.3, 1646.6) end");
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00005493 File Offset: 0x00003693
		private void flatButton54_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(245.938766, 17.6064777, 1372.15076) end");
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000054CF File Offset: 0x000036CF
		private void flatButton78_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("_G.JP = 100;\r\n            local Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\r\n            Humanoid: GetPropertyChangedSignal('JumpPower'):Connect(function()\r\n             Humanoid.JumpPower = _G.JP;\r\n            end)\r\nHumanoid.WalkSpeed = _G.JP;");
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000054E3 File Offset: 0x000036E3
		private void flatButton74_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1167.1, 18.7, -1374.5) end");
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000054F7 File Offset: 0x000036F7
		private void flatButton77_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1130.11426, 17.950058, -1593.09766) end");
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000550B File Offset: 0x0000370B
		private void flatButton79_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1112.11475, 101.16069, 1290.57654) end");
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000551F File Offset: 0x0000371F
		private void flatButton81_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1188.7, 18.4, -1536.1) end");
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005533 File Offset: 0x00003733
		private void flatButton82_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-222.339157, 17.9125443, 1575.82336) end");
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00005547 File Offset: 0x00003747
		private void flatButton80_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1579.4823, 49.787693, -1759.61438) end");
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000555B File Offset: 0x0000375B
		private void flatButton70_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("while true do for i,v in pairs(game.Teams.Criminal:GetPlayers()) do p=game:GetService('Players') e=Instance.new('BoxHandleAdornment') e.Color3=Color3.new(255,0,0) e.Size=Vector3.new(2,1.6,1) e.ZIndex=1 e.AlwaysOnTop=true e.Parent=game:GetService('Workspace') e.Adornee=v.Character.UpperTorso end wait(5) e:Destroy() end");
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000556F File Offset: 0x0000376F
		private void flatButton71_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("while true do for i, v in pairs(game.Teams.Police:GetPlayers()) do p = game:GetService('Players') e = Instance.new('BoxHandleAdornment') e.Color3 = Color3.new(0,0,1) e.Size = Vector3.new(2,1.6,1) e.ZIndex = 1 e.AlwaysOnTop = true e.Parent = game:GetService('Workspace') e.Adornee = v.Character.UpperTorso end wait(5) e:Destroy() end");
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00005583 File Offset: 0x00003783
		private void flatButton72_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("while true do for i,v in pairs(game.Teams.Prisoner:GetPlayers()) do p=game:GetService('Players') e=Instance.new('BoxHandleAdornment') e.Color3=Color3.new(255,77,0) e.Size=Vector3.new(2,1.6,1) e.ZIndex=1 e.AlwaysOnTop=true e.Parent=game:GetService('Workspace') e.Adornee=v.Character.UpperTorso end wait(5) e:Destroy() end");
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00005597 File Offset: 0x00003797
		private void flatButton47_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press R to fly while in a car!");
			this.api.SendLimitedLuaScript("local plr = game:GetService'Players'.LocalPlayer\r\nlocal m = plr:GetMouse()\r\nm.KeyDown:connect(function(k)\r\nif k:byte() == 114 then\r\nplrh = game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid'\r\nplrh:ChangeState('Jumping')\r\nwait()\r\nplrh:ChangeState('Seated')\r\nend\r\nend)");
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000055B6 File Offset: 0x000037B6
		private void flatButton46_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1541.10388, 17.746624, 729) end");
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000055CA File Offset: 0x000037CA
		private void flatButton48_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1312.1, 18.1, 376) end");
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000055DE File Offset: 0x000037DE
		private void flatButton55_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(578.7, 17.8, -460.1) end");
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000055F2 File Offset: 0x000037F2
		private void flatButton53_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1473.9, -0.30, -1877.6) end");
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00005606 File Offset: 0x00003806
		private void flatButton52_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-453.2, 13.6, 418.2) end");
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000561A File Offset: 0x0000381A
		private void flatButton64_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(391.1, 43.1, -1722.9) end");
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000562E File Offset: 0x0000382E
		private void flatButton58_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1355.2417, 18, -1531.86047) end");
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005642 File Offset: 0x00003842
		private void flatButton22_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-111.571999, 17.6169529, 541.515747) end");
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005656 File Offset: 0x00003856
		private void flatButton83_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Note: You must have full duffle bag for this to work! We will improve it in the next update!");
			this.api.SendLimitedLuaScript("while true do wait(10) local plr = game:GetService('Players').LocalPlayer if game:GetService('Workspace').Banks:GetChildren()[1].Extra.Sign.Decal.Transparency ~= 0 then for i = 1,50 do wait(0.12) plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,835.9) end wait(2) plr.Character.HumanoidRootPart.CFrame = CFrame.new(51.3, 18.6, 857.9) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(28.16, 1.5, 816.20) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(20,1.5,816.20) for i = 1,150 do wait(1) if plr.PlayerGui.MainGui.CollectMoney.Money.Text == ('$3,000') then plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,895.9) plr.PlayerGui.MainGui.CollectMoney.Money.Text = ('3,00O') wait(60) end end else warn('The Bank is Closed!') end end");
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00005675 File Offset: 0x00003875
		private void flatButton69_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Parent = game.Lighting\r\n                                 game.Lighting.HumanoidRootPart.Parent = game:GetService('Players').LocalPlayer.Character");
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00005689 File Offset: 0x00003889
		private void flatButton60_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-653.4, 20.4, -246.4) end");
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000569D File Offset: 0x0000389D
		private void flatButton49_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1957.1, 68.8, -604) end");
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00005407 File Offset: 0x00003607
		private void flatButton57_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-97.5, 18.3, -1724) end");
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000541B File Offset: 0x0000361B
		private void flatButton61_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(761.3, 18.5, -1227.2) end");
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000550B File Offset: 0x0000370B
		private void flatButton66_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1112.11475, 101.16069, 1290.57654) end");
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000551F File Offset: 0x0000371F
		private void flatButton62_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1188.7, 18.4, -1536.1) end");
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000054E3 File Offset: 0x000036E3
		private void flatButton63_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1167.1, 18.7, -1374.5) end");
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004BCF File Offset: 0x00002DCF
		private void flatButton59_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(376.6, 18.3, -1686.9) end");
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00005547 File Offset: 0x00003747
		private void flatButton44_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1579.4823, 49.787693, -1759.61438) end");
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatButton51_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000056B1 File Offset: 0x000038B1
		private void flatButton74_Click_2(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local gui = Instance.new('BillboardGui'); gui.Name = ''; gui.AlwaysOnTop = true; gui.LightInfluence = 0; gui.Size = UDim2.new(1.75, 0, 1.75, 0); local frame = Instance.new('Frame', gui); frame.BackgroundColor3 = Color3.fromRGB(170, 0, 0); frame.Size = UDim2.new(1, 0, 1, 0); frame.BorderSizePixel = 4; frame.BorderColor3 = Color3.fromRGB(0, 0, 0); local gi = gui:Clone(); local body = frame:Clone(); body.Parent = gi; body.BackgroundColor3 = Color3.fromRGB(0, 170, 170); for _, v in pairs(game:GetService('Players'):GetPlayers()) do if v.Name ~= game:GetService('Players').LocalPlayer.Name and v.Character and v.Character:FindFirstChild('Torso') then gui:Clone().Parent = v.Character.Torso; end end local gui = Instance.new('BillboardGui'); gui.Name = ''; gui.AlwaysOnTop = true; gui.LightInfluence = 0; gui.Size = UDim2.new(1.25, 0, 1.25, 0); local frame = Instance.new('Frame', gui); frame.BackgroundColor3 = Color3.fromRGB(170, 0, 0); frame.Size = UDim2.new(0.75, 0, 0.75, 0); frame.BorderSizePixel = 4; frame.BorderColor3 = Color3.fromRGB(0, 0, 0); local gi = gui:Clone(); local body = frame:Clone(); body.Parent = gi; body.BackgroundColor3 = Color3.fromRGB(0, 170, 170); for _, v in pairs(game:GetService('Players'):GetPlayers()) do if v.Name ~= game:GetService('Players').LocalPlayer.Name and v.Character and v.Character:FindFirstChild('Head') then gui:Clone().Parent = v.Character.Head; end end");
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000056C5 File Offset: 0x000038C5
		private void flatButton42_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local plr = game:GetService'Players'.LocalPlayer local m = plr:GetMouse() m.KeyDown:connect(function(k) if k == ' ' then game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Jumping') wait() game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Seated') end end)");
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000056D9 File Offset: 0x000038D9
		private void flatButton75_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(" local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftControl) then return end if not Mouse.Target then return end Mouse.Target:Destroy() end)");
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000056ED File Offset: 0x000038ED
		private void flatButton76_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("You get more money when you sell the things in the water.");
			this.api.SendLimitedLuaScript("game.ReplicatedStorage.Connection:InvokeServer(9,2)game.ReplicatedStorage.Connection:InvokeServer(50)game.ReplicatedStorage.PlayerData[game.Players.LocalPlayer.UserId].PLUS.Value = true while wait() do game.ReplicatedStorage.Connection:InvokeServer(49)game.ReplicatedStorage.Connection:InvokeServer(51)end");
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000570C File Offset: 0x0000390C
		private void flatButton77_Click_2(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1078.45, 153.904, 1176.52) + Vector3.new(1,0,0)");
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00005720 File Offset: 0x00003920
		private void flatButton80_Click_2(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1132.674, 100.412, 1230.48) + Vector3.new(1,0,0)");
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00005734 File Offset: 0x00003934
		private void flatButton79_Click_2(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1063.02, 117.562, 1218.757) + Vector3.new(1,0,0)");
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00005748 File Offset: 0x00003948
		private void flatButton78_Click_2(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("boy = game:GetService('Workspace') nah = boy:FindFirstChild('Museum') nah.CaseLasers:Destroy()");
			this.api.SendLimitedLuaScript("boy = game:GetService('Workspace') nah = boy:FindFirstChild('Museum') nah.Doors:Destroy()");
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000576D File Offset: 0x0000396D
		private void flatButton81_Click_2(object sender, EventArgs e)
		{
			this.api.SendScript("getglobal game\ngetfield -1 GetService\npushvalue -2\npushstring Lighting\npcall 2 1 0\npushnumber 100\nsetfield -2 FogEnd\nemptystack");
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005781 File Offset: 0x00003981
		private void flatButton82_Click_2(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game.Workspace.Buildings:Destroy()");
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00005795 File Offset: 0x00003995
		private void flatButton84_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i,v in pairs(game:GetService('Workspace').Buildings:GetChildren()) do v.CanCollide = false end");
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000056D9 File Offset: 0x000038D9
		private void flatButton85_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(" local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftControl) then return end if not Mouse.Target then return end Mouse.Target:Destroy() end)");
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatButton86_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatButton86_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000057A9 File Offset: 0x000039A9
		private void flatButton86_Click_3(object sender, EventArgs e)
		{
			Process.Start("https://nonsensediamond.website/");
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000057B7 File Offset: 0x000039B7
		private void flatButton89_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(-1585, 622, 1140)\nscript:Destroy()");
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000057CB File Offset: 0x000039CB
		private void flatButton88_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(265, 3, 57)\nscript:Destroy()");
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000057DF File Offset: 0x000039DF
		private void flatButton93_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local function longTP(a,b,c)\noldg = Workspace.Gravity\nWorkspace.Gravity = 0\nav = 0\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = true\nwait(1)\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.Anchored = false\nwhile av < 15 do\ngame:GetService(\"Players\").LocalPlayer.character.HumanoidRootPart.CFrame = CFrame.new(a,b,c)\nav = av + 1\nwait(0.3)\nend\nWorkspace.Gravity = oldg\nend\nlongTP(491, 3, -1720)\nscript:Destroy()");
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004C45 File Offset: 0x00002E45
		private void richTextBox11_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000057F3 File Offset: 0x000039F3
		private void flatButton91_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(3581, -179, 430)");
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005807 File Offset: 0x00003A07
		private void flatButton90_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(2549, -5, -42)");
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000581B File Offset: 0x00003A1B
		private void flatButton92_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(323, 41, 1930)");
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000582F File Offset: 0x00003A2F
		private void flatButton99_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1114, -1, -197)");
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005843 File Offset: 0x00003A43
		private void flatButton95_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(5207, -166, 719)");
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatButton102_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004C45 File Offset: 0x00002E45
		private void tabPage11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005857 File Offset: 0x00003A57
		private void flatButton98_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(113, -214, -951)");
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000586B File Offset: 0x00003A6B
		private void flatButton96_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(113, 11, -977)");
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000587F File Offset: 0x00003A7F
		private void flatButton104_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(4604, -3, -727)");
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005893 File Offset: 0x00003A93
		private void flatButton105_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1209, 132, -801)");
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000058A7 File Offset: 0x00003AA7
		private void flatButton97_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(509, 3, -1463)");
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000058BB File Offset: 0x00003ABB
		private void flatButton108_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1600, 195, 919)");
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000058CF File Offset: 0x00003ACF
		private void flatButton107_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(155, 3, 74)");
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000058E3 File Offset: 0x00003AE3
		private void flatButton94_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(260, 8, -2542)");
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000058F7 File Offset: 0x00003AF7
		private void flatButton103_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("_G.WS = 200;\r\n            local Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\r\n            Humanoid: GetPropertyChangedSignal('WalkSpeed'):Connect(function()\r\n             Humanoid.WalkSpeed = _G.WS;\r\n            end)\r\nHumanoid.WalkSpeed = _G.WS;");
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000056D9 File Offset: 0x000038D9
		private void flatButton106_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(" local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftControl) then return end if not Mouse.Target then return end Mouse.Target:Destroy() end)");
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000590B File Offset: 0x00003B0B
		private void flatButton109_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local team = game:GetService('Teams').Police:Clone()team.Parent = game:GetService('Teams')team.Name = 'Diamond Crew Team.TeamColor = BrickColor.new('Really purple')game:GetService('Players').LocalPlayer.TeamValue.Value = 'Diamond Crewgame:GetService('Players').LocalPlayer.Team = game:GetService('Teams').Diamond Crew");
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000591F File Offset: 0x00003B1F
		private void flatButton110_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').Name = 'Players' game.Players.LocalPlayer.leaderstats.Money.Value = 99999999");
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005933 File Offset: 0x00003B33
		private void flatButton111_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.PlayerGui.MainGui.Ammo.MagSize.RobloxLocked=true");
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004C45 File Offset: 0x00002E45
		private void tabPage7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005947 File Offset: 0x00003B47
		private void flatButton115_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftAlt) then return end if not Mouse.Target then return end Plr.Character:MoveTo(Mouse.Hit.p) end)");
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000595B File Offset: 0x00003B5B
		private void flatButton116_Click(object sender, EventArgs e)
		{
			this.api.SendScript("getglobal print\r\npushstring hello world!\r\npcall 1 0 0");
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000596F File Offset: 0x00003B6F
		private void flatButton117_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox38.Text);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005989 File Offset: 0x00003B89
		private void flatButton138_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Might work only once!");
			this.api.SendScript(this.richTextBox26.Text);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatButton100_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000059AE File Offset: 0x00003BAE
		private void flatButton114_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("vlocal hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Flashlight' then v.CFrame = CFrame.new(hit) end end end end end");
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000059C2 File Offset: 0x00003BC2
		private void flatButton68_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Note: For Small duffle!!");
			this.api.SendLimitedLuaScript("while true do wait(10) local plr = game:GetService('Players').LocalPlayer if game:GetService('Workspace').Banks:GetChildren()[1].Extra.Sign.Decal.Transparency ~= 0 then for i = 1,50 do wait(0.12) plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,835.9) end wait(2) plr.Character.HumanoidRootPart.CFrame = CFrame.new(51.3, 18.6, 857.9) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(28.16, 1.5, 816.20) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(20,1.5,816.20) for i = 1,150 do wait(1) if plr.PlayerGui.MainGui.CollectMoney.Money.Text == ('$1,500') then plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,895.9) plr.PlayerGui.MainGui.CollectMoney.Money.Text = ('1,50O') wait(60) end end else warn('The Bank is Closed!') end end");
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000059E1 File Offset: 0x00003BE1
		private void flatButton113_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Binoculars' then v.CFrame = CFrame.new(hit) end end end end end");
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000059F5 File Offset: 0x00003BF5
		private void flatButton112_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("while wait(2) do game:GetService('Workspace').TouchTrigger.Donut.Position = game:GetService('Players').LocalPlayer.Character.Head.Position end");
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005A09 File Offset: 0x00003C09
		private void flatButton131_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game: GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(- 500, 45, -1150)");
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005A1D File Offset: 0x00003C1D
		private void flatButton130_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-2000, 45, 1622)");
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005A31 File Offset: 0x00003C31
		private void flatButton127_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1100, 45, -2700)");
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005A45 File Offset: 0x00003C45
		private void flatButton126_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1500, 45, 2500)");
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005A59 File Offset: 0x00003C59
		private void flatButton129_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-2900, 45, 900)");
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005A6D File Offset: 0x00003C6D
		private void flatButton128_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-2950, 45, 150)");
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005A81 File Offset: 0x00003C81
		private void flatButton123_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-3302, 45, 465)game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-3302, 45, 465)");
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005A95 File Offset: 0x00003C95
		private void flatButton122_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1800, 45, -1200)");
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005AA9 File Offset: 0x00003CA9
		private void flatButton124_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(300, 45, 770)");
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00005ABD File Offset: 0x00003CBD
		private void flatButton125_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-450, 45, -3550)");
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005AD1 File Offset: 0x00003CD1
		private void flatButton121_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(2600, 91, -2800)");
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005AE5 File Offset: 0x00003CE5
		private void flatButton120_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1500, 45, 470)");
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005AF9 File Offset: 0x00003CF9
		private void flatButton119_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-2800, 45, -390)");
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005B0D File Offset: 0x00003D0D
		private void flatButton118_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Type /e speedhack to activate speedhack. Type /e stop to use AFK while driving at high speed. ", "May Not work very well", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.api.SendLimitedLuaScript("local plr = game.Players.LocalPlayer local inftoggle = false function getvehicle() for i,v in pairs(game.Workspace.Vehicles:GetChildren()) do if v:IsA('Model') then if v.owner.Value == plr.Name then return v end end end return nil end function hint(txt, t) if t then local h = Instance.new('Hint',plr.PlayerGui) h.Text = txt wait(t) h:remove() else local h = Instance.new('Hint',plr.PlayerGui) h.Text = txt wait(2) h:remove() end end plr.Chatted:connect(function(msg) if msg:lower():sub(1,10) == '/e toggle' then local ins = msg:lower():sub(11) local vehicle = getvehicle() if vehicle then if ins == 'infnitro' then if inftoggle == true then inftoggle = false hint('(-)Disabled Infinite Nitro!(-)') else inftoggle = true hint('(+)Enabled Infinite Nitro!(+)') end end else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,14) == '/e nitrospeed' then local num = msg:sub(15) local vehicle = getvehicle() if vehicle then vehicle.Handling.Nitro.NitroSpeed.Value = tonumber(num) else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,14) == '/e stop' then local num = msg:sub(1,15) local vehicle = getvehicle() if vehicle then vehicle.Chassis.VehicleSeat.Anchored = true else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,14) == '/e nitroforce' then local num = msg:sub(1,15) local vehicle = getvehicle() if vehicle then vehicle.Handling.Nitro.NitroForce.Value = tonumber(num) else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,12) == '/e maxspeed' then local num = msg:sub(13) local vehicle = getvehicle() if vehicle then vehicle.Handling.MaxSpeed.Value = tonumber(num) else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,10) == '/e torque' then local num = msg:sub(11) local vehicle = getvehicle() if vehicle then vehicle.Handling.Torque.Value = tonumber(num) else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,12) == '/e friction' then local num = msg:sub(13) local vehicle = getvehicle() if vehicle then vehicle.Handling.FrictionOffroad.Value = tonumber(num) vehicle.Handling.FrictionRoad.Value = tonumber(num) else hint('(-)You do not have a vehicle spawned!(-)') end elseif msg:lower():sub(1,13) == '/e speedhack' then local vehicle = getvehicle() if vehicle then han = vehicle.Handling han.MaxSpeed.Value = 10000 han.Torque.Value = 30000 han.SteeringRadiusConstant.Value = 12000 han.FrictionOffroad.Value = 200 han.FrictionRoad.Value = 200 han.Nitro.NitroSpeed.Value = 300 han.Nitro.NitroForce.Value = 8000 han.TurboJump.TurboJumpHeight.Value = 300 inftoggle = true else hint('(-)You do not have a vehicle spawned!(-)') end end end) wait(0.5) while inftoggle == true do wait(0.02) local vehicle = getvehicle() if vehicle then vehicle.Handling.Nitro.NitroAmount.Value = 250 end end");
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004C45 File Offset: 0x00002E45
		private void tabPage9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005B34 File Offset: 0x00003D34
		private void flatButton109_Click_1(object sender, EventArgs e)
		{
			this.api.SendScript(this.richTextBox27.Text);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005B4E File Offset: 0x00003D4E
		private void flatButton111_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game.ReplicatedStorage.PlayerData[game.Players.LocalPlayer.UserId].ChalkPass.Value = true");
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005B62 File Offset: 0x00003D62
		private void flatButton132_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game.ReplicatedStorage.PlayerData[game.Players.LocalPlayer.UserId].BoomBox.Value = true");
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00005B76 File Offset: 0x00003D76
		private void flatButton101_Click(object sender, EventArgs e)
		{
			this.api.SendScript(this.richTextBox28.Text);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00005B90 File Offset: 0x00003D90
		private void flatButton133_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press F9 to check. ", "Detective Diamante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.api.SendLimitedLuaScript("for i,v in pairs(game.Players:GetChildren()) do if v.Backpack.Knife ~= nil or v.Character.Knife ~= nil then print(v.Name .. ' is murderer') end end for i,v in pairs(game.Players:GetChildren()) do if v.Backpack.Gun ~= nil or v.Backpack.Revolver ~= nil or v.Character.Gun ~= nil or v.Character.Revolver ~= nil then print(v.Name .. ' is sheriff') end end if workspace.GunDrop ~= nil then game.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(workspace.GunDrop.Position) end");
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005BB7 File Offset: 0x00003DB7
		private void flatButton134_Click(object sender, EventArgs e)
		{
			this.api.SendScript(this.richTextBox29.Text);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005BD1 File Offset: 0x00003DD1
		private void flatButton135_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.Humanoid.Name = 1 local l = game:GetService('Players').LocalPlayer.Character['1']:Clone() l.Parent = game:GetService('Players').LocalPlayer.Character l.Name = 'Humanoid' wait(0.1) game:GetService('Players').LocalPlayer.Character['1']:Destroy() game:GetService('Workspace').CurrentCamera.CameraSubject = game:GetService('Players').LocalPlayer.Character game:GetService('Players').LocalPlayer.Character.Animate.Disabled = true wait(0.1) game:GetService('Players').LocalPlayer.Character.Animate.Disabled = false game:GetService('Players').LocalPlayer.Character.Humanoid.DisplayDistanceType = 'None'");
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005BE5 File Offset: 0x00003DE5
		private void flatButton136_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("while wait(1) do for i,v in pairs(game.Workspace:GetChildren()) do local f = v:FindFirstChild('CoinContainer') local q = game.Players.LocalPlayer.Character:FindFirstChild('Torso') if q and f then for i,c in pairs(f:GetChildren()) do c.CFrame = game.Players.LocalPlayer.Character.Torso.CFrame end end end end");
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000595B File Offset: 0x00003B5B
		private void flatButton116_Click_1(object sender, EventArgs e)
		{
			this.api.SendScript("getglobal print\r\npushstring hello world!\r\npcall 1 0 0");
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00005BF9 File Offset: 0x00003DF9
		private void flatButton144_Click(object sender, EventArgs e)
		{
			this.formSkin1.FlatColor = Color.Purple;
			this.panel2.BackColor = Color.FromArgb(64, 0, 64);
			this.formSkin1.Refresh();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005C30 File Offset: 0x00003E30
		private void flatButton143_Click(object sender, EventArgs e)
		{
			this.formSkin1.FlatColor = Color.FromArgb(214, 187, 24);
			this.panel2.BackColor = Color.FromArgb(171, 150, 22);
			this.formSkin1.Refresh();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005C84 File Offset: 0x00003E84
		private void flatButton142_Click(object sender, EventArgs e)
		{
			this.formSkin1.FlatColor = Color.Teal;
			this.panel2.BackColor = Color.FromArgb(21, 109, 89);
			this.formSkin1.Refresh();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005CBB File Offset: 0x00003EBB
		private void flatButton141_Click(object sender, EventArgs e)
		{
			this.formSkin1.FlatColor = Color.Red;
			this.panel2.BackColor = Color.FromArgb(154, 12, 12);
			this.formSkin1.Refresh();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005CF5 File Offset: 0x00003EF5
		private void flatButton140_Click(object sender, EventArgs e)
		{
			this.formSkin1.FlatColor = Color.FromArgb(216, 127, 15);
			this.panel2.BackColor = Color.OrangeRed;
			this.formSkin1.Refresh();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005D2F File Offset: 0x00003F2F
		private void flatButton139_Click(object sender, EventArgs e)
		{
			this.formSkin1.FlatColor = Color.Blue;
			this.panel2.BackColor = Color.MidnightBlue;
			this.formSkin1.Refresh();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005D60 File Offset: 0x00003F60
		private void flatButton137_Click(object sender, EventArgs e)
		{
			this.formSkin1.FlatColor = Color.Green;
			this.panel2.BackColor = Color.DarkGreen;
			this.formSkin1.Refresh();
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005D91 File Offset: 0x00003F91
		private void flatButton145_Click(object sender, EventArgs e)
		{
			this.formSkin1.FlatColor = Color.CadetBlue;
			this.panel2.BackColor = Color.FromArgb(142, 165, 162);
			this.formSkin1.Refresh();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005DD1 File Offset: 0x00003FD1
		private void flatButton150_Click(object sender, EventArgs e)
		{
			MessageBox.Show("HowToUse: Find any car, go into the passenger seat and press jump. - Credits to iNatusDope for making this awesome script.");
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.Humanoid.Name = 'Humanoida\ngame: GetService('Players').LocalPlayer.Character.Humanoida.WalkSpeed = 160");
			this.api.SendLimitedLuaScript("local InfiniteJumpEnabled = true\ngame: GetService('UserInputService').JumpRequest:connect(function()\nif InfiniteJumpEnabled then\ngame:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Jumping')\nend\nend)");
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00005E01 File Offset: 0x00004001
		private void flatButton149_Click(object sender, EventArgs e)
		{
			this.formSkin1.FlatColor = Color.Black;
			this.panel2.BackColor = Color.FromArgb(54, 54, 54);
			this.formSkin1.Refresh();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00005E38 File Offset: 0x00004038
		private void flatButton148_Click(object sender, EventArgs e)
		{
			this.formSkin1.FlatColor = Color.Gray;
			this.panel2.BackColor = Color.FromArgb(26, 24, 24);
			this.formSkin1.Refresh();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00005E6F File Offset: 0x0000406F
		private void flatButton146_Click(object sender, EventArgs e)
		{
			this.formSkin1.FlatColor = Color.DeepSkyBlue;
			this.panel2.BackColor = Color.FromArgb(5, 193, 168);
			this.formSkin1.Refresh();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00005EAB File Offset: 0x000040AB
		private void flatButton147_Click(object sender, EventArgs e)
		{
			this.formSkin1.FlatColor = Color.DeepPink;
			this.panel2.BackColor = Color.FromArgb(208, 4, 179);
			this.formSkin1.Refresh();
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatButton116_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00005EE7 File Offset: 0x000040E7
		private void flatButton155_Click(object sender, EventArgs e)
		{
			this.api.SendScript(this.richTextBox15.Text);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005F01 File Offset: 0x00004101
		private void flatButton154_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press X to ON/OFF ESP.");
			this.api.SendLimitedLuaScript("local ReplicatedStorage = game:GetService('ReplicatedStorage') local Players = game:GetService('Players') local mouse = Players.LocalPlayer:GetMouse() local a = false mouse.KeyDown:Connect(function(key)if key == 'x' then if a == false then pcall(function() game.Workspace.Map.Parent = ReplicatedStorage end) if game.Workspace:FindFirstChild('#elta') ~= nil then game.Workspace:WaitForChild('#elta'):Destroy() end local abc = Instance.new('Part', workspace) abc.Anchored = true abc.Name = '#elta' abc.Size = Vector3.new(2048, 1, 2048) abc.CFrame = CFrame.new(Players.LocalPlayer.Character.HumanoidRootPart.CFrame.X, Players.LocalPlayer.Character.HumanoidRootPart.CFrame.Y -10, Players.LocalPlayer.Character.HumanoidRootPart.CFrame.Z) a = true elseif a == true then pcall(function() ReplicatedStorage.Map.Parent = game.Workspace end) if game.Workspace:FindFirstChild('#elta') ~= nil then game.Workspace:WaitForChild('#elta'):Destroy() end a = false end end end)");
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00005F20 File Offset: 0x00004120
		private void flatButton153_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local name = game.Players.LocalPlayer.Name local plr = game.Workspace.Characters[name] for i, v in pairs(workspace['Crate_Spawns']:children()) do  v: MoveTo(plr.Head.Position + Vector3.new(math.random(-15, 15), 0, math.random(-15, 15))) end");
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005947 File Offset: 0x00003B47
		private void flatButton152_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftAlt) then return end if not Mouse.Target then return end Plr.Character:MoveTo(Mouse.Hit.p) end)");
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005F34 File Offset: 0x00004134
		private void flatButton156_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Equip your scoop then go to the field and press the button if you remove your scoop press the button again");
			this.api.SendLimitedLuaScript("while wait() do game.Players.LocalPlayer.character.+ textbox.text +.ClickEvent:FireServer(CFrame.new()) end");
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005F54 File Offset: 0x00004154
		private void flatButton151_Click(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005F8A File Offset: 0x0000418A
		private void flatButton156_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(" local char = game:GetService('Players').LocalPlayer.Character local function collect(folder) for _,part in ipairs(folder:GetChildren()) do if part.Parent then char:MoveTo(part.Position) wait(0.5)end end end collect(workspace.TreasureCollectibles) collect(workspace.Treasures)");
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004C45 File Offset: 0x00002E45
		private void tabPage17_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000056C5 File Offset: 0x000038C5
		private void flatButton159_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local plr = game:GetService'Players'.LocalPlayer local m = plr:GetMouse() m.KeyDown:connect(function(k) if k == ' ' then game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Jumping') wait() game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Seated') end end)");
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005947 File Offset: 0x00003B47
		private void flatButton163_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftAlt) then return end if not Mouse.Target then return end Plr.Character:MoveTo(Mouse.Hit.p) end)");
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000056D9 File Offset: 0x000038D9
		private void flatButton167_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(" local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftControl) then return end if not Mouse.Target then return end Mouse.Target:Destroy() end)");
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00005F9E File Offset: 0x0000419E
		private void flatButton158_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game.Workspace.Doors:Destroy()");
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00005FB2 File Offset: 0x000041B2
		private void flatButton162_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local weapons = {'Crude Knife', 'Sharpened stick', 'Extendo mirror'} for i, v in pairs(game.ReplicatedStorage.Tools:GetChildren()) do for j, k in pairs(weapons) do if v.Name == k then v:Clone().Parent = game.Players.LocalPlayer.Backpack end end end");
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00005FC6 File Offset: 0x000041C6
		private void flatButton166_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local mouse = game.Players.LocalPlayer:GetMouse() local arrestEvent = game.Workspace.Remote.arrest mouse.Button1Down:connect(function() local obj = mouse.Target local response = arrestEvent:InvokeServer(obj) end)");
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005FDA File Offset: 0x000041DA
		private void flatButton157_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local weapons = {'Remington 870', 'M9', 'AK-47', 'M4A1', 'Riot Shield'} for i, v in pairs(game.Workspace['Prison_ITEMS'].giver:GetChildren()) do for j, k in pairs(weapons) do if v.Name == k then v:MoveTo(game.Players.LocalPlayer.Character.Torso.Position) end end end");
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00005BD1 File Offset: 0x00003DD1
		private void flatButton161_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.Humanoid.Name = 1 local l = game:GetService('Players').LocalPlayer.Character['1']:Clone() l.Parent = game:GetService('Players').LocalPlayer.Character l.Name = 'Humanoid' wait(0.1) game:GetService('Players').LocalPlayer.Character['1']:Destroy() game:GetService('Workspace').CurrentCamera.CameraSubject = game:GetService('Players').LocalPlayer.Character game:GetService('Players').LocalPlayer.Character.Animate.Disabled = true wait(0.1) game:GetService('Players').LocalPlayer.Character.Animate.Disabled = false game:GetService('Players').LocalPlayer.Character.Humanoid.DisplayDistanceType = 'None'");
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005FEE File Offset: 0x000041EE
		private void flatButton165_Click(object sender, EventArgs e)
		{
			this.api.SendScript(this.richTextBox16.Text);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004C45 File Offset: 0x00002E45
		private void richTextBox16_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00006008 File Offset: 0x00004208
		private void flatButton160_Click(object sender, EventArgs e)
		{
			this.api.SendScript(this.richTextBox30.Text);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00006022 File Offset: 0x00004222
		private void flatButton164_Click(object sender, EventArgs e)
		{
			this.api.SendScript(this.richTextBox31.Text);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000603C File Offset: 0x0000423C
		private void flatButton170_Click(object sender, EventArgs e)
		{
			this.api.SendScript(this.richTextBox32.Text);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00006056 File Offset: 0x00004256
		private void flatButton169_Click(object sender, EventArgs e)
		{
			this.api.SendScript(this.richTextBox33.Text);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00006070 File Offset: 0x00004270
		private void flatButton168_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new (283, 72, 2213)");
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00006084 File Offset: 0x00004284
		private void flatButton116_Click_3(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("_G.WalkSpeed = 150 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00004C45 File Offset: 0x00002E45
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00006098 File Offset: 0x00004298
		private void flatButton150_Click_1(object sender, EventArgs e)
		{
			this.api.SendScript(this.richTextBox37.Text);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004C45 File Offset: 0x00002E45
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00005BD1 File Offset: 0x00003DD1
		private void flatButton179_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.Humanoid.Name = 1 local l = game:GetService('Players').LocalPlayer.Character['1']:Clone() l.Parent = game:GetService('Players').LocalPlayer.Character l.Name = 'Humanoid' wait(0.1) game:GetService('Players').LocalPlayer.Character['1']:Destroy() game:GetService('Workspace').CurrentCamera.CameraSubject = game:GetService('Players').LocalPlayer.Character game:GetService('Players').LocalPlayer.Character.Animate.Disabled = true wait(0.1) game:GetService('Players').LocalPlayer.Character.Animate.Disabled = false game:GetService('Players').LocalPlayer.Character.Humanoid.DisplayDistanceType = 'None'");
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000520F File Offset: 0x0000340F
		private void flatButton174_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press 'G' to use rainbow path.");
			this.api.SendLimitedLuaScript("local player = game:GetService('Players').LocalPlayer local mouse = player:GetMouse() mouse.KeyDown:connect(function(key) if key:lower() == 'g' or key:upper() == 'G' then for i = 1,6 do wait(0.25) x = Instance.new('Part',game:GetService('Workspace')) x.Size = Vector3.new(10,0.2,10) x.TopSurface = 'Smooth' x.Anchored = true x.BrickColor = BrickColor.random()  x.CFrame = CFrame.new(player.Character.UpperTorso.Position) + Vector3.new(0,-3,0) game.Debris:AddItem(x, 3) end end end)");
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000060B2 File Offset: 0x000042B2
		private void flatButton178_Click(object sender, EventArgs e)
		{
			this.api.SendScript(this.richTextBox34.Text);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000060CC File Offset: 0x000042CC
		private void flatButton175_Click(object sender, EventArgs e)
		{
			MessageBox.Show("I recommend you to use God Mode when using this!");
			this.api.SendScript(this.richTextBox35.Text);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000056C5 File Offset: 0x000038C5
		private void flatButton177_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local plr = game:GetService'Players'.LocalPlayer local m = plr:GetMouse() m.KeyDown:connect(function(k) if k == ' ' then game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Jumping') wait() game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Seated') end end)");
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000060F1 File Offset: 0x000042F1
		private void flatButton176_Click(object sender, EventArgs e)
		{
			this.api.SendScript(this.richTextBox36.Text);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00006084 File Offset: 0x00004284
		private void flatButton171_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("_G.WalkSpeed = 150 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000610B File Offset: 0x0000430B
		private void flatButton173_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("_G.WalkSpeed = 16 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000056D9 File Offset: 0x000038D9
		private void flatButton172_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(" local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftControl) then return end if not Mouse.Target then return end Mouse.Target:Destroy() end)");
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000611F File Offset: 0x0000431F
		private void flatButton183_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.roblox.com/games/606849621/Jailbreak?privateServerLinkCode=iEAQS9K1JmE7ioc_mXhQgq54_Wfnzjk-");
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000612D File Offset: 0x0000432D
		private void flatButton182_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.roblox.com/games/292439477/New-Steel-II-Phantom-Forces?privateServerLinkCode=OnIil4GSjlsb73sekbTr63xMQFBVQ8pw");
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000613B File Offset: 0x0000433B
		private void flatButton181_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.roblox.com/games/142823291/Murder-Mystery-2?privateServerLinkCode=1PaSoh7zBz-Nw6PgwAp4JuonvULvdO37");
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006149 File Offset: 0x00004349
		private void flatButton180_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.roblox.com/games/1320186298/Island-Royale-Beta?privateServerLinkCode=owSKpCjpM6HAa-RR9lW1ibjIe58CJk8g");
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00006157 File Offset: 0x00004357
		private void flatButton185_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Note: You must have full duffel bag for this to work!");
			this.api.SendLimitedLuaScript("while true do wait(10) local plr = game:GetService('Players').LocalPlayer if game:GetService('Workspace').Banks:GetChildren()[1].Extra.Sign.Decal.Transparency ~= 0 then for i = 1,50 do wait(0.12) plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,835.9) end wait(2) plr.Character.HumanoidRootPart.CFrame = CFrame.new(51.3, 18.6, 857.9) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(28.16, 1.5, 816.20) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(20,1.5,816.20) for i = 1,150 do wait(1) if plr.PlayerGui.MainGui.CollectMoney.Money.Text == ('$3,000') then plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,895.9) plr.PlayerGui.MainGui.CollectMoney.Money.Text = ('3,00O') wait(60) end end else warn('The Bank is Closed!') end end");
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00006176 File Offset: 0x00004376
		private void flatButton184_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(2) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32, 5, 815) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32, 5, 815) wait(14) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(16, 5, 815) wait(30) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1.1110189, 17.9213142, 782.103455)");
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000618A File Offset: 0x0000438A
		private void flatButton186_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(2) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32, 5, 815) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32, 5, 815) wait(14) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(16, 5, 815) wait(48) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1.1110189, 17.9213142, 782.103455)");
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000619E File Offset: 0x0000439E
		private void flatButton191_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(184.722824, 18, 1357.91418) + Vector3.new(1,0,0) wait(1.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(141.722824, 18, 1353.91418) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(141.722824, 18, 1343) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(125.722824, 18, 1330) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(113.722824, 18, 1335) + Vector3.new(1,0,0)");
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000061B2 File Offset: 0x000043B2
		private void flatButton187_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(110.722824, 18, 1320) + Vector3.new(1,0,0) wait(0.15) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(120.722824, 18, 1317) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(137.722824, 18, 1317) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(135.5, 18, 1307) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(138.5, 18, 1324) + Vector3.new(1,0,0)");
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000061C6 File Offset: 0x000043C6
		private void flatButton190_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(129.5, 18, 1324) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(127, 18, 1311) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-174, 22, 1600) + Vector3.new(1,0,0) wait(1.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(244, 22, 1366) + Vector3.new(1,0,0)");
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000061DA File Offset: 0x000043DA
		private void flatButton189_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press F9 To See If Stores are open.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.api.SendLimitedLuaScript("function GetFrom(model) return game:GetService'Workspace'[tostring(model)]:GetChildren()[1].Extra:FindFirstChild'Sign'.Decal; end local bank = GetFrom'Banks' local jewelry = GetFrom'Jewelrys' bank.Changed:connect(function(prop) if prop == 'Transparency' then if bank.Transparency ~= 0 then print('Bank is open')end end end) jewelry.Changed:connect(function(prop)if prop == 'Transparency' then if jewelry.Transparency ~= 0 then print('Jewelry is open') end end end) print('Stores Ready To Rob: (If nothing shows, nothing is ready)') if GetFrom'Banks'.Transparency ~= 0 then print('Bank is open') end if GetFrom'Banks'.Transparency ~= 0 then print('Jewelry is open') end");
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00004C45 File Offset: 0x00002E45
		private void richTextBox39_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00006201 File Offset: 0x00004401
		private void flatButton193_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-89, 3, -452) end");
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00006215 File Offset: 0x00004415
		private void flatButton192_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-88, 3.5, -150) end");
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00006229 File Offset: 0x00004429
		private void flatButton101_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame =  CFrame.new(-89.05, 3.35, 144) end");
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000623D File Offset: 0x0000443D
		private void flatButton188_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(17.74, 3.35, 453.33) end");
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00006251 File Offset: 0x00004451
		private void flatButton115_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(18.19, 3.35, 144) end");
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006265 File Offset: 0x00004465
		private void flatButton42_Click_2(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-86.08, 3.35, 446.63) end");
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00006279 File Offset: 0x00004479
		private void flatButton199_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-14.55, 3.86, -558.21) end");
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000628D File Offset: 0x0000448D
		private void flatButton198_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-52.7326279, 3.45200205, -556.515015) end");
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000062A1 File Offset: 0x000044A1
		private void flatButton197_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(18.35, 3.35, 774.2) end");
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000062B5 File Offset: 0x000044B5
		private void flatButton196_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.63, 3.35, -434.96) end");
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000062C9 File Offset: 0x000044C9
		private void flatButton195_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(16.23, 3.35, -152.98) end");
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000062DD File Offset: 0x000044DD
		private void flatButton194_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-89.75, 3.35, 747.22) end");
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000062F1 File Offset: 0x000044F1
		private void flatButton204_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("Game.Workspace.LocalPlayer.Walkspeed = 100");
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00006305 File Offset: 0x00004505
		private void flatButton200_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("Game.Workspace.LocalPlayer.Walkspeed = 35");
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006319 File Offset: 0x00004519
		private void flatButton202_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("Game.Workspace.LocalPlayer.Gravity = 100");
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000632D File Offset: 0x0000452D
		private void flatButton201_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("Game.Workspace.LocalPlayer.Gravity = 35");
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatLabel4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000132 RID: 306
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool WaitNamedPipe(string string_1, int int_0);

		// Token: 0x06000133 RID: 307 RVA: 0x00006344 File Offset: 0x00004544
		private void timer3_Tick(object sender, EventArgs e)
		{
			bool flag = Form3.WaitNamedPipe(Path.GetFullPath(string.Format(this.PipeFormat, this.pipe)), 0);
			if (flag)
			{
				this.flatLabel4.Text = "Injected";
				this.flatLabel4.ForeColor = Color.Green;
			}
			else
			{
				this.flatLabel4.Text = "Not Injected";
				this.flatLabel4.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000134 RID: 308
		[DllImport("shlwapi.dll")]
		public static extern int ColorHLSToRGB(int H, int L, int S);

		// Token: 0x06000135 RID: 309 RVA: 0x000063BC File Offset: 0x000045BC
		private void timer4_Tick(object sender, EventArgs e)
		{
			this.loadtime++;
			bool flag = this.loadtime > 239;
			if (flag)
			{
				this.loadtime = 0;
			}
			this.formSkin1.FlatColor = ColorTranslator.FromWin32(Form3.ColorHLSToRGB(this.loadtime, 120, 240));
			this.panel2.BackColor = ColorTranslator.FromWin32(Form3.ColorHLSToRGB(this.loadtime, 60, 240));
			this.formSkin1.Refresh();
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006442 File Offset: 0x00004642
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.timer4.Enabled = this.checkBox1.Checked;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatLabel3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004C45 File Offset: 0x00002E45
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000645C File Offset: 0x0000465C
		private void flatButton42_Click_3(object sender, EventArgs e)
		{
			this.api.SendScript(this.richTextBox39.Text);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00006478 File Offset: 0x00004678
		private void flatButton101_Click_2(object sender, EventArgs e)
		{
			string text = this.scintilla1.Text;
			this.api.SendScript(text);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00004C45 File Offset: 0x00002E45
		private void scintilla1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000055B6 File Offset: 0x000037B6
		private void flatButton216_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1541.10388, 17.746624, 729) end");
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000064A0 File Offset: 0x000046A0
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox3.Checked;
			if (@checked)
			{
				base.TopMost = true;
			}
			else
			{
				bool flag = !this.checkBox3.Checked;
				if (flag)
				{
					base.TopMost = false;
				}
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000064E5 File Offset: 0x000046E5
		private void flatButton152_Click_1(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage6;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000064FA File Offset: 0x000046FA
		private void flatButton188_Click_1(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage4;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000650F File Offset: 0x0000470F
		private void flatButton115_Click_2(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage3;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006524 File Offset: 0x00004724
		private void flatButton229_Click(object sender, EventArgs e)
		{
			Languages languages = new Languages(this);
			languages.Show();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00006157 File Offset: 0x00004357
		private void flatButton218_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Note: You must have full duffel bag for this to work!");
			this.api.SendLimitedLuaScript("while true do wait(10) local plr = game:GetService('Players').LocalPlayer if game:GetService('Workspace').Banks:GetChildren()[1].Extra.Sign.Decal.Transparency ~= 0 then for i = 1,50 do wait(0.12) plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,835.9) end wait(2) plr.Character.HumanoidRootPart.CFrame = CFrame.new(51.3, 18.6, 857.9) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(28.16, 1.5, 816.20) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(20,1.5,816.20) for i = 1,150 do wait(1) if plr.PlayerGui.MainGui.CollectMoney.Money.Text == ('$3,000') then plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,895.9) plr.PlayerGui.MainGui.CollectMoney.Money.Text = ('3,00O') wait(60) end end else warn('The Bank is Closed!') end end");
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006540 File Offset: 0x00004740
		private void flatButton245_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage19;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006555 File Offset: 0x00004755
		private void flatButton214_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage7;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000656A File Offset: 0x0000476A
		private void flatButton156_Click_2(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage13;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000657F File Offset: 0x0000477F
		private void flatButton224_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage15;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00006594 File Offset: 0x00004794
		private void flatButton226_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage17;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000065A9 File Offset: 0x000047A9
		private void flatButton228_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage18;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000065BE File Offset: 0x000047BE
		private void flatButton247_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage14;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000065D3 File Offset: 0x000047D3
		private void flatButton246_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage12;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000065E8 File Offset: 0x000047E8
		private void flatButton230_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage9;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000065FD File Offset: 0x000047FD
		private void flatButton225_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage5;
		}

		// Token: 0x0600014D RID: 333
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600014E RID: 334
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600014F RID: 335 RVA: 0x00006614 File Offset: 0x00004814
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				Form3.ReleaseCapture();
				Form3.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000664E File Offset: 0x0000484E
		private void flatButton227_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage11;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000556F File Offset: 0x0000376F
		private void flatButton155_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("while true do for i, v in pairs(game.Teams.Police:GetPlayers()) do p = game:GetService('Players') e = Instance.new('BoxHandleAdornment') e.Color3 = Color3.new(0,0,1) e.Size = Vector3.new(2,1.6,1) e.ZIndex = 1 e.AlwaysOnTop = true e.Parent = game:GetService('Workspace') e.Adornee = v.Character.UpperTorso end wait(5) e:Destroy() end");
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000555B File Offset: 0x0000375B
		private void flatButton154_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("while true do for i,v in pairs(game.Teams.Criminal:GetPlayers()) do p=game:GetService('Players') e=Instance.new('BoxHandleAdornment') e.Color3=Color3.new(255,0,0) e.Size=Vector3.new(2,1.6,1) e.ZIndex=1 e.AlwaysOnTop=true e.Parent=game:GetService('Workspace') e.Adornee=v.Character.UpperTorso end wait(5) e:Destroy() end");
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00005583 File Offset: 0x00003783
		private void flatButton192_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("while true do for i,v in pairs(game.Teams.Prisoner:GetPlayers()) do p=game:GetService('Players') e=Instance.new('BoxHandleAdornment') e.Color3=Color3.new(255,77,0) e.Size=Vector3.new(2,1.6,1) e.ZIndex=1 e.AlwaysOnTop=true e.Parent=game:GetService('Workspace') e.Adornee=v.Character.UpperTorso end wait(5) e:Destroy() end");
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00005675 File Offset: 0x00003875
		private void flatButton153_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Parent = game.Lighting\r\n                                 game.Lighting.HumanoidRootPart.Parent = game:GetService('Players').LocalPlayer.Character");
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00005597 File Offset: 0x00003797
		private void flatButton193_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Press R to fly while in a car!");
			this.api.SendLimitedLuaScript("local plr = game:GetService'Players'.LocalPlayer\r\nlocal m = plr:GetMouse()\r\nm.KeyDown:connect(function(k)\r\nif k:byte() == 114 then\r\nplrh = game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid'\r\nplrh:ChangeState('Jumping')\r\nwait()\r\nplrh:ChangeState('Seated')\r\nend\r\nend)");
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000053F3 File Offset: 0x000035F3
		private void flatButton215_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-170, 18.6, 1057.1) end");
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000562E File Offset: 0x0000382E
		private void flatButton241_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1355.2417, 18, -1531.86047) end");
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00005606 File Offset: 0x00003806
		private void flatButton210_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-453.2, 13.6, 418.2) end");
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000054A7 File Offset: 0x000036A7
		private void flatButton206_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1453.4, 25.6, 201.4) end");
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000055F2 File Offset: 0x000037F2
		private void flatButton209_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1473.9, -0.30, -1877.6) end");
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00005493 File Offset: 0x00003693
		private void flatButton208_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(245.938766, 17.6064777, 1372.15076) end");
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000055B6 File Offset: 0x000037B6
		private void flatButton213_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1541.10388, 17.746624, 729) end");
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000569D File Offset: 0x0000389D
		private void flatButton212_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1957.1, 68.8, -604) end");
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000055DE File Offset: 0x000037DE
		private void flatButton207_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(578.7, 17.8, -460.1) end");
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005407 File Offset: 0x00003607
		private void flatButton205_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-97.5, 18.3, -1724) end");
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005689 File Offset: 0x00003889
		private void flatButton203_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-653.4, 20.4, -246.4) end");
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000541B File Offset: 0x0000361B
		private void flatButton204_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(761.3, 18.5, -1227.2) end");
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00004BCF File Offset: 0x00002DCF
		private void flatButton202_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(376.6, 18.3, -1686.9) end");
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000546B File Offset: 0x0000366B
		private void flatButton198_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1499.6, 50.2, 1803.1) end");
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000054E3 File Offset: 0x000036E3
		private void flatButton200_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1167.1, 18.7, -1374.5) end");
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000561A File Offset: 0x0000381A
		private void flatButton201_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(391.1, 43.1, -1722.9) end");
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000551F File Offset: 0x0000371F
		private void flatButton199_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1188.7, 18.4, -1536.1) end");
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000550B File Offset: 0x0000370B
		private void flatButton197_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(0.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1112.11475, 101.16069, 1290.57654) end");
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00004C45 File Offset: 0x00002E45
		private void flatButton67_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00004BCF File Offset: 0x00002DCF
		private void flatButton195_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(376.6, 18.3, -1686.9) end");
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000547F File Offset: 0x0000367F
		private void flatButton194_Click_1(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(598.6, 38.3, 1646.6) end");
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00005656 File Offset: 0x00003856
		private void flatButton231_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Note: You must have full duffle bag for this to work! We will improve it in the next update!");
			this.api.SendLimitedLuaScript("while true do wait(10) local plr = game:GetService('Players').LocalPlayer if game:GetService('Workspace').Banks:GetChildren()[1].Extra.Sign.Decal.Transparency ~= 0 then for i = 1,50 do wait(0.12) plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,835.9) end wait(2) plr.Character.HumanoidRootPart.CFrame = CFrame.new(51.3, 18.6, 857.9) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(28.16, 1.5, 816.20) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(20,1.5,816.20) for i = 1,150 do wait(1) if plr.PlayerGui.MainGui.CollectMoney.Money.Text == ('$3,000') then plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,895.9) plr.PlayerGui.MainGui.CollectMoney.Money.Text = ('3,00O') wait(60) end end else warn('The Bank is Closed!') end end");
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000059C2 File Offset: 0x00003BC2
		private void flatButton232_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Note: For Small duffle!!");
			this.api.SendLimitedLuaScript("while true do wait(10) local plr = game:GetService('Players').LocalPlayer if game:GetService('Workspace').Banks:GetChildren()[1].Extra.Sign.Decal.Transparency ~= 0 then for i = 1,50 do wait(0.12) plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,835.9) end wait(2) plr.Character.HumanoidRootPart.CFrame = CFrame.new(51.3, 18.6, 857.9) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(28.16, 1.5, 816.20) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(20,1.5,816.20) for i = 1,150 do wait(1) if plr.PlayerGui.MainGui.CollectMoney.Money.Text == ('$1,500') then plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,895.9) plr.PlayerGui.MainGui.CollectMoney.Money.Text = ('1,50O') wait(60) end end else warn('The Bank is Closed!') end end");
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00006664 File Offset: 0x00004864
		private void flatCheckBox11_CheckedChanged(object sender)
		{
			bool @checked = this.flatCheckBox11.Checked;
			if (@checked)
			{
				this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer:FindFirstChildOfClass'PlayerGui'.MainGui.Ammo.MagSize.RobloxLocked = true\nscript:Destroy()");
			}
			else
			{
				this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer:FindFirstChildOfClass'PlayerGui'.MainGui.Ammo.MagSize.RobloxLocked = false\nscript:Destroy()");
			}
			this.Refresh();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000066B0 File Offset: 0x000048B0
		private void flatCheckBox2_CheckedChanged_1(object sender)
		{
			bool @checked = this.flatCheckBox2.Checked;
			if (@checked)
			{
				this.api.SendLimitedLuaScript("_G.WS = 200;\r\n            local Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\r\n            Humanoid: GetPropertyChangedSignal('WalkSpeed'):Connect(function()\r\n             Humanoid.WalkSpeed = _G.WS;\r\n            end)\r\nHumanoid.WalkSpeed = _G.WS;");
			}
			else
			{
				bool flag = !this.flatCheckBox2.Checked;
				if (flag)
				{
					this.api.SendLimitedLuaScript("_G.WS = 20;\r\n            local Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\r\n            Humanoid: GetPropertyChangedSignal('WalkSpeed'):Connect(function()\r\n             Humanoid.WalkSpeed = _G.WS;\r\n            end)\r\nHumanoid.WalkSpeed = _G.WS;");
				}
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00006708 File Offset: 0x00004908
		private void flatCheckBox1_CheckedChanged(object sender)
		{
			bool @checked = this.flatCheckBox1.Checked;
			if (@checked)
			{
				this.api.SendLimitedLuaScript("plr = game:GetService('Players').LocalPlayer.PlayerGui plr.MainGui.Nitro.Name = 'Nitr' plr.ProductGui.Nitro.Parent = game.Lighting b = Instance.new('Model', plr.ProductGui) b.Name = 'Nitro'");
			}
			else
			{
				bool flag = !this.flatCheckBox1.Checked;
				if (flag)
				{
					this.api.SendLimitedLuaScript("plr = game:GetService('Players')  plr.LocalPlayer.PlayerGui.ProductGui.Nitro:Destroy() game.Lighting.Nitro.Parent = plr.LocalPlayer.PlayerGui.ProductGui plr.LocalPlayer.PlayerGui.MainGui.Nitro.Name = 'Nitro'");
				}
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00006760 File Offset: 0x00004960
		private void flatCheckBox3_CheckedChanged_1(object sender)
		{
			bool @checked = this.flatCheckBox4.Checked;
			if (@checked)
			{
				bool flag = !this.flatCheckBox3.Checked;
				if (flag)
				{
					this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 50\nscript:Destroy()");
				}
				else
				{
					this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 0\nscript:Destroy()");
				}
			}
			else
			{
				bool flag2 = !this.flatCheckBox3.Checked;
				if (flag2)
				{
					this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 196.2\nscript:Destroy()");
				}
				else
				{
					this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 0\nscript:Destroy()");
				}
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000067F8 File Offset: 0x000049F8
		private void flatCheckBox4_CheckedChanged_1(object sender)
		{
			bool @checked = this.flatCheckBox4.Checked;
			if (@checked)
			{
				this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 50\nscript:Destroy()");
				this.flatCheckBox3.Checked = false;
				base.Hide();
				base.Show();
			}
			else
			{
				this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 196.2\nscript:Destroy()");
				this.flatCheckBox3.Checked = false;
				base.Hide();
				base.Show();
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00006176 File Offset: 0x00004376
		private void flatButton217_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(2) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32, 5, 815) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32, 5, 815) wait(14) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(16, 5, 815) wait(30) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1.1110189, 17.9213142, 782.103455)");
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000618A File Offset: 0x0000438A
		private void flatButton219_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(19.7360458, 18.1664009, 840.456848) wait(2) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32, 5, 815) wait(0.1) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32, 5, 815) wait(14) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(16, 5, 815) wait(48) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1.1110189, 17.9213142, 782.103455)");
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000619E File Offset: 0x0000439E
		private void flatButton223_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(184.722824, 18, 1357.91418) + Vector3.new(1,0,0) wait(1.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(141.722824, 18, 1353.91418) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(141.722824, 18, 1343) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(125.722824, 18, 1330) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(113.722824, 18, 1335) + Vector3.new(1,0,0)");
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000061B2 File Offset: 0x000043B2
		private void flatButton220_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(110.722824, 18, 1320) + Vector3.new(1,0,0) wait(0.15) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(120.722824, 18, 1317) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(137.722824, 18, 1317) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(135.5, 18, 1307) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(138.5, 18, 1324) + Vector3.new(1,0,0)");
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000061C6 File Offset: 0x000043C6
		private void flatButton222_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(129.5, 18, 1324) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(127, 18, 1311) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-174, 22, 1600) + Vector3.new(1,0,0) wait(1.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(244, 22, 1366) + Vector3.new(1,0,0)");
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000061DA File Offset: 0x000043DA
		private void flatButton221_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Press F9 To See If Stores are open.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.api.SendLimitedLuaScript("function GetFrom(model) return game:GetService'Workspace'[tostring(model)]:GetChildren()[1].Extra:FindFirstChild'Sign'.Decal; end local bank = GetFrom'Banks' local jewelry = GetFrom'Jewelrys' bank.Changed:connect(function(prop) if prop == 'Transparency' then if bank.Transparency ~= 0 then print('Bank is open')end end end) jewelry.Changed:connect(function(prop)if prop == 'Transparency' then if jewelry.Transparency ~= 0 then print('Jewelry is open') end end end) print('Stores Ready To Rob: (If nothing shows, nothing is ready)') if GetFrom'Banks'.Transparency ~= 0 then print('Bank is open') end if GetFrom'Banks'.Transparency ~= 0 then print('Jewelry is open') end");
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000570C File Offset: 0x0000390C
		private void flatButton236_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1078.45, 153.904, 1176.52) + Vector3.new(1,0,0)");
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00005720 File Offset: 0x00003920
		private void flatButton233_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1132.674, 100.412, 1230.48) + Vector3.new(1,0,0)");
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00005734 File Offset: 0x00003934
		private void flatButton234_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1063.02, 117.562, 1218.757) + Vector3.new(1,0,0)");
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000576D File Offset: 0x0000396D
		private void flatButton242_Click(object sender, EventArgs e)
		{
			this.api.SendScript("getglobal game\ngetfield -1 GetService\npushvalue -2\npushstring Lighting\npcall 2 1 0\npushnumber 100\nsetfield -2 FogEnd\nemptystack");
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00005781 File Offset: 0x00003981
		private void flatButton244_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game.Workspace.Buildings:Destroy()");
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00005748 File Offset: 0x00003948
		private void flatButton249_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("boy = game:GetService('Workspace') nah = boy:FindFirstChild('Museum') nah.CaseLasers:Destroy()");
			this.api.SendLimitedLuaScript("boy = game:GetService('Workspace') nah = boy:FindFirstChild('Museum') nah.Doors:Destroy()");
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00005795 File Offset: 0x00003995
		private void flatButton248_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("for i,v in pairs(game:GetService('Workspace').Buildings:GetChildren()) do v.CanCollide = false end");
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000059E1 File Offset: 0x00003BE1
		private void flatButton238_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Binoculars' then v.CFrame = CFrame.new(hit) end end end end end");
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00006873 File Offset: 0x00004A73
		private void flatButton240_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox48.Text);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000056D9 File Offset: 0x000038D9
		private void flatButton243_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(" local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftControl) then return end if not Mouse.Target then return end Mouse.Target:Destroy() end)");
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000059AE File Offset: 0x00003BAE
		private void flatButton237_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("vlocal hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Flashlight' then v.CFrame = CFrame.new(hit) end end end end end");
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000059F5 File Offset: 0x00003BF5
		private void flatButton239_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("while wait(2) do game:GetService('Workspace').TouchTrigger.Donut.Position = game:GetService('Players').LocalPlayer.Character.Head.Position end");
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000688D File Offset: 0x00004A8D
		private void flatButton250_Click(object sender, EventArgs e)
		{
			Process.Start("https://cdn.discordapp.com/attachments/495811548392980480/500739731697696768/Nonsense_Diamond_Exploit_Help.txt");
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000689B File Offset: 0x00004A9B
		private void flatButton251_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox41.Text);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000068B5 File Offset: 0x00004AB5
		private void flatButton256_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox42.Text);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000068CF File Offset: 0x00004ACF
		private void flatButton253_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox43.Text);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000068E9 File Offset: 0x00004AE9
		private void flatButton255_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox44.Text);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00006903 File Offset: 0x00004B03
		private void flatButton254_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox45.Text);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000691D File Offset: 0x00004B1D
		private void flatButton257_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox46.Text);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00006937 File Offset: 0x00004B37
		private void flatButton252_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage22;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000694C File Offset: 0x00004B4C
		private void flatButton259_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox47.Text);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00004C45 File Offset: 0x00002E45
		private void tabPage24_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00006966 File Offset: 0x00004B66
		private void flatButton258_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage24;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000697B File Offset: 0x00004B7B
		private void flatButton260_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox49.Text);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00004C45 File Offset: 0x00002E45
		private void pictureBox16_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00006995 File Offset: 0x00004B95
		private void flatButton263_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox50.Text);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000069AF File Offset: 0x00004BAF
		private void flatButton262_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox51.Text);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000069C9 File Offset: 0x00004BC9
		private void flatButton264_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox52.Text);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000069E3 File Offset: 0x00004BE3
		private void flatButton261_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage25;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000056D9 File Offset: 0x000038D9
		private void flatButton273_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(" local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftControl) then return end if not Mouse.Target then return end Mouse.Target:Destroy() end)");
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000058F7 File Offset: 0x00003AF7
		private void flatButton272_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("_G.WS = 200;\r\n            local Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\r\n            Humanoid: GetPropertyChangedSignal('WalkSpeed'):Connect(function()\r\n             Humanoid.WalkSpeed = _G.WS;\r\n            end)\r\nHumanoid.WalkSpeed = _G.WS;");
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00004C67 File Offset: 0x00002E67
		private void flatButton277_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 50\nscript:Destroy()");
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00004C67 File Offset: 0x00002E67
		private void flatButton276_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("game:GetService('Workspace').Gravity = 50\nscript:Destroy()");
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000058F7 File Offset: 0x00003AF7
		private void flatButton275_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript("_G.WS = 200;\r\n            local Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\r\n            Humanoid: GetPropertyChangedSignal('WalkSpeed'):Connect(function()\r\n             Humanoid.WalkSpeed = _G.WS;\r\n            end)\r\nHumanoid.WalkSpeed = _G.WS;");
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000069F8 File Offset: 0x00004BF8
		private void flatButton274_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox53.Text);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00006A12 File Offset: 0x00004C12
		private void flatButton268_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage26;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00006A27 File Offset: 0x00004C27
		private void flatButton265_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox54.Text);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00006A41 File Offset: 0x00004C41
		private void flatButton266_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox55.Text);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00006A5B File Offset: 0x00004C5B
		private void flatButton271_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox56.Text);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00006A75 File Offset: 0x00004C75
		private void flatButton270_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox57.Text);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00006A8F File Offset: 0x00004C8F
		private void flatButton269_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox58.Text);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00006AA9 File Offset: 0x00004CA9
		private void flatButton267_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox59.Text);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00006AC3 File Offset: 0x00004CC3
		private void flatButton278_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox60.Text);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00006ADD File Offset: 0x00004CDD
		private void flatButton280_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox61.Text);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00006AF7 File Offset: 0x00004CF7
		private void flatButton281_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox62.Text);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00006B11 File Offset: 0x00004D11
		private void flatButton285_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox64.Text);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00006B2B File Offset: 0x00004D2B
		private void flatButton284_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox63.Text);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006B45 File Offset: 0x00004D45
		private void flatButton286_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox65.Text);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00006B5F File Offset: 0x00004D5F
		private void flatButton288_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox66.Text);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00006B79 File Offset: 0x00004D79
		private void flatButton287_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage30;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00006B8E File Offset: 0x00004D8E
		private void flatButton283_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage29;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00006BA3 File Offset: 0x00004DA3
		private void flatButton282_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage27;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00006BB8 File Offset: 0x00004DB8
		private void flatButton279_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage28;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00006BCD File Offset: 0x00004DCD
		private void flatButton294_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox69.Text);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00006BE7 File Offset: 0x00004DE7
		private void flatButton293_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox68.Text);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00006C01 File Offset: 0x00004E01
		private void flatButton292_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox67.Text);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00006C1B File Offset: 0x00004E1B
		private void flatButton289_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage32;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00006C30 File Offset: 0x00004E30
		private void flatButton290_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage31;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00006C45 File Offset: 0x00004E45
		private void flatButton291_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage33;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00006C5A File Offset: 0x00004E5A
		private void flatButton295_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Will be implemented next update, Merry christmas!!. \r\n You can go to the site to download the WRD version for now.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00006C70 File Offset: 0x00004E70
		private void flatButton302_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox70.Text);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00006C8A File Offset: 0x00004E8A
		private void flatButton305_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox71.Text);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00006CA4 File Offset: 0x00004EA4
		private void flatButton304_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox72.Text);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00006CBE File Offset: 0x00004EBE
		private void flatButton303_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox73.Text);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00006CD8 File Offset: 0x00004ED8
		private void flatButton306_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox74.Text);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00006CF2 File Offset: 0x00004EF2
		private void flatButton307_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox75.Text);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00006D0C File Offset: 0x00004F0C
		private void flatButton308_Click(object sender, EventArgs e)
		{
			this.api.SendLimitedLuaScript(this.richTextBox76.Text);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00006D26 File Offset: 0x00004F26
		private void flatButton297_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage34;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00006D3B File Offset: 0x00004F3B
		private void flatButton298_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage35;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00006D50 File Offset: 0x00004F50
		private void flatButton299_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage36;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00006D65 File Offset: 0x00004F65
		private void flatButton300_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage37;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00006D7A File Offset: 0x00004F7A
		private void flatButton296_Click(object sender, EventArgs e)
		{
			this.flatTabControl2.SelectedTab = this.tabPage38;
		}

		// Token: 0x04000024 RID: 36
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x04000025 RID: 37
		internal string pipe = "RoSploit";

		// Token: 0x04000026 RID: 38
		internal string PipeFormat = "\\\\.\\pipe\\{0}";

		// Token: 0x04000027 RID: 39
		private bool loaded = false;

		// Token: 0x04000028 RID: 40
		private int loadtime = 0;

		// Token: 0x04000029 RID: 41
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400002A RID: 42
		public const int HT_CAPTION = 2;
	}
}
