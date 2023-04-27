using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;

namespace BaanRevit
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class ConvertUnitToMetric : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Get UIDocument
            UIDocument uidoc = commandData.Application.ActiveUIDocument;

            //Get Document
            Document doc = uidoc.Document;

            try
            {
                Units units = doc.GetUnits();
                FormatOptions formatOptions = new FormatOptions(DisplayUnitType.DUT_MILLIMETERS, 0.001);
                units.SetFormatOptions(UnitType.UT_Length, formatOptions);
                doc.SetUnits(units);

                return Result.Succeeded;
            } catch (Exception e)
            {
                message = e.Message;
                return Result.Failed;
            }
        }
    }
}
