using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    public class SfMultiColumnDropDownContrlPropertyProvider : IUIControlPropertyProvider
    {
        #region Get the custom Properties

        private Dictionary<string, UITestPropertyDescriptor> multicolumnPropertiesMap;
        public Dictionary<string, UITestPropertyDescriptor> MultiColumnPropertiesMap
        {
            get
            {
                if (this.multicolumnPropertiesMap == null)
                {
                    this.multicolumnPropertiesMap = this.GetUIControlPropertiesMap();
                }
                return this.multicolumnPropertiesMap;
            }
        }

        #endregion

        /// <summary>
        /// Get the type of control
        /// </summary>
        public Type SpecializedType
        {
            get { return typeof(WpfSfMultiColumnDropDownControl); }
        }

        /// <summary>
        /// Get the Property value
        /// </summary>
        /// <param name="uiTestControl">UITestControl</param>
        /// <param name="propertyName">PropertyName</param>
        /// <returns>object</returns>
        public object GetUIControlPropertyValue(UITestControl uiTestControl, string propertyName)
        {
            return PropertyProviderHelper.GetUIControlPropertyValue(uiTestControl, propertyName, MultiColumnPropertiesMap);
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
            dictionary.Add(WpfSfMultiColumnDropDownControl.PropertyNames.AllowAutoComplete, new UITestPropertyDescriptor(typeof(bool), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfMultiColumnDropDownControl.PropertyNames.AllowNullInput, new UITestPropertyDescriptor(typeof(bool), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfMultiColumnDropDownControl.PropertyNames.AllowImmediatePopup, new UITestPropertyDescriptor(typeof(bool), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfMultiColumnDropDownControl.PropertyNames.AllowIncrementalFiltering, new UITestPropertyDescriptor(typeof(bool), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfMultiColumnDropDownControl.PropertyNames.AllowCaseSensitiveFiltering, new UITestPropertyDescriptor(typeof(bool), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfMultiColumnDropDownControl.PropertyNames.AllowSpinOnMouseWheel, new UITestPropertyDescriptor(typeof(bool), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfMultiColumnDropDownControl.PropertyNames.DisplayMember, new UITestPropertyDescriptor(typeof(string), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfMultiColumnDropDownControl.PropertyNames.IsDropDownOpen, new UITestPropertyDescriptor(typeof(bool), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfMultiColumnDropDownControl.PropertyNames.SelectedIndex, new UITestPropertyDescriptor(typeof(int), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfMultiColumnDropDownControl.PropertyNames.ValueMember, new UITestPropertyDescriptor(typeof(string), UITestPropertyAttributes.Readable));
            return dictionary;
        }

    }
}
