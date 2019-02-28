using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    public class SfStackedHeaderCellControlPropertyProvider : IUIControlPropertyProvider
    {
        #region Get the custom Properties

        private Dictionary<string, UITestPropertyDescriptor> headerCellProperties;
        public Dictionary<string, UITestPropertyDescriptor> HeaderCellControlProperties
        {
            get
            {
                if (headerCellProperties == null)
                {
                    headerCellProperties = GetUIControlPropertiesMap();
                }
                return headerCellProperties;
            }
        }

        #endregion

        /// <summary>
        /// Get the type of control
        /// </summary>
        public Type SpecializedType
        {
            get { return typeof(WpfSfStackedHeaderCellControl); }
        }

        /// <summary>
        /// Get the Property value
        /// </summary>
        /// <param name="uiTestControl">UITestControl</param>
        /// <param name="propertyName">PropertyName</param>
        /// <returns>object</returns>
        public object GetUIControlPropertyValue(UITestControl uiTestControl, string propertyName)
        {
            return PropertyProviderHelper.GetUIControlPropertyValue(uiTestControl, propertyName, HeaderCellControlProperties);
        }

        /// <summary>
        /// Set the Property Value
        /// </summary>
        /// <param name="uiTestControl">UiTestControl</param>
        /// <param name="propertyName">PropertyName</param>
        /// <param name="value">value</param>
        public void SetUIControlPropertyValue(UITestControl uiTestControl, string propertyName, object value)
        {
            if (uiTestControl != null)
            {
                uiTestControl.SetProperty(propertyName, value);
            }
        }

        /// <summary>
        /// Invokes to get the list of UIControl proeprties
        /// </summary>
        /// <returns>Dictionary<string, UITestPropertyDescriptor></returns>
        public Dictionary<string, UITestPropertyDescriptor> GetUIControlPropertiesMap()
        {
            Dictionary<string, UITestPropertyDescriptor> dictionary = new Dictionary<string, UITestPropertyDescriptor>();
            dictionary.Add(WpfSfStackedHeaderCellControl.PropertyNames.ColumnName, new UITestPropertyDescriptor(typeof(string), UITestPropertyAttributes.Readable));
            return dictionary;
        }
    }
}
