using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"org/achartengine",
						"org/achartengine/chart",
						"org/achartengine/model",
						"org/achartengine/renderer",
						"org/achartengine/tools",
						"org/achartengine/util",
					},
					new Converter<string, Type>[]{
						lookup_org_achartengine_package,
						lookup_org_achartengine_chart_package,
						lookup_org_achartengine_model_package,
						lookup_org_achartengine_renderer_package,
						lookup_org_achartengine_tools_package,
						lookup_org_achartengine_util_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_org_achartengine_mappings;
		static Type lookup_org_achartengine_package (string klass)
		{
			if (package_org_achartengine_mappings == null) {
				package_org_achartengine_mappings = new string[]{
					"org/achartengine/ChartFactory:AChartEngine.ChartFactory",
					"org/achartengine/GraphicalActivity:AChartEngine.GraphicalActivity",
					"org/achartengine/GraphicalView:AChartEngine.GraphicalView",
					"org/achartengine/TouchHandler:AChartEngine.TouchHandler",
					"org/achartengine/TouchHandlerOld:AChartEngine.TouchHandlerOld",
				};
			}

			return Lookup (package_org_achartengine_mappings, klass);
		}

		static string[] package_org_achartengine_chart_mappings;
		static Type lookup_org_achartengine_chart_package (string klass)
		{
			if (package_org_achartengine_chart_mappings == null) {
				package_org_achartengine_chart_mappings = new string[]{
					"org/achartengine/chart/AbstractChart:AChartEngine.Chart.AbstractChart",
					"org/achartengine/chart/BarChart:AChartEngine.Chart.BarChart",
					"org/achartengine/chart/BarChart$Type:AChartEngine.Chart.BarChart/Type",
					"org/achartengine/chart/BubbleChart:AChartEngine.Chart.BubbleChart",
					"org/achartengine/chart/ClickableArea:AChartEngine.Chart.ClickableArea",
					"org/achartengine/chart/CombinedXYChart:AChartEngine.Chart.CombinedXYChart",
					"org/achartengine/chart/CubicLineChart:AChartEngine.Chart.CubicLineChart",
					"org/achartengine/chart/DialChart:AChartEngine.Chart.DialChart",
					"org/achartengine/chart/DoughnutChart:AChartEngine.Chart.DoughnutChart",
					"org/achartengine/chart/LineChart:AChartEngine.Chart.LineChart",
					"org/achartengine/chart/PieChart:AChartEngine.Chart.PieChart",
					"org/achartengine/chart/PieMapper:AChartEngine.Chart.PieMapper",
					"org/achartengine/chart/PieSegment:AChartEngine.Chart.PieSegment",
					"org/achartengine/chart/PointStyle:AChartEngine.Chart.PointStyle",
					"org/achartengine/chart/RangeBarChart:AChartEngine.Chart.RangeBarChart",
					"org/achartengine/chart/RoundChart:AChartEngine.Chart.RoundChart",
					"org/achartengine/chart/ScatterChart:AChartEngine.Chart.ScatterChart",
					"org/achartengine/chart/TimeChart:AChartEngine.Chart.TimeChart",
					"org/achartengine/chart/XYChart:AChartEngine.Chart.XYChart",
				};
			}

			return Lookup (package_org_achartengine_chart_mappings, klass);
		}

		static string[] package_org_achartengine_model_mappings;
		static Type lookup_org_achartengine_model_package (string klass)
		{
			if (package_org_achartengine_model_mappings == null) {
				package_org_achartengine_model_mappings = new string[]{
					"org/achartengine/model/CategorySeries:AChartEngine.Model.CategorySeries",
					"org/achartengine/model/MultipleCategorySeries:AChartEngine.Model.MultipleCategorySeries",
					"org/achartengine/model/Point:AChartEngine.Model.Point",
					"org/achartengine/model/RangeCategorySeries:AChartEngine.Model.RangeCategorySeries",
					"org/achartengine/model/SeriesSelection:AChartEngine.Model.SeriesSelection",
					"org/achartengine/model/TimeSeries:AChartEngine.Model.TimeSeries",
					"org/achartengine/model/XYMultipleSeriesDataset:AChartEngine.Model.XYMultipleSeriesDataset",
					"org/achartengine/model/XYSeries:AChartEngine.Model.XYSeries",
					"org/achartengine/model/XYValueSeries:AChartEngine.Model.XYValueSeries",
				};
			}

			return Lookup (package_org_achartengine_model_mappings, klass);
		}

		static string[] package_org_achartengine_renderer_mappings;
		static Type lookup_org_achartengine_renderer_package (string klass)
		{
			if (package_org_achartengine_renderer_mappings == null) {
				package_org_achartengine_renderer_mappings = new string[]{
					"org/achartengine/renderer/BasicStroke:AChartEngine.Renderer.BasicStroke",
					"org/achartengine/renderer/DefaultRenderer:AChartEngine.Renderer.DefaultRenderer",
					"org/achartengine/renderer/DialRenderer:AChartEngine.Renderer.DialRenderer",
					"org/achartengine/renderer/DialRenderer$Type:AChartEngine.Renderer.DialRenderer/Type",
					"org/achartengine/renderer/SimpleSeriesRenderer:AChartEngine.Renderer.SimpleSeriesRenderer",
					"org/achartengine/renderer/XYMultipleSeriesRenderer:AChartEngine.Renderer.XYMultipleSeriesRenderer",
					"org/achartengine/renderer/XYMultipleSeriesRenderer$Orientation:AChartEngine.Renderer.XYMultipleSeriesRenderer/Orientation",
					"org/achartengine/renderer/XYSeriesRenderer:AChartEngine.Renderer.XYSeriesRenderer",
				};
			}

			return Lookup (package_org_achartengine_renderer_mappings, klass);
		}

		static string[] package_org_achartengine_tools_mappings;
		static Type lookup_org_achartengine_tools_package (string klass)
		{
			if (package_org_achartengine_tools_mappings == null) {
				package_org_achartengine_tools_mappings = new string[]{
					"org/achartengine/tools/AbstractTool:AChartEngine.Tools.AbstractTool",
					"org/achartengine/tools/FitZoom:AChartEngine.Tools.FitZoom",
					"org/achartengine/tools/Pan:AChartEngine.Tools.Pan",
					"org/achartengine/tools/Zoom:AChartEngine.Tools.Zoom",
					"org/achartengine/tools/ZoomEvent:AChartEngine.Tools.ZoomEvent",
				};
			}

			return Lookup (package_org_achartengine_tools_mappings, klass);
		}

		static string[] package_org_achartengine_util_mappings;
		static Type lookup_org_achartengine_util_package (string klass)
		{
			if (package_org_achartengine_util_mappings == null) {
				package_org_achartengine_util_mappings = new string[]{
					"org/achartengine/util/MathHelper:AChartEngine.Util.MathHelper",
					"org/achartengine/util/XYEntry:AChartEngine.Util.XYEntry",
				};
			}

			return Lookup (package_org_achartengine_util_mappings, klass);
		}
	}
}
