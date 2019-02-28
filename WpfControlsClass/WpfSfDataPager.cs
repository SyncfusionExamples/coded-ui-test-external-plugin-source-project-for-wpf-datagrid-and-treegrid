using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    public class WpfSfDataPager:WpfControl
    {
        public new abstract class PropertyNames
        {
            public static readonly string AccentBackground = "AccentBackground";
            public static readonly string AccentForeground = "AccentForeground";
            public static readonly string AutoEllipsisMode = "AutoEllipsisMode";
            public static readonly string AutoEllipsisText = "AutoEllipsisText";
            public static readonly string DisplayMode = "DisplayMode";
            public static readonly string EnableGridPaging = "EnableGridPaging";
            public static readonly string NumericButtonCount = "NumericButtonCount";
            public static readonly string Orientation = "Orientation";
            public static readonly string PageCount = "PageCount";
            public static readonly string PageSize = "PageSize";
            public static readonly string UseOnDemandPaging = "UseOnDemandPaging";
        }

        public WpfSfDataPager()
            : this(null)
        {
        }
        public WpfSfDataPager(UITestControl parent)
            : base(parent)
        {
        }

        #region private fields
        private string accentBackground;
        private string accentForeground;
        private string autoEllipsisMode;
        private string autoEllipsisText;
        private string displayMode;
        private string enableGridPaging;
        private string numericButtonCount;
        private string orientation;
        private string pageCount;
        private string pageSize;
        private string useOnDemandPaging;
        #endregion

        #region public properties
        public virtual string AccentBackground 
        {
            get
            {
                return accentBackground;
            }
            set
            {
                accentBackground = value;
            }
        }

        /// <summary>
        /// Get or Set AccentForeground
        /// </summary>
        public virtual string AccentForeground
        {
            get
            {
                return accentForeground;
            }
            set
            {
                accentForeground = value;
            }
        }

        /// <summary>
        /// Get or Set AutoEllipsisMode
        /// </summary>
        public virtual string AutoEllipsisMode
        {
            get
            {
                return autoEllipsisMode;
            }
            set
            {
                autoEllipsisMode = value;
            }
        }

        /// <summary>
        /// Get or Set AutoEllipsisText
        /// </summary>
        public virtual string AutoEllipsisText
        {
            get
            {
                return autoEllipsisText;
            }
            set
            {
                autoEllipsisText = value;
            }
        }

        /// <summary>
        /// Get or Set DisplayMode
        /// </summary>
        public virtual string DisplayMode
        {
            get
            {
                return displayMode;
            }
            set
            {
                displayMode = value;
            }
        }

        /// <summary>
        /// Get or Set EnableGridPaging
        /// </summary>
        public virtual string EnableGridPaging
        {
            get
            {
                return enableGridPaging;
            }
            set
            {
                enableGridPaging = value;
            }
        }

        /// <summary>
        /// Get or Set NumericButtonCount
        /// </summary>
        public virtual string NumericButtonCount
        {
            get
            {
                return numericButtonCount;
            }
            set
            {
                numericButtonCount = value;
            }
        }

        /// <summary>
        /// Get or Set Orientation
        /// </summary>
        public virtual string Orientation
        {
            get
            {
                return orientation;
            }
            set
            {
                orientation = value;
            }
        }

        /// <summary>
        /// Get or Set PageCount
        /// </summary>
        public virtual string PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
            }
        }

        /// <summary>
        /// Get or Set PageSize
        /// </summary>
        public virtual string PageSize
        {
            get
            {
                return pageSize;
            }
            set
            {
                pageSize = value;
            }
        }

        /// <summary>
        /// Get or Set UseOnDemandPaging
        /// </summary>
        public virtual string UseOnDemandPaging
        {
            get
            {
                return useOnDemandPaging;
            }
            set
            {
                useOnDemandPaging = value;
            }
        }
        #endregion 
    }

}
