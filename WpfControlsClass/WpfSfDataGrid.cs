using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    public class WpfSfDataGrid : WpfControl
    {
        public new abstract class PropertyNames
        {
            public static readonly string RowCount = "RowCount";
            public static readonly string ColumnCount = "ColumnCount";
            public static readonly string SelectionMode = "SelectionMode";
            public static readonly string SelectionUnit = "SelectionUnit";
            public static readonly string SelectedIndex = "SelectedIndex";
            public static readonly string SelectedItemCount ="SelectedItemCount";
            
        }

        public WpfSfDataGrid()
            : this(null)
        {
        }
        public WpfSfDataGrid(UITestControl parent)
            : base(parent)
        {
        }

        #region private fields

        private string rowCount;
        private string columnCount;
        private string selectionMode;
        private string selectionUnit;
        private string selectedIndex;
        private string selectedItemCount;

        #endregion

        #region public properties
        
        /// <summary>
        /// Gets or Sets cell RowCount
        /// </summary>
        public virtual string RowCount
        {
            get
            {
                return rowCount;
            }
            set
            {
                rowCount = value;
            }

        }

        /// <summary>
        /// Gets or Sets the ColumnCount
        /// </summary>
        public virtual string ColumnCount
        {
            get
            {
                return columnCount;
            }
            set
            {
                columnCount = value;
            }
        }

        /// <summary>
        /// Gets or Sets the SelectionMode
        /// </summary>
        public virtual string SelectionMode
        {
            get
            {
                return selectionMode;
            }
            set
            {
                selectionMode = value;
            }
        }

        /// <summary>
        /// Gets or Sets the SelectionUnit
        /// </summary>
        public virtual string SelectionUnit
        {
            get
            {
                return selectionUnit;
            }
            set
            {
                selectionUnit = value;
            }
        }

        /// <summary>
        /// Gets or Sets the SelectedIndex
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
        ///  Gets or Sets the SelectedItemCount
        /// </summary>
        public virtual string SelectedItemCount
        {
            get
            {
                return selectedItemCount;
            }
            set
            {
                selectedItemCount = value;
            }
        }

        #endregion

    }
}
