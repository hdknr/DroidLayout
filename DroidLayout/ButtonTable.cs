
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DroidLayout
{
	[Activity (Label = "ButtonTable")]			
	public class ButtonTable : Activity
	{
		int rows = 3;
		int cols = 4;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your application here

			var container = new LinearLayout (this) {
				Background=Android.Graphics.Color.Yellow.ToDrawable(),
			};

			SetContentView (container);

			var table = new TableLayout (this) {
				Background=Android.Graphics.Color.Red.ToDrawable(),
				StretchAllColumns=true,		// カラムを均等割にする
				WeightSum=rows,				// 行を均等割にしたいので行数を指定									
			};

			container.AddView (table,
				new LinearLayout.LayoutParams (
					LinearLayout.LayoutParams.MatchParent,	// 幅は親に合わせる
					LinearLayout.LayoutParams.MatchParent)	// 高さは親に合わせる
			);

			for (int i = 0; i < rows; i++) {
				
				var rowlayouts = new TableLayout.LayoutParams (
					TableLayout.LayoutParams.WrapContent,
					TableLayout.LayoutParams.WrapContent)
				{ Weight = 1,	// テーブルの中で均等割するので全ての重みを1にする
					Height=0	// 高さを自動指定
				};

				var row = new TableRow (this);
				table.AddView (row, rowlayouts);

				for (int j = 0; j < cols; j++) {

					var buttonlayout = new TableRow.LayoutParams (
						TableRow.LayoutParams.WrapContent,
						TableRow.LayoutParams.MatchParent	// 高さは行に合わせる
					) {
						Width = 0,			// 幅を自動設定
						RightMargin = 4, 	// 隙間を開ける
						TopMargin = 4		// 隙間を開ける
					};

					var button = new Button (this) {
						Text=$"{i}-{j}",
						Background=Android.Graphics.Color.Blue.ToButtonPressEffect()
					};
					row.AddView (button, buttonlayout);
				}						
			}
		}
	}
}

