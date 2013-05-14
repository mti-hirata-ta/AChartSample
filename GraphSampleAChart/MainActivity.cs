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

namespace GraphSampleAChart
{
    [Activity (Label = "GraphSampleAChart", MainLauncher = true)]
    public class Activity1 : Activity
    {
//        int count = 1;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
//            Button button = FindViewById<Button>(Resource.Id.myButton);
//			
//            button.Click += delegate
//            {
//                button.Text = string.Format("{0} clicks!", count++);
//            };

			//set graph
			GraphicalView graphView = getLineGraph ();
			this.AddContentView (graphView,new ViewGroup.LayoutParams(ViewGroup.LayoutParams.FillParent,ViewGroup.LayoutParams.FillParent));
        }

		private GraphicalView getLineGraph(){
			//data
			double[] x = {1,2,3,4,5};
			double[] value = {10,20,30,40,50};

			XYMultipleSeriesDataset dataset = new XYMultipleSeriesDataset();
			//add data
			XYSeries series = new XYSeries ("test",0);
			for(int i = 0;i<5;i++){
				series.Add(x[i],value[i]);
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

			renderer.SetXAxisMin(0,0);
			renderer.SetXAxisMax(6,0);
			renderer.SetYAxisMin(0,0);
			renderer.SetYAxisMax(60,0);
			//create graph
			GraphicalView graphView = ChartFactory.GetLineChartView (this,dataset,renderer);
			return graphView;
		}
    }
}


