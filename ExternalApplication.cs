using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

namespace BaanRevit
{
    class ExternalApplication : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            //Create Ribbon Tab
            application.CreateRibbonTab("Baan Revit");
            string path = Assembly.GetExecutingAssembly().Location;
            RibbonPanel convertUnit = application.CreateRibbonPanel("Baan Revit", "Convert Unit");

            // Imperial Icon
            Uri convertToImperialImg = new Uri(@"C:\Users\CHATPONG\source\repos\BaanDaily\Img\icon\Convert\Imperial.png");
            BitmapImage bitmapImperial = new BitmapImage(convertToImperialImg);

            // Metric Icon
            Uri convertToMetricImg = new Uri(@"C:\Users\CHATPONG\source\repos\BaanDaily\Img\icon\Convert\Metric.png");
            BitmapImage bitmapMetric = new BitmapImage(convertToMetricImg);

            //Botton
            PushButtonData convertToImperialButton = new PushButtonData("Button1", "Imperial Unit", path, "BaanRevit.ConvertUnitToImperial");
            PushButton convertToImperialPushButton = convertUnit.AddItem(convertToImperialButton) as PushButton;
            convertToImperialPushButton.LargeImage = bitmapImperial;
            convertToImperialPushButton.ToolTip = "Click to convert current unit project to Imperial unit.";

            PushButtonData convertToMetricButton = new PushButtonData("Button2", "Metric Unit", path, "BaanRevit.ConvertUnitToMetric");
            PushButton convertToMetricPushButton = convertUnit.AddItem(convertToMetricButton) as PushButton;
            convertToMetricPushButton.LargeImage = bitmapMetric;
            convertToMetricPushButton.ToolTip = "Click to convert current unit project to Metric unit.";


            return Result.Succeeded;
        }
    }
}
