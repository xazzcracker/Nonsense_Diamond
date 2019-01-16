using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace JailbreakDestroyer
{
	// Token: 0x02000004 RID: 4
	internal class Injector
	{
		// Token: 0x02000011 RID: 17
		public enum DllInjectionResult
		{
			// Token: 0x04000295 RID: 661
			DllNotFound,
			// Token: 0x04000296 RID: 662
			GameProcessNotFound,
			// Token: 0x04000297 RID: 663
			InjectionFailed,
			// Token: 0x04000298 RID: 664
			Success
		}

		// Token: 0x02000012 RID: 18
		public sealed class DllInjector
		{
			// Token: 0x0600021D RID: 541
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

			// Token: 0x0600021E RID: 542
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern int CloseHandle(IntPtr hObject);

			// Token: 0x0600021F RID: 543
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

			// Token: 0x06000220 RID: 544
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr GetModuleHandle(string lpModuleName);

			// Token: 0x06000221 RID: 545
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

			// Token: 0x06000222 RID: 546
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

			// Token: 0x06000223 RID: 547
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000224 RID: 548 RVA: 0x0002AFE4 File Offset: 0x000291E4
			public static Injector.DllInjector GetInstance
			{
				get
				{
					bool flag = Injector.DllInjector._instance == null;
					if (flag)
					{
						Injector.DllInjector._instance = new Injector.DllInjector();
					}
					return Injector.DllInjector._instance;
				}
			}

			// Token: 0x06000225 RID: 549 RVA: 0x0002A6F1 File Offset: 0x000288F1
			private DllInjector()
			{
			}

			// Token: 0x06000226 RID: 550 RVA: 0x0002B014 File Offset: 0x00029214
			public Injector.DllInjectionResult Inject(string sProcName, string sDllPath)
			{
				bool flag = !File.Exists(sDllPath);
				Injector.DllInjectionResult result;
				if (flag)
				{
					result = Injector.DllInjectionResult.DllNotFound;
				}
				else
				{
					uint num = 0u;
					Process[] processes = Process.GetProcesses();
					for (int i = 0; i < processes.Length; i++)
					{
						bool flag2 = processes[i].ProcessName == sProcName;
						if (flag2)
						{
							num = (uint)processes[i].Id;
							break;
						}
					}
					bool flag3 = num == 0u;
					if (flag3)
					{
						result = Injector.DllInjectionResult.GameProcessNotFound;
					}
					else
					{
						bool flag4 = !this.bInject(num, sDllPath);
						if (flag4)
						{
							result = Injector.DllInjectionResult.InjectionFailed;
						}
						else
						{
							result = Injector.DllInjectionResult.Success;
						}
					}
				}
				return result;
			}

			// Token: 0x06000227 RID: 551 RVA: 0x0002B0A4 File Offset: 0x000292A4
			private bool bInject(uint pToBeInjected, string sDllPath)
			{
				IntPtr intPtr = Injector.DllInjector.OpenProcess(1082u, 1, pToBeInjected);
				bool flag = intPtr == Injector.DllInjector.INTPTR_ZERO;
				bool result;
				if (flag)
				{
					result = false;
				}
				else
				{
					IntPtr procAddress = Injector.DllInjector.GetProcAddress(Injector.DllInjector.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
					bool flag2 = procAddress == Injector.DllInjector.INTPTR_ZERO;
					if (flag2)
					{
						result = false;
					}
					else
					{
						IntPtr intPtr2 = Injector.DllInjector.VirtualAllocEx(intPtr, (IntPtr)null, (IntPtr)sDllPath.Length, 12288u, 64u);
						bool flag3 = intPtr2 == Injector.DllInjector.INTPTR_ZERO;
						if (flag3)
						{
							result = false;
						}
						else
						{
							byte[] bytes = Encoding.ASCII.GetBytes(sDllPath);
							bool flag4 = Injector.DllInjector.WriteProcessMemory(intPtr, intPtr2, bytes, (uint)bytes.Length, 0) == 0;
							if (flag4)
							{
								result = false;
							}
							else
							{
								bool flag5 = Injector.DllInjector.CreateRemoteThread(intPtr, (IntPtr)null, Injector.DllInjector.INTPTR_ZERO, procAddress, intPtr2, 0u, (IntPtr)null) == Injector.DllInjector.INTPTR_ZERO;
								if (flag5)
								{
									result = false;
								}
								else
								{
									Injector.DllInjector.CloseHandle(intPtr);
									result = true;
								}
							}
						}
					}
				}
				return result;
			}

			// Token: 0x04000299 RID: 665
			private static readonly IntPtr INTPTR_ZERO = (IntPtr)0;

			// Token: 0x0400029A RID: 666
			private static Injector.DllInjector _instance;
		}
	}
}
