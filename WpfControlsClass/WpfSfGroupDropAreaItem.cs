using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    public class WpfSfGroupDropAreaItem:WpfControl
    {
        public new abstract class PropertyNames
        {
            public static readonly string GroupName = "GroupName";
            public static readonly string SortDirection = "SortDirection";
        }
        public WpfSfGroupDropAreaItem()
        {
        }
        public WpfSfGroupDropAreaItem(UITestControl control)
            : base(control)
        {
        }

        #region private fields
        private string groupName;
        private string sortDirection;
        #endregion

        #region public properties
        /// <summary>
        /// Gets or Sets cell GroupName
        /// </summary>
        public virtual string GroupName
        {
            get
            {
                return groupName;
            }
            set
            {
                groupName = value;
            }

        }

        /// <summary>
        /// Gets or Sets the SortDirection
        /// </summary>
        public virtual string SortDirection
        {
            get
            {
                return sortDirection;
            }
            set
            {
                sortDirection = value;
            }
        }
        #endregion
    }
}
