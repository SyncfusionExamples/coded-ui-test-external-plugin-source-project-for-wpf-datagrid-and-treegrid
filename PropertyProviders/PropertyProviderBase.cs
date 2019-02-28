using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Syncfusion.UI.Xaml.Grid;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

using System.Windows.Automation;
using System.Diagnostics;
using System.Windows.Automation.Peers;
using Syncfusion.UI.Xaml.Controls.DataPager;
using Microsoft.VisualStudio.TestTools.UITest.Common;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    public class ControlPropertyProviderBase : UITestPropertyProvider
    {
        # region Properties
        private bool isControlInProvider;

        private string controlIdentifier;

        internal string ControlIdentifier
        {
            get
            {
                return this.controlIdentifier;
            }
            set
            {
                if (this.controlIdentifier != value)
                {
                    this.controlIdentifier = value;
                }
            }
        }
        # endregion

        # region Overrides

        private Dictionary<string, IUIControlPropertyProvider> uiControlPropertyProviders;

        protected Dictionary<string, IUIControlPropertyProvider> UiControlPropertyProviders
        {
            get
            {
                if (this.uiControlPropertyProviders == null)
                {
                    this.uiControlPropertyProviders = new Dictionary<string, IUIControlPropertyProvider>();
                    this.uiControlPropertyProviders.Add("GridCell", new SfGridCellPropertyProvider());
                    this.uiControlPropertyProviders.Add("SfMultiColumnDropDownControl", new SfMultiColumnDropDownContrlPropertyProvider());
                    this.uiControlPropertyProviders.Add("SfDataPager", new SfDataPagerPropertyProvider());
                    this.uiControlPropertyProviders.Add("SfDataGrid", new SfDataGridPropertyProvider());
                    this.uiControlPropertyProviders.Add("DetailsViewDataGrid", new SfDetailsViewDataGridPropertyProvider());
                    this.UiControlPropertyProviders.Add("GroupDropArea", new SfGroupDropAreaPropertyProvider());
                    this.UiControlPropertyProviders.Add("GroupDropAreaItem", new SfGroupDropAreaItemPropertyProvider());
                    this.UiControlPropertyProviders.Add("GridRowHeaderCell", new SfRowHeaderCellPropertyProvider());
                    this.UiControlPropertyProviders.Add("GridHeaderCellControl", new SfHeaderCellControlPropertyProvider());
                    this.UiControlPropertyProviders.Add("GridStackedHeaderCellControl", new SfStackedHeaderCellControlPropertyProvider());
                    this.UiControlPropertyProviders.Add("VirtualizingCellsControl", new SfGridRowPropertyProvider());
                    this.UiControlPropertyProviders.Add("TreeGridCell", new SfTreeGridCellPropertyProvider());
                    this.UiControlPropertyProviders.Add("SfTreeGrid", new SfTreeGridPropertyProvider());
                    this.UiControlPropertyProviders.Add("TreeGridRowControl", new SfTreeGridRowPropertyProvider());
                    this.UiControlPropertyProviders.Add("TreeGridHeaderCell", new SfTreeGridHeaderCellPropertyProvider());
                    this.UiControlPropertyProviders.Add("TreeGridRowHeaderCell", new SfTreeGridRowHeaderCellPropertyProvider());
                    this.UiControlPropertyProviders.Add("TreeGridStackedHeaderCell", new SfTreeGridStackedHeaderCellPropertyProvider());
                }
                return this.uiControlPropertyProviders;
            }
        }

        public override int GetControlSupportLevel(UITestControl uiTestControl)
        {
            if (!this.isControlInProvider && this.IsSupported(uiTestControl))
            {
                return (int)ControlSupport.ControlSpecificSupport;
            }
            return (int)ControlSupport.NoSupport;
        }

        private bool IsSupported(UITestControl uiTestControl)
        {
           this.ControlIdentifier = this.GetControlIdentifier(uiTestControl);
            return this.ControlIdentifier != null && this.UiControlPropertyProviders.Keys.Contains(this.ControlIdentifier);
        }

        private string GetControlIdentifier(UITestControl uiTestControl)
        {
            string result = null;
            if (uiTestControl.SearchProperties.Contains("ClassName"))
            {
                result = uiTestControl.SearchProperties["ClassName"].Split(new char[]
						{
							'.'
						}).LastOrDefault<string>();
            }
            else
            {
                if (uiTestControl.SearchProperties.Contains("AutomationId"))
                {
                    result = uiTestControl.SearchProperties["AutomationId"].Split(new char[]{'_'}).LastOrDefault<string>();
                }
            }
            return result;
        }

        public override UITestPropertyDescriptor GetPropertyDescriptor(UITestControl uiTestControl, string propertyName)
        {
            this.isControlInProvider = true;
            UITestPropertyDescriptor result;
            try
            {
                Dictionary<string, UITestPropertyDescriptor> propertiesMap = this.UiControlPropertyProviders[this.ControlIdentifier].GetUIControlPropertiesMap();
                if (propertiesMap.ContainsKey(propertyName))
                {
                    result = propertiesMap[propertyName];
                }
                else
                {
                    result = null;
                }
            }
            finally
            {
                this.isControlInProvider = false;
            }
            return result;
        }
        
        public override string GetPropertyForAction(UITestControl uiTestControl, UITestAction action)
        {
             throw new NotSupportedException();
        }
        
        public override string[] GetPropertyForControlState(UITestControl uiTestControl, ControlStates uiState, out bool[] stateValues)
        {
            stateValues = null;
            return null;
        }
        
        public override ICollection<string> GetPropertyNames(UITestControl uiTestControl)
        {
            this.isControlInProvider = true;
            ICollection<string> result;
            try
            {
                if (this.IsSupported(uiTestControl))
                {
                    result = this.UiControlPropertyProviders[this.ControlIdentifier].GetUIControlPropertiesMap().Keys;
                }
                else
                {
                    result = null;
                }
            }
            finally
            {
                this.isControlInProvider = false;
            }
            return result;
        }
        
        public override Type GetPropertyNamesClassType(UITestControl uiTestControl)
        {
            return this.UiControlPropertyProviders[this.ControlIdentifier].SpecializedType.GetMember("PropertyNames").GetType();
        }
        
        public override object GetPropertyValue(UITestControl uiTestControl, string propertyName)
        {
            //WPF-25220 ControlIdentifier must not null  to avoid exception "Value Cannot be Null; Parameter Name Key"
            if (this.ControlIdentifier!=null &&((uiTestControl != null) || this.UiControlPropertyProviders.ContainsKey(this.ControlIdentifier)))
              return  this.UiControlPropertyProviders[this.ControlIdentifier].GetUIControlPropertyValue(uiTestControl, propertyName);
           throw new NotSupportedException();
        }

        public override Type GetSpecializedClass(UITestControl uiTestControl)
        {
            return this.UiControlPropertyProviders[this.ControlIdentifier].SpecializedType;
        }       

        public override void SetPropertyValue(UITestControl uiTestControl, string propertyName, object value)
        {          
          this.UiControlPropertyProviders[this.ControlIdentifier].SetUIControlPropertyValue(uiTestControl, propertyName, value);
        }
        
        public override string[] GetPredefinedSearchProperties(Type specializedClass)
        {
            return new string[]
	        {
		     UITestControl.PropertyNames.ControlType
	        };
           // throw new NotImplementedException();
        }

        # endregion
    }

    public interface IUIControlPropertyProvider 
    {
        Type SpecializedType
        {
            get;
        }
        Dictionary<string, UITestPropertyDescriptor> GetUIControlPropertiesMap();
        object GetUIControlPropertyValue(UITestControl uiTestControl, string propertyName);
        void SetUIControlPropertyValue(UITestControl uiTestControl, string propertyName, object value);
    }   
}
