using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace JailbreakDestroyer.Properties
{
	// Token: 0x0200000B RID: 11
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060001DA RID: 474 RVA: 0x0002A6F1 File Offset: 0x000288F1
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0002A6FC File Offset: 0x000288FC
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("JailbreakDestroyer.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0002A744 File Offset: 0x00028944
		// (set) Token: 0x060001DD RID: 477 RVA: 0x0002A75B File Offset: 0x0002895B
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0002A764 File Offset: 0x00028964
		internal static Icon diamondlock_85R_icon
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("diamondlock_85R_icon", Resources.resourceCulture);
				return (Icon)@object;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0002A794 File Offset: 0x00028994
		internal static Icon diiamond1_9Ma_icon
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("diiamond1_9Ma_icon", Resources.resourceCulture);
				return (Icon)@object;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0002A7C4 File Offset: 0x000289C4
		internal static Icon nd_HmC_icon
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("nd_HmC_icon", Resources.resourceCulture);
				return (Icon)@object;
			}
		}

		// Token: 0x04000287 RID: 647
		private static ResourceManager resourceMan;

		// Token: 0x04000288 RID: 648
		private static CultureInfo resourceCulture;
	}
}
