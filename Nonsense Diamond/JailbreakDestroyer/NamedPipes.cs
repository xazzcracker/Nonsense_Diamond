using System;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JailbreakDestroyer
{
	// Token: 0x02000006 RID: 6
	internal class NamedPipes
	{
		// Token: 0x06000020 RID: 32
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		// Token: 0x06000021 RID: 33 RVA: 0x000045FC File Offset: 0x000027FC
		public static bool NamedPipeExist(string pipeName)
		{
			bool result;
			try
			{
				int timeout = 0;
				bool flag = !NamedPipes.WaitNamedPipe(Path.GetFullPath(string.Format("\\\\\\\\.\\\\pipe\\\\{0}", pipeName)), timeout);
				if (flag)
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					bool flag2 = lastWin32Error == 0;
					if (flag2)
					{
						result = false;
						return result;
					}
					bool flag3 = lastWin32Error == 2;
					if (flag3)
					{
						result = false;
						return result;
					}
				}
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000467C File Offset: 0x0000287C
		public static void LuaPipe(string script)
		{
			bool flag = NamedPipes.NamedPipeExist(NamedPipes.luapipename);
			if (flag)
			{
				new Thread(delegate()
				{
					try
					{
						using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", NamedPipes.luapipename, PipeDirection.Out))
						{
							namedPipeClientStream.Connect();
							using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream, Encoding.Default, 999999))
							{
								streamWriter.Write(script);
								streamWriter.Dispose();
							}
							namedPipeClientStream.Dispose();
						}
					}
					catch (IOException)
					{
						MessageBox.Show("Error occured connecting to the pipe.", "Connection Failed!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message.ToString());
					}
				}).Start();
			}
			else
			{
				MessageBox.Show("Inject " + Functions.exploitdllname + " before Using this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x04000023 RID: 35
		public static string luapipename = "RoSploit";
	}
}
