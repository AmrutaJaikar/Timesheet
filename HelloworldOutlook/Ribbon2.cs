using HelloworldOutlook.Properties;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;

// TODO:  Follow these steps to enable the Ribbon (XML) item:

// 1: Copy the following code block into the ThisAddin, ThisWorkbook, or ThisDocument class.

//  protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
//  {
//      return new Ribbon2();
//  }

// 2. Create callback methods in the "Ribbon Callbacks" region of this class to handle user
//    actions, such as clicking a button. Note: if you have exported this Ribbon from the Ribbon designer,
//    move your code from the event handlers to the callback methods and modify the code to work with the
//    Ribbon extensibility (RibbonX) programming model.

// 3. Assign attributes to the control tags in the Ribbon XML file to identify the appropriate callback methods in your code.  

// For more information, see the Ribbon XML documentation in the Visual Studio Tools for Office Help.


namespace HelloworldOutlook
{
    [ComVisible(true)]
    public class Ribbon2 : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public Ribbon2()
        {
        }
 
public string GetSendTimesheetLabel(Office.IRibbonControl control)
{
    return "Send To TimeSheet";
}

        public void ShowMessageClick(Office.IRibbonControl control)
        {
            ReadAppointmentData(control);
           
        }

        private void ReadAppointmentData(IRibbonControl control)
        {
            var selection = control.Context as Microsoft.Office.Interop.Outlook.Selection;

            var appointmentItems = selection.OfType<Microsoft.Office.Interop.Outlook.AppointmentItem>().ToList();

            var appointmentItem = appointmentItems.ElementAt(0) as AppointmentItem;
            //MessageBox.Show(appointmentItem.Subject + " " + appointmentItem.Start.Day.ToString()+"/"+appointmentItem.Start.Month.ToString()+"/" +appointmentItem.Start.Year.ToString() + appointmentItem.Start.TimeOfDay.ToString() + " " + appointmentItem.End.TimeOfDay.ToString() + appointmentItem.Location, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (ExportToExcel(control, appointmentItem))
            {

                appointmentItem.Categories = "MyCategory";
                appointmentItem.Save();
            }
        }
        private bool ExportToExcel(IRibbonControl control, AppointmentItem appointmentItem)
        {
            Form1 formObj = new Form1(appointmentItem);
            formObj.FormBorderStyle = FormBorderStyle.FixedDialog;

            formObj.MaximizeBox = false;

            formObj.MinimizeBox = false;

            formObj.StartPosition = FormStartPosition.CenterScreen;

            //formObj.ShowDialog();
            formObj.Show();

            return true;
        /** Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
         Workbook wb = excelApp.Workbooks.Open("TimeSheetDBMS.xls");
         Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets.get_Item(1);
         xlWorkSheet.Cells[2, 1] = appointmentItem.Subject;
         xlWorkSheet.Cells[2, 2] = appointmentItem.Start.Day.ToString() + "/" + appointmentItem.Start.Month.ToString() + "/" + appointmentItem.Start.Year.ToString();
         xlWorkSheet.Cells[2, 3] = appointmentItem.Start.TimeOfDay.ToString();
         xlWorkSheet.Cells[2, 4] = appointmentItem.End.TimeOfDay.ToString();
         xlWorkSheet.Cells[2, 5] = appointmentItem.Location;
         wb.Save();*/
    }
        #region IRibbonExtensibility Members

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("HelloworldOutlook.Ribbon2.xml");
        }

        #endregion

        #region Ribbon Callbacks
        //Create callback methods here. For more information about adding callback methods, visit https://go.microsoft.com/fwlink/?LinkID=271226

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        #endregion

        #region Helpers

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
