using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    /// <summary>
    /// Provides ability to locate TreeGridRowControl in UI.
    /// </summary>
    public class WpfSfTreeGridRow : WpfControl
    {
        #region PropertyNames
        public new abstract class PropertyNames
        {
            public static readonly string RowIndex = "RowIndex";
            public static readonly string RowType = "RowType";
            public static readonly string IsSelected = "IsSelected";
        }
        #endregion

        public WpfSfTreeGridRow()
        {
        }
        public WpfSfTreeGridRow(UITestControl control)
            : base(control)
        {
        }

        #region private fields

        private string rowIndex;
        private string rowType;
        private string isSelected;

        #endregion

        #region public properties
        /// <summary>
        /// Get or Set the RowIndex
        /// </summary>
        public virtual string RowIndex
        {
            get
            {
                return rowIndex;
            }
            set
            {
                rowIndex = value;
            }

        }

        /// <summary>
        /// Get or Set the RowType
        /// </summary>
        public virtual string RowType
        {
            get
            {
                return rowType;
            }
            set
            {
                rowType = value;
            }
        }

        /// <summary>
        /// Get or Set the IsSelected
        /// </summary>
        public virtual string IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                isSelected = value;
            }

        }
        #endregion
    }
}
