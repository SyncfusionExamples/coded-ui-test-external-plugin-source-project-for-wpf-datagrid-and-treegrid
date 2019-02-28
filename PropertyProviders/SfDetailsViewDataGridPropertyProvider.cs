using Microsoft.VisualStudio.TestTools.UITesting;
using Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    public class SfDetailsViewDataGridPropertyProvider : IUIControlPropertyProvider
    {
        #region Get the custom Properties

        private Dictionary<string, UITestPropertyDescriptor> detailsViewDataGridPropertiesMap;
        public Dictionary<string, UITestPropertyDescriptor> DetailsViewDataGridPropertiesMap
        {
            get
            {
                if (this.detailsViewDataGridPropertiesMap == null)
                {
                    this.detailsViewDataGridPropertiesMap = this.GetUIControlPropertiesMap();
                }
                return this.detailsViewDataGridPropertiesMap;
            }
        }

        #endregion

        /// <summary>
        /// Get the type of control
        /// </summary>
        public Type SpecializedType
        {
            get { return typeof(WpfSfDetailsViewDataGrid); }
        }

        /// <summary>
        /// Get the Property value
        /// </summary>
        /// <param name="uiTestControl">UITestControl</param>
        /// <param name="propertyName">PropertyName</param>
        /// <returns>object</returns>
        public object GetUIControlPropertyValue(UITestControl uiTestControl, string propertyName)
        {
            return PropertyProviderHelper.GetUIControlPropertyValue(uiTestControl, propertyName, DetailsViewDataGridPropertiesMap);
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
            dictionary.Add(WpfSfDetailsViewDataGrid.PropertyNames.RowCount, new UITestPropertyDescriptor(typeof(int), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfDetailsViewDataGrid.PropertyNames.ColumnCount, new UITestPropertyDescriptor(typeof(int), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfDetailsViewDataGrid.PropertyNames.SelectionMode, new UITestPropertyDescriptor(typeof(string), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfDetailsViewDataGrid.PropertyNames.SelectionUnit, new UITestPropertyDescriptor(typeof(string), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfDetailsViewDataGrid.PropertyNames.SelectedIndex, new UITestPropertyDescriptor(typeof(int), UITestPropertyAttributes.Readable));
            dictionary.Add(WpfSfDetailsViewDataGrid.PropertyNames.SelectedItemCount, new UITestPropertyDescriptor(typeof(int), UITestPropertyAttributes.Readable));
            return dictionary;
        }
    }
}
