using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
   public class WpfSfGroupDropArea:WpfControl
    {
       public new abstract class PropertyNames
       {
           public static readonly string IsExpanded = "IsExpanded";
           public static readonly string GroupDropAreaText = "GroupDropAreaText";
       }
       public WpfSfGroupDropArea()
       {
       }
       public WpfSfGroupDropArea(UITestControl control)
           : base(control)
       {
       }

       #region private fields
       private string isExpanded;
       private string groupDropAreaText;
       #endregion

       #region public properties
       /// <summary>
       /// Gets or Sets cell IsExpanded
       /// </summary>
       public virtual string IsExpanded
       {
           get
           {
               return isExpanded;
           }
           set
           {
               isExpanded = value;
           }

       }

       /// <summary>
       /// Gets or Sets the GroupDropAreaText
       /// </summary>
       public virtual string GroupDropAreaText
       {
           get
           {
               return groupDropAreaText;
           }
           set
           {
               groupDropAreaText = value;
           }
       }
       #endregion
    }
}
