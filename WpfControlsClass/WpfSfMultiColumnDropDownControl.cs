using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    public class WpfSfMultiColumnDropDownControl : WpfControl
    {
        public new abstract class PropertyNames
        {
            public static readonly string AllowAutoComplete = "AllowAutoComplete";
            public static readonly string AllowNullInput = "AllowNullInput";
            public static readonly string AllowImmediatePopup = "AllowImmediatePopup";
            public static readonly string AllowIncrementalFiltering = "AllowIncrementalFiltering";
            public static readonly string AllowCaseSensitiveFiltering = "AllowCaseSensitiveFiltering";
            public static readonly string AllowSpinOnMouseWheel = "AllowSpinOnMouseWheel";
            public static readonly string DisplayMember = "DisplayMember";
            public static readonly string IsDropDownOpen = "IsDropDownOpen";
            public static readonly string SelectedIndex = "SelectedIndex";
            public static readonly string ValueMember = "ValueMember";
        }
        public WpfSfMultiColumnDropDownControl()
        {
        }
        public WpfSfMultiColumnDropDownControl(UITestControl control)
            : base(control)
        {
        }

        #region private fields

        private string allowAutoComplete;
        private string allowNullInput;
        private string allowImmediatePopup;
        private string allowIncrementalFiltering;
        private string allowCaseSensitiveFiltering;
        private string allowSpinOnMouseWheel;
        private string displayMember;
        private string isDropDownOpen;
        private string selectedIndex;
        private string valueMember;

        #endregion


        #region public properties

        /// <summary>
        /// Get or Set AllowAutoComplete
        /// </summary>
        public virtual string AllowAutoComplete
        {
            get
            {
                return allowAutoComplete;
            }
            set
            {
                allowAutoComplete = value;
            }
        }

        /// <summary>
        /// Get or Set AllowNullInput
        /// </summary>
        public virtual string AllowNullInput
        {
            get
            {
                return allowNullInput;
            }
            set
            {
                allowNullInput = value;
            }
        }

        /// <summary>
        /// Get or Set AllowImmediatePopup
        /// </summary>
        public virtual string AllowImmediatePopup
        {
            get
            {
                return allowImmediatePopup;
            }
            set
            {
                allowImmediatePopup = value;
            }
        }

        /// <summary>
        /// Get or Set AllowIncrementalFiltering
        /// </summary>
        public virtual string AllowIncrementalFiltering
        {
            get
            {
                return allowIncrementalFiltering;
            }
            set
            {
                allowIncrementalFiltering = value;
            }
        }

        /// <summary>
        /// Get or Set AllowCaseSensitiveFiltering
        /// </summary>
        public virtual string AllowCaseSensitiveFiltering
        {
            get
            {
                return allowCaseSensitiveFiltering;
            }
            set
            {
                allowCaseSensitiveFiltering = value;
            }
        }

        /// <summary>
        /// Get or Set AllowSpinOnMouseWheel
        /// </summary>
        public virtual string AllowSpinOnMouseWheel
        {
            get
            {
                return allowSpinOnMouseWheel;
            }
            set
            {
                allowSpinOnMouseWheel = value;
            }
        }

        /// <summary>
        /// Get or Set DisplayMember
        /// </summary>
        public virtual string DisplayMember
        {
            get
            {
                return displayMember;
            }
            set
            {
                displayMember = value;
            }
        }

        /// <summary>
        /// Get or Set IsDropDownOpen
        /// </summary>
        public virtual string IsDropDownOpen
        {
            get
            {
                return isDropDownOpen;
            }
            set
            {
                isDropDownOpen = value;
            }
        }

        /// <summary>
        /// Get or Set SelectedIndex
        /// </summary>
        public virtual string SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
            set
            {
                selectedIndex = value;
            }
        }

        /// <summary>
        /// Get or Set ValueMember
        /// </summary>
        public virtual string ValueMember
        {
            get
            {
                return valueMember;
            }
            set
            {
                valueMember = value;
            }
        }

        #endregion 
    }

}
