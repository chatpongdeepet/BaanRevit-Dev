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
    [Transaction(TransactionMode.Manual)]
    public class AddSharedParameter : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                //Get UIDocument
                UIDocument uidoc = commandData.Application.ActiveUIDocument;
                Document doc = uidoc.Document;

                List<string> parameterGroupNames = new List<string>();
                foreach (DefinitionGroup group in doc.Application.OpenSharedParameterFile().Groups)
                    parameterGroupNames.Add(group.Name);
                {
                    
                }

                return Result.Succeeded;
            }
            catch (Exception e)
            {
                message = e.Message;
                return Result.Failed;
            }
        }
    }
}
