
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

namespace MyInfoStash
{
	[Activity (Label = "Subcategory???", Icon = "@drawable/house")]		
	public class SubCatActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			//SetContentView (Resource.Layout.SubCat);

			string mainCat = Intent.GetStringExtra ("mainCat") ?? "Subcategory";
			this.Title = mainCat;

			var layout = new LinearLayout(this)
			{
				Orientation = Orientation.Vertical,
				LayoutParameters =
					new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent)
			};
				
			for (int i = 0; i < 10; i++) {
				Button btn = new Button (this);
				btn.Text = i.ToString ();
				btn.SetWidth(50);
				layout.AddView (btn);
			}
			SetContentView (layout);
		}
	}
}

