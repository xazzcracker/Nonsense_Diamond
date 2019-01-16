using System;
using System.Windows.Forms;

namespace JailbreakDestroyer
{
	// Token: 0x02000008 RID: 8
	internal static class Program
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x00023A54 File Offset: 0x00021C54
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Whitelist());
		}
	}
}
