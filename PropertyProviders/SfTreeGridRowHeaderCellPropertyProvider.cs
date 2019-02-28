using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    /// <summary>
    /// To provide custom properties for TreeGridRowHeaderCell.
    /// </summary>
    public class SfTreeGridRowHeaderCellPropertyProvider : IUIControlPropertyProvider
    {
        #region Get the custom Properties

        private Dictionary<string, UITestPropertyDescriptor> treeGridRowHeaderProperties;
        public Dictionary<string, UITestPropertyDescriptor> TreeGridRowHeaderProperties
        {
            get
            {
                if (treeGridRowHeaderProperties == null)
                {
                    treeGridRowHeaderProperties = GetUIControlPropertiesMap();
                }
                return treeGridRowHeaderProperties;
            }
        }

        #endregion

        /// <summary>
        /// Get the type of control
        /// </summary>
        public Type SpecializedType
        {
            get { return typeof(WpfSfTreeGridRowHeaderCell); }
        }

        /// <summary>
        /// Get the Property value
        /// </summary>
        /// <param name="uiTestControl">UITestControl</param>
        /// <param name="propertyName">PropertyName</param>
        /// <returns>object</returns>
        public object GetUIControlPropertyValue(UITestControl uiTestControl, string propertyName)
        {
            return PropertyProviderHelper.GetUIControlPropertyValue(uiTestControl, propertyName, TreeGridRowHeaderProperties);
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

        /// <summary>
        /// Invokes to get the list of UIControl proeprties
        /// </summary>
        /// <returns>Dictionary<string, UITestPropertyDescriptor></returns>
        public Dictionary<string, UITestPropertyDescriptor> GetUIControlPropertiesMap()
        {
            Dictionary<string, UITestPropertyDescriptor> dictionary = new Dictionary<string, UITestPropertyDescriptor>();
            dictionary.Add(WpfSfTreeGridRowHeaderCell.PropertyNames.RowIndex, new UITestPropertyDescriptor(typeof(int), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfTreeGridRowHeaderCell.PropertyNames.State, new UITestPropertyDescriptor(typeof(string), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfTreeGridRowHeaderCell.PropertyNames.RowErrorMessage, new UITestPropertyDescriptor(typeof(string), UITestPropertyAttributes.Readable));
            return dictionary;
        }
    }
}
