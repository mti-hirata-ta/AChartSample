using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//add
using AChartEngine;
using AChartEngine.Chart;
using AChartEngine.Model;
using AChartEngine.Renderer;
using Android.Graphics;
using Java.Util;

namespace GraphSampleAChart
{
    [Activity (Label = "GraphSampleAChart", MainLauncher = true)]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
			GraphicalView graphView = getLineGraph ();
			this.AddContentView (graphView,new ViewGroup.LayoutParams(ViewGroup.LayoutParams.FillParent,ViewGroup.LayoutParams.FillParent));
        }

		private GraphicalView getLineGraph(){
			double[] value = {10,20,30,40,50};
			XYMultipleSeriesDataset dataset = new XYMultipleSeriesDataset();
           	//凡例の名前
            TimeSeries series = new TimeSeries ("Time Chart");
      		// データを追加
			for(int i = 0;i<5;i++){
                DateTime date = DateTime.Now;
                Date newDate = new Date(2013,4,date.Day-i);
                series.Add(newDate,value[i]);
 			}
			dataset.AddSeries (series);

			//set renderer
			XYMultipleSeriesRenderer renderer = new XYMultipleSeriesRenderer (1);
			XYSeriesRenderer r = new XYSeriesRenderer ();
			r.Color = Color.White;
			r.PointStyle = PointStyle.Circle;
			renderer.AddSeriesRenderer (r);
			renderer.LabelsTextSize = 30;
			renderer.PointSize = 15f;
			renderer.SetMargins(new int[]{20,30,15,20});
			renderer.ChartTitleTextSize = 30;
            renderer.ShowGridX = true;
            renderer.ShowGridY = true;
           	renderer.BackgroundColor = 0;
            renderer.XLabels = 6;
           	Date minDate = new Date(2013,4,1);
           	Date maxDate = new Date(2013,5,1);
            double[] rangeArray = {minDate.Time,maxDate.Time,0,100};
     		renderer.SetRange(rangeArray);
           	// グラフのx軸のデータフォーマット
            String dateFormat = "M/d";
           	// create graph
            GraphicalView graphView = ChartFactory.GetTimeChartView (this,dataset,renderer,dateFormat);
			return graphView;
		}
    }
}


