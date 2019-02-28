using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    internal static class PropertyProviderHelper
    {
        internal static int FindIndex(string propertyName, Dictionary<string, UITestPropertyDescriptor> Properties)
        {
            int index = 0;
            foreach (var item in Properties)
            {
                if (item.Key == propertyName)
                    return index;
                index++;
            }
            return -1;
        }

        internal static object GetUIControlPropertyValue(UITestControl uiTestControl, string propertyName, Dictionary<string, UITestPropertyDescriptor> Properties)
        {
            if (Properties.ContainsKey(propertyName))
            {
                AutomationElement automationElement = uiTestControl.NativeElement as AutomationElement;
                AutomationElement.AutomationElementInformation current = automationElement.Current;
                if (current.ItemStatus.Equals(string.Empty))
                {
                    throw new NotSupportedException();
                }
                AutomationElement.AutomationElementInformation current2 = automationElement.Current;
                string[] array = current2.ItemStatus.Split(new string[]
                {
                    "#"
                }, StringSplitOptions.None);

                return array[PropertyProviderHelper.FindIndex(propertyName, Properties)];
            }
            else if (propertyName == "ClassName")
            {
                AutomationElement automationElement = uiTestControl.NativeElement as AutomationElement;
                AutomationElement.AutomationElementInformation current = automationElement.Current;
                return current.ClassName;
            }

            throw new NotSupportedException();

        }

    }
}
