using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace HelloworldOutlook
{
    

    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            /** Microsoft.Office.Interop.Excel.Application xlApp = new
            Microsoft.Office.Interop.Excel.Application();

             if (xlApp == null)
             {
                 MessageBox.Show("Excel is not properly installed!!");
                 return;
             }
             Workbook xlWorkBook = xlApp.Workbooks.Add();
             Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
             xlWorkSheet.Cells[1, 1] = "Subject";
             xlWorkSheet.Cells[1, 2] = "Date";
             xlWorkSheet.Cells[1, 3] = "Start-Time";
             xlWorkSheet.Cells[1, 4] = "End-Time";
             xlWorkSheet.Cells[1, 5] = "Locatiom";
             xlWorkBook.SaveAs("TimeSheetDBMS.xls");*/
            Microsoft.Office.Interop.Outlook.NameSpace ns = this.Application.GetNamespace("MAPI");

            if (ns.Categories["MyCategory"] == null)
            {

                ns.Categories.Add("MyCategory", Outlook.OlCategoryColor.olCategoryColorDarkGreen, Outlook.OlCategoryShortcutKey.olCategoryShortcutKeyNone);
            }
        }
       
protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            
            return new Ribbon2();
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
