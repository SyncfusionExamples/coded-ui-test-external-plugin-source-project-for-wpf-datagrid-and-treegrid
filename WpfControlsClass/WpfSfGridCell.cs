using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syncfusion.VisualStudio.TestTools.UITest.SfGridExtension
{
    public class WpfSfGridCell : WpfControl
    {
        #region abstract class

        public new abstract class PropertyNames 
        {
            public static readonly string CellValue = "CellValue";
            public static readonly string FormattedValue = "FormattedValue"; 
            public static readonly string RowIndex = "RowIndex";
            public static readonly string ColumnIndex = "ColumnIndex";
            public static readonly string ColumnName = "ColumnName";
            public static readonly string HeaderText = "HeaderText";  
        }

        #endregion

        #region  ctor

        public WpfSfGridCell()
        {
        }
        public WpfSfGridCell(UITestControl control)
            : base(control)
        {
        }

        #endregion

        #region private fields

        private string cellValue;
        private string formattedVlaue;
        private string rowIndex;
        private string columnIndex;
        private string columnName;
        private string headerText;
        private bool isFound = false;

        #endregion

        #region public properties
        /// <summary>
        /// Gets or Sets cell value
        /// </summary>
        public virtual string CellValue
        {
            get
            {
                if (!this.isFound)
                    this.Find();
                return cellValue;
            }
            set
            {
                cellValue = value;
            }

        }

        /// <summary>
        /// Gets or Sets the formattedvalue
        /// </summary>
        public virtual string FormattedValue
        {
            get
            {
                if (!this.isFound)
                    this.Find();
                return formattedVlaue;
            }
            set
            {
                formattedVlaue = value;
            }
        }

        /// <summary>
        /// Gets or Sets the rowindex
        /// </summary>
        public virtual string RowIndex
        {
            get
            {
                if (!this.isFound)
                    this.Find();
                return rowIndex;
            }
            set
            {
                rowIndex = value;
            }
        }

        /// <summary>
        /// Gets or Sets the columnindex
        /// </summary>
        public virtual string ColumnIndex
        {
            get
            {
                if (!this.isFound)
                    this.Find();
                return columnIndex;
            }
            set
            {
                columnIndex = value;
            }
        }

        /// <summary>
        /// Gets or Sets the columnname
        /// </summary>
        public virtual string ColumnName
        {
            get
            {
                if (!this.isFound)
                    this.Find();
                return columnName;
            }
            set
            {
                columnName = value;
            }
        }

        /// <summary>
        /// Gets or Sets the Header Text of GridColumn
        /// </summary>
        public virtual string HeaderText
        {
            get
            {
                if (!this.isFound)
                    this.Find();
                return headerText;
            }
            set
            {
                headerText = value;
            }
        }
        #endregion

        #region override methods

        public override void Find()
        {
            //create UITestControl from current instance
            UITestControl control = new UITestControl();
            control.CopyFrom(this);
            //get the search properties from grid cell instance
            var properties = control.SearchProperties.ToList();

            var cellProperties = new List<string>();
            cellProperties.Add("CellValue");
            cellProperties.Add("FormattedValue");
            cellProperties.Add("RowIndex");
            cellProperties.Add("ColumnIndex");
            cellProperties.Add("ColumnName");
            cellProperties.Add("HeaderText");

            bool isContainProperty = false;
            foreach (var property in properties)
            {
                if (cellProperties.Contains(property.PropertyName))
                {
                    isContainProperty = true;
                    break;
                }
            }

            if (isContainProperty)
            {
                // throw exception if properties are not enough to search a control
                if (properties.Count < 2 && (properties[0].PropertyName != "CellValue" && properties[0].PropertyName != "FormattedValue"))
                    throw new UITestException("Not Enough Properties to find a control");

                // get the collection of child elements from  sfgrid container
                UITestControlCollection rowsCollection = control.Container.GetChildren();
                //bool flag = false;
                foreach (UITestControl row in rowsCollection)
                {
                    if (row.ClassName == "Uia.VirtualizingCellsControl")
                    {
                        UITestControlCollection collection = row.GetChildren();
                        foreach (UITestControl child in collection)
                        {
                            // check child is grid cell
                            if (child.ClassName == "Uia.GridCell")
                            {
                                Dictionary<string, string> childPropertiesDictonary = new Dictionary<string, string>();
                                System.Windows.Automation.AutomationElement automationElement = child.NativeElement as System.Windows.Automation.AutomationElement;
                                if (automationElement == null)
                                    continue;
                                System.Windows.Automation.AutomationElement.AutomationElementInformation current2 = automationElement.Current;
                                string[] array = current2.ItemStatus.Split(new string[]
                                            {
                                                "#"
                                            }, StringSplitOptions.None);

                                // assign the properties values to corresponding variable for condition checking
                                childPropertiesDictonary.Add("CellValue", array[0]);
                                childPropertiesDictonary.Add("FormattedValue", array[1]);
                                childPropertiesDictonary.Add("RowIndex", array[2]);
                                childPropertiesDictonary.Add("ColumnIndex", array[3]);
                                childPropertiesDictonary.Add("ColumnName", array[4]);
                                childPropertiesDictonary.Add("HeaderText", array[5]);

                                // set flag to true if  all property values are match to  child control                      
                                foreach (var item in properties)
                                {
                                    if (childPropertiesDictonary.Keys.Contains(item.PropertyName))
                                    {
                                        if (childPropertiesDictonary[item.PropertyName] == item.PropertyValue)
                                            isFound = true;
                                        else
                                        {
                                            isFound = false;
                                            break;
                                        }
                                    }

                                }

                                // here this condition check is  used  for finding exact gridcell from its given proerty values
                                if (isFound)
                                {
                                    //set the  corresponding cell values to its properties.
                                    this.cellValue = array[0];
                                    this.formattedVlaue = array[1];
                                    this.rowIndex = array[2];
                                    this.columnIndex = array[3];
                                    this.columnName = array[4];
                                    this.headerText = array[5];
                                    // copy the  found cell as this  instance
                                    this.CopyFrom(child);

                                    childPropertiesDictonary = null;
                                    break;
                                }
                            }
                        }

                        if (isFound)
                            break;
                    }
                }
                if (!isFound)
                    throw new UITestException("Not Maching control for this sepecific property");
            }
            else
            {
                base.Find();
                System.Windows.Automation.AutomationElement automationElement = this.NativeElement as System.Windows.Automation.AutomationElement;
                if (automationElement == null)
                    throw new UITestException("Not Maching control for this sepecific property");
                System.Windows.Automation.AutomationElement.AutomationElementInformation current2 = automationElement.Current;
                string[] array = current2.ItemStatus.Split(new string[]
                                            {
                                                "#"
                                            }, StringSplitOptions.None);
                if (array.Count() != 0)
                {
                    this.cellValue = array[0];
                    this.formattedVlaue = array[1];
                    this.rowIndex = array[2];
                    this.columnIndex = array[3];
                    this.columnName = array[4];
                }
                else
                {
                    throw new UITestException("Not Maching control for this sepecific property");
                }
            }
        }
        #endregion

        public new bool TryFind()
        {
            try
            {
                this.Find();
                return true;
            }
            catch (UITestException)
            {
                return false;
            }

        }
      
    }
}
