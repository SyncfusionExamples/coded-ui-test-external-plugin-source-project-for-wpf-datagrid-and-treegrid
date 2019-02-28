using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    public class WpfSfRowHeaderCell:WpfControl
    {
        public new abstract class PropertyNames
        {
            public static readonly string RowIndex = "RowIndex";
            public static readonly string State = "State";
            public static readonly string RowErrorMessage = "RowErrorMessage";
        }
        public WpfSfRowHeaderCell()
        {
        }
        public WpfSfRowHeaderCell(UITestControl control)
            : base(control)
        {
        }

        #region private fields

        private string rowIndex;
        private string state;
        private string rowErrorMessage;

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
        /// Get or Set the State
        /// </summary>
        public new virtual string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        /// <summary>
        /// Get or Set the RowErrorMessage
        /// </summary>
        public virtual string RowErrorMessage
        {
            get
            {
                return rowErrorMessage;
            }
            set
            {
                rowErrorMessage = value;
            }

        }
        #endregion
    }
}
