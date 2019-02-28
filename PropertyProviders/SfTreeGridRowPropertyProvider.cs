using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    /// <summary>
    /// To provide custom properties for TreeGridRowControlBase.
    /// </summary>
    public class SfTreeGridRowPropertyProvider : IUIControlPropertyProvider
    {
        #region Get the custom Properties

        private Dictionary<string, UITestPropertyDescriptor> treeGridRowProperties;
        public Dictionary<string, UITestPropertyDescriptor> TreeGridRowProperties
        {
            get
            {
                if (treeGridRowProperties == null)
                {
                    treeGridRowProperties = GetUIControlPropertiesMap();
                }
                return treeGridRowProperties;
            }
        }

        #endregion

        /// <summary>
        /// Get the type of control
        /// </summary>
        public Type SpecializedType
        {
            get
            {
                return typeof(WpfSfTreeGridRow);
            }
        }

        /// <summary>
        /// Invokes to get the list of UIControl proeprties
        /// </summary>
        /// <returns>Dictionary<string, UITestPropertyDescriptor></returns>
        public Dictionary<string, UITestPropertyDescriptor> GetUIControlPropertiesMap()
        {
            Dictionary<string, UITestPropertyDescriptor> dictionary = new Dictionary<string, UITestPropertyDescriptor>();
            dictionary.Add(WpfSfTreeGridRow.PropertyNames.RowIndex, new UITestPropertyDescriptor(typeof(string), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfTreeGridRow.PropertyNames.RowType, new UITestPropertyDescriptor(typeof(string), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfTreeGridRow.PropertyNames.IsSelected, new UITestPropertyDescriptor(typeof(string), UITestPropertyAttributes.Readable));
            return dictionary;
        }

        /// <summary>
        /// Get the Property value
        /// </summary>
        /// <param name="uiTestControl">UITestControl</param>
        /// <param name="propertyName">PropertyName</param>
        /// <returns>object</returns>
        public object GetUIControlPropertyValue(UITestControl uiTestControl, string propertyName)
        {
            return PropertyProviderHelper.GetUIControlPropertyValue(uiTestControl, propertyName, TreeGridRowProperties);
        }

        /// <summary>
        /// Set the PropertyValue
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
    }
}
