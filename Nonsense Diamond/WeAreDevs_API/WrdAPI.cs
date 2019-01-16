using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WeAreDevs_API
{
	// Token: 0x0200000E RID: 14
	internal class WrdAPI
	{
		// Token: 0x060001E8 RID: 488
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		// Token: 0x060001E9 RID: 489 RVA: 0x0002A874 File Offset: 0x00028A74
		private static bool NamedPipeExist(string pipeName)
		{
			bool result;
			try
			{
				int timeout = 0;
				bool flag = !WrdAPI.WaitNamedPipe(Path.GetFullPath(string.Format("\\\\\\\\.\\\\pipe\\\\{0}", pipeName)), timeout);
				if (flag)
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					if (lastWin32Error == 0)
					{
						return false;
					}
					if (lastWin32Error == 2)
					{
						return false;
					}
				}
				result = true;
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0002A8DC File Offset: 0x00028ADC
		public void SMTP(string pipe, string input)
		{
			bool flag = WrdAPI.NamedPipeExist(pipe);
			if (flag)
			{
				try
				{
					using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", pipe, PipeDirection.Out))
					{
						namedPipeClientStream.Connect();
						using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream))
						{
							streamWriter.Write(input);
							streamWriter.Dispose();
						}
						namedPipeClientStream.Dispose();
					}
				}
				catch (IOException ex)
				{
					int num = (int)MessageBox.Show("Error occured sending message to the game!", "Connection Failed!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				catch (Exception ex2)
				{
					int num2 = (int)MessageBox.Show(ex2.Message.ToString());
				}
			}
			else
			{
				int num3 = (int)MessageBox.Show("Error occured. Did the dll properly inject?", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0002A9CC File Offset: 0x00028BCC
		private string ReadURL(string url)
		{
			return this.client.DownloadString(url);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0002A9EC File Offset: 0x00028BEC
		public bool IsUpdated()
		{
			bool result = false;
			string text = this.ReadURL("https://pastebin.com/raw/Ly9mJwH7");
			bool flag = text.Length > 0;
			if (flag)
			{
				result = Convert.ToBoolean(text.Split(new char[]
				{
					' '
				})[0]);
			}
			else
			{
				int num = (int)MessageBox.Show("Could not check for the latest version. Did your fireall block us?", "Error");
			}
			return result;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0002AA4C File Offset: 0x00028C4C
		private bool DownloadLatestVersion()
		{
			bool flag = File.Exists("exploit-main.dll");
			if (flag)
			{
				File.Delete("exploit-main.dll");
			}
			string text = this.ReadURL("https://pastebin.com/raw/Ly9mJwH7");
			bool flag2 = text.Length > 0;
			if (flag2)
			{
				this.client.DownloadFile(text.Split(new char[]
				{
					' '
				})[1], "exploit-main.dll");
			}
			return File.Exists("exploit-main.dll");
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0002AAC0 File Offset: 0x00028CC0
		public bool LaunchExploit()
		{
			bool flag = WrdAPI.NamedPipeExist(this.cmdpipe);
			if (flag)
			{
				int num = (int)MessageBox.Show("Dll already injected", "No problems");
			}
			else
			{
				bool flag2 = this.IsUpdated();
				if (flag2)
				{
					bool flag3 = this.DownloadLatestVersion();
					if (flag3)
					{
						bool flag4 = this.injector.InjectDLL();
						if (flag4)
						{
							return true;
						}
						int num2 = (int)MessageBox.Show("DLL failed to inject", "Error");
					}
					else
					{
						int num3 = (int)MessageBox.Show("Could not download the latest version! Did your firewall block us?", "Error");
					}
				}
				else
				{
					int num4 = (int)MessageBox.Show("Exploit currently patched. Try again tomorrow!", "Error");
				}
			}
			return false;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0002AB61 File Offset: 0x00028D61
		internal void SendCommand(string Command)
		{
			this.SMTP(this.cmdpipe, Command);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0002AB74 File Offset: 0x00028D74
		public void SendScript(string Script)
		{
			foreach (string input in Script.Split("\r\n".ToCharArray()))
			{
				try
				{
					this.SMTP(this.luacpipe, input);
				}
				catch (Exception ex)
				{
					int num = (int)MessageBox.Show(ex.Message.ToString());
				}
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0002ABE4 File Offset: 0x00028DE4
		public void SendLimitedLuaScript(string Script)
		{
			this.SMTP(this.luapipe, Script);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0002ABF5 File Offset: 0x00028DF5
		public void LuaC_getglobal(string service)
		{
			this.SendScript("getglobal " + service);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0002AC0A File Offset: 0x00028E0A
		public void LuaC_getfield(int index, string instance)
		{
			this.SendScript(string.Concat(new object[]
			{
				"getglobal ",
				index,
				" ",
				instance
			}));
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0002AC3C File Offset: 0x00028E3C
		public void LuaC_setfield(int index, string property)
		{
			this.SendScript(string.Concat(new object[]
			{
				"setfield ",
				index,
				" ",
				property
			}));
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0002AC6E File Offset: 0x00028E6E
		public void LuaC_pushvalue(int index)
		{
			this.SendScript("pushvalue " + index);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0002AC88 File Offset: 0x00028E88
		public void LuaC_pushstring(string text)
		{
			this.SendScript("pushstring " + text);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public void LuaC_pushnumber(int number)
		{
			this.SendScript("pushnumber " + number);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0002ACB8 File Offset: 0x00028EB8
		public void LuaC_pcall(int numberOfArguments, int numberOfResults, int ErrorFunction)
		{
			this.SendScript(string.Concat(new object[]
			{
				"pushnumber ",
				numberOfArguments,
				" ",
				numberOfResults,
				" ",
				ErrorFunction
			}));
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0002AD0B File Offset: 0x00028F0B
		public void LuaC_settop(int index)
		{
			this.SendScript("settop " + index);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0002AD25 File Offset: 0x00028F25
		public void LuaC_pushboolean(string value = "false")
		{
			this.SendScript("pushboolean " + value);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0002AD3A File Offset: 0x00028F3A
		public void LuaC_gettop()
		{
			this.SendScript("gettop");
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0002AD49 File Offset: 0x00028F49
		public void LuaC_pushnil()
		{
			this.SendScript("pushnil");
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0002AD58 File Offset: 0x00028F58
		public void LuaC_next(int index)
		{
			this.SendScript("next");
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0002AD67 File Offset: 0x00028F67
		public void LuaC_pop(int quantity)
		{
			this.SendScript("pop " + quantity);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0002AD81 File Offset: 0x00028F81
		public void DoBTools(string username = "me")
		{
			this.SendCommand("btools " + username);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0002AD96 File Offset: 0x00028F96
		public void DoKill(string username = "me")
		{
			this.SendCommand("kill " + username);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0002ADAB File Offset: 0x00028FAB
		public void CreateForceField(string username = "me")
		{
			this.SendCommand("ff " + username);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0002ADC0 File Offset: 0x00028FC0
		public void RemoveForceField(string username = "me")
		{
			this.SendCommand("noff " + username);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0002ADD5 File Offset: 0x00028FD5
		public void DoFloat(string username = "me")
		{
			this.SendCommand("float " + username);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0002ADEA File Offset: 0x00028FEA
		public void DoNoFloat(string username = "me")
		{
			this.SendCommand("nofloat " + username);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0002ADFF File Offset: 0x00028FFF
		public void RemoveLimbs(string username = "me")
		{
			this.SendCommand("nolimbs " + username);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0002AE14 File Offset: 0x00029014
		public void RemoveArms(string username = "me")
		{
			this.SendCommand("noarms " + username);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0002AE29 File Offset: 0x00029029
		public void RemoveLegs(string username = "me")
		{
			this.SendCommand("nolegs " + username);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0002AE3E File Offset: 0x0002903E
		public void AddFire(string username = "me")
		{
			this.SendCommand("fire " + username);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0002AE53 File Offset: 0x00029053
		public void RemoveFire(string username = "me")
		{
			this.SendCommand("nofire " + username);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0002AE68 File Offset: 0x00029068
		public void AddSparkles(string username = "me")
		{
			this.SendCommand("sparkles " + username);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0002AE7D File Offset: 0x0002907D
		public void RemoveSparkles(string username = "me")
		{
			this.SendCommand("nosparkles " + username);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0002AE92 File Offset: 0x00029092
		public void AddSmoke(string username = "me")
		{
			this.SendCommand("smoke " + username);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0002AEA7 File Offset: 0x000290A7
		public void DoBlockHead(string username = "me")
		{
			this.SendCommand("blockhead " + username);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0002AEBC File Offset: 0x000290BC
		public void ForceBubbleChat(string username = "me", string text = "WeAreDevs Website")
		{
			this.SendCommand("chat " + username + " " + text);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0002AED7 File Offset: 0x000290D7
		public void ConsolePrint(string text = "WeAreDevs Website")
		{
			this.SendCommand("print " + text);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0002AEEC File Offset: 0x000290EC
		public void ConsoleWarn(string text = "meWeAreDevs Website")
		{
			this.SendCommand("warn " + text);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0002AF01 File Offset: 0x00029101
		public void SetWalkSpeed(string username = "me", int value = 100)
		{
			this.SendCommand("speed " + username + " " + value.ToString());
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0002AF22 File Offset: 0x00029122
		public void ToggleClickTeleport()
		{
			this.SendCommand("toggleclickteleport");
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0002AF31 File Offset: 0x00029131
		public void SetFogEnd(int value = 0)
		{
			this.SendCommand("fogend " + value);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0002AF4B File Offset: 0x0002914B
		public void SetJumpPower(int value = 100)
		{
			this.SendCommand("jumppower " + value);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0002AF65 File Offset: 0x00029165
		public void TeleportMyCharacterTo(string target_username = "me")
		{
			this.SendCommand("teleport " + target_username);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0002AF7A File Offset: 0x0002917A
		public void PlaySoundInGame(string assetid = "1071384374")
		{
			this.SendCommand("music " + assetid);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0002AF8F File Offset: 0x0002918F
		public void SetSkyboxImage(string assetid = "2143522")
		{
			this.SendCommand("skybox " + assetid);
		}

		// Token: 0x0400028A RID: 650
		private WebClient client = new WebClient();

		// Token: 0x0400028B RID: 651
		private WrdAPI.BasicInject injector = new WrdAPI.BasicInject();

		// Token: 0x0400028C RID: 652
		private string cmdpipe = "WeAreDevsPublicAPI_CMD";

		// Token: 0x0400028D RID: 653
		private string luacpipe = "WeAreDevsPublicAPI_LuaC";

		// Token: 0x0400028E RID: 654
		public string luapipe = "WeAreDevsPublicAPI_Lua";

		// Token: 0x02000014 RID: 20
		private class BasicInject
		{
			// Token: 0x0600022B RID: 555
			[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
			internal static extern IntPtr LoadLibraryA(string lpFileName);

			// Token: 0x0600022C RID: 556
			[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
			internal static extern UIntPtr GetProcAddress(IntPtr hModule, string procName);

			// Token: 0x0600022D RID: 557
			[DllImport("kernel32.dll", SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal static extern bool FreeLibrary(IntPtr hModule);

			// Token: 0x0600022E RID: 558
			[DllImport("kernel32.dll")]
			internal static extern IntPtr OpenProcess(WrdAPI.BasicInject.ProcessAccess dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

			// Token: 0x0600022F RID: 559
			[DllImport("kernel32.dll", SetLastError = true)]
			internal static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

			// Token: 0x06000230 RID: 560
			[DllImport("kernel32.dll", SetLastError = true)]
			internal static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

			// Token: 0x06000231 RID: 561
			[DllImport("kernel32.dll")]
			internal static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, UIntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId);

			// Token: 0x06000232 RID: 562
			[DllImport("kernel32.dll", SetLastError = true)]
			internal static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

			// Token: 0x06000233 RID: 563 RVA: 0x0002B28C File Offset: 0x0002948C
			public bool InjectDLL()
			{
				bool flag = Process.GetProcessesByName("RobloxPlayerBeta").Length == 0;
				bool result;
				if (flag)
				{
					result = false;
				}
				else
				{
					Process process = Process.GetProcessesByName("RobloxPlayerBeta")[0];
					byte[] bytes = new ASCIIEncoding().GetBytes(AppDomain.CurrentDomain.BaseDirectory + "exploit-main.dll");
					IntPtr hModule = WrdAPI.BasicInject.LoadLibraryA("kernel32.dll");
					UIntPtr procAddress = WrdAPI.BasicInject.GetProcAddress(hModule, "LoadLibraryA");
					WrdAPI.BasicInject.FreeLibrary(hModule);
					bool flag2 = procAddress == UIntPtr.Zero;
					if (flag2)
					{
						result = false;
					}
					else
					{
						IntPtr intPtr = WrdAPI.BasicInject.OpenProcess(WrdAPI.BasicInject.ProcessAccess.AllAccess, false, process.Id);
						bool flag3 = intPtr == IntPtr.Zero;
						if (flag3)
						{
							result = false;
						}
						else
						{
							IntPtr intPtr2 = WrdAPI.BasicInject.VirtualAllocEx(intPtr, (IntPtr)0, (uint)bytes.Length, 12288u, 4u);
							UIntPtr uintPtr;
							IntPtr intPtr3;
							result = (!(intPtr2 == IntPtr.Zero) && WrdAPI.BasicInject.WriteProcessMemory(intPtr, intPtr2, bytes, (uint)bytes.Length, out uintPtr) && !(WrdAPI.BasicInject.CreateRemoteThread(intPtr, (IntPtr)0, 0u, procAddress, intPtr2, 0u, out intPtr3) == IntPtr.Zero));
						}
					}
				}
				return result;
			}

			// Token: 0x02000015 RID: 21
			[Flags]
			public enum ProcessAccess
			{
				// Token: 0x0400029D RID: 669
				AllAccess = 1050235,
				// Token: 0x0400029E RID: 670
				CreateThread = 2,
				// Token: 0x0400029F RID: 671
				DuplicateHandle = 64,
				// Token: 0x040002A0 RID: 672
				QueryInformation = 1024,
				// Token: 0x040002A1 RID: 673
				SetInformation = 512,
				// Token: 0x040002A2 RID: 674
				Terminate = 1,
				// Token: 0x040002A3 RID: 675
				VMOperation = 8,
				// Token: 0x040002A4 RID: 676
				VMRead = 16,
				// Token: 0x040002A5 RID: 677
				VMWrite = 32,
				// Token: 0x040002A6 RID: 678
				Synchronize = 1048576
			}
		}
	}
}
