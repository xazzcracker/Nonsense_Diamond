using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x02000002 RID: 2
public class GlobalKeyboardHook
{
	// Token: 0x06000001 RID: 1
	[DllImport("user32.dll")]
	private static extern int CallNextHookEx(IntPtr hhk, int code, int wParam, ref GlobalKeyboardHook.keyBoardHookStruct lParam);

	// Token: 0x06000002 RID: 2
	[DllImport("user32.dll")]
	private static extern IntPtr SetWindowsHookEx(int idHook, GlobalKeyboardHook.LLKeyboardHook callback, IntPtr hInstance, uint theardID);

	// Token: 0x06000003 RID: 3
	[DllImport("user32.dll")]
	private static extern bool UnhookWindowsHookEx(IntPtr hInstance);

	// Token: 0x06000004 RID: 4
	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string lpFileName);

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000006 RID: 6 RVA: 0x00002088 File Offset: 0x00000288
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event KeyEventHandler KeyDown;

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000007 RID: 7 RVA: 0x000020C0 File Offset: 0x000002C0
	// (remove) Token: 0x06000008 RID: 8 RVA: 0x000020F8 File Offset: 0x000002F8
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event KeyEventHandler KeyUp;

	// Token: 0x06000009 RID: 9 RVA: 0x0000212D File Offset: 0x0000032D
	public GlobalKeyboardHook()
	{
		this.llkh = new GlobalKeyboardHook.LLKeyboardHook(this.HookProc);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002160 File Offset: 0x00000360
	~GlobalKeyboardHook()
	{
		this.unhook();
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002190 File Offset: 0x00000390
	public void hook()
	{
		IntPtr hInstance = GlobalKeyboardHook.LoadLibrary("User32");
		this.Hook = GlobalKeyboardHook.SetWindowsHookEx(13, this.llkh, hInstance, 0u);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000021BE File Offset: 0x000003BE
	public void unhook()
	{
		GlobalKeyboardHook.UnhookWindowsHookEx(this.Hook);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000021D0 File Offset: 0x000003D0
	public int HookProc(int Code, int wParam, ref GlobalKeyboardHook.keyBoardHookStruct lParam)
	{
		bool flag = Code >= 0;
		if (flag)
		{
			Keys vkCode = (Keys)lParam.vkCode;
			bool flag2 = this.HookedKeys.Contains(vkCode);
			if (flag2)
			{
				KeyEventArgs keyEventArgs = new KeyEventArgs(vkCode);
				bool flag3 = (wParam == 256 || wParam == 260) && this.KeyDown != null;
				if (flag3)
				{
					this.KeyDown(this, keyEventArgs);
				}
				else
				{
					bool flag4 = (wParam == 257 || wParam == 261) && this.KeyUp != null;
					if (flag4)
					{
						this.KeyUp(this, keyEventArgs);
					}
				}
				bool handled = keyEventArgs.Handled;
				if (handled)
				{
					return 1;
				}
			}
		}
		return GlobalKeyboardHook.CallNextHookEx(this.Hook, Code, wParam, ref lParam);
	}

	// Token: 0x04000001 RID: 1
	private const int WH_KEYBOARD_LL = 13;

	// Token: 0x04000002 RID: 2
	private const int WM_KEYDOWN = 256;

	// Token: 0x04000003 RID: 3
	private const int WM_KEYUP = 257;

	// Token: 0x04000004 RID: 4
	private const int WM_SYSKEYDOWN = 260;

	// Token: 0x04000005 RID: 5
	private const int WM_SYSKEYUP = 261;

	// Token: 0x04000006 RID: 6
	private GlobalKeyboardHook.LLKeyboardHook llkh;

	// Token: 0x04000007 RID: 7
	public List<Keys> HookedKeys = new List<Keys>();

	// Token: 0x04000008 RID: 8
	private IntPtr Hook = IntPtr.Zero;

	// Token: 0x0200000F RID: 15
	// (Invoke) Token: 0x0600021A RID: 538
	public delegate int LLKeyboardHook(int Code, int wParam, ref GlobalKeyboardHook.keyBoardHookStruct lParam);

	// Token: 0x02000010 RID: 16
	public struct keyBoardHookStruct
	{
		// Token: 0x0400028F RID: 655
		public int vkCode;

		// Token: 0x04000290 RID: 656
		public int scanCode;

		// Token: 0x04000291 RID: 657
		public int flags;

		// Token: 0x04000292 RID: 658
		public int time;

		// Token: 0x04000293 RID: 659
		public int dwExtraInfo;
	}
}
