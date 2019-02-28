
[assembly: Microsoft.VisualStudio.TestTools.UITest.Extension.UITestExtensionPackage(
                "Syncfusion.VisualStudio.Extension",
                typeof(Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension.Extension))]
namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    using Microsoft.VisualStudio.TestTools.UITest.Common;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Extension : UITestExtensionPackage
    {
        public override object GetService(Type serviceType)
        {
            if (serviceType == typeof(UITestPropertyProvider))
            {
                if (propertyProvider == null)
                {
                    propertyProvider = new ControlPropertyProviderBase();
                }
                return propertyProvider;
            }
            return null;
        }

        public override void Dispose()
        {
            propertyProvider = null;          //throw new NotImplementedException();
        }

        public override string PackageDescription
        {
            get { return "Coded UI Support"; }
        }

        public override string PackageName
        {
            get { return "VSTT Extension"; }
        }

        public override string PackageVendor
        {
            get { return "Syncfusion"; }
        }

        public override Version PackageVersion
        {
            get { return new Version(1, 0); }
        }

        public override Version VSVersion
        {
            get
            {
#if SyncfusionFramework4_5
                return new Version(11, 0);
#else
                return new Version(10, 0);
#endif
            }
        }
        private UITestPropertyProvider propertyProvider;
    }

   
}
