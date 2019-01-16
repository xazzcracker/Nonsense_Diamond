using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace JailbreakDestroyer.Properties
{
	// Token: 0x0200000C RID: 12
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0002A7F4 File Offset: 0x000289F4
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000289 RID: 649
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
