using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Collections.Generic;
using MIS.Shared.Core;
using Android.Graphics.Drawables;
using Android.Views;

namespace MyInfoStash
{
	[Activity (Label = "MyInfoStash", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			//SetContentView (Resource.Layout.Main);

			var context = new MasterMainCategoryRepository ();			

			var layout = new LinearLayout(this)
			{
				Orientation = Orientation.Vertical,
				LayoutParameters =
					new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent)
			};
					
			List<MasterMainCategory> mmcs = context.GetMasterMainCategories ();

			foreach (var mmc in mmcs) {
				ImageButton ib = new ImageButton (this);

				int resID = Resources.GetIdentifier(mmc.imgsrc.ToLower(), "drawable", PackageName);
				ib.SetImageResource(resID);

				ib.Click += delegate {
					var act = new Intent (this, typeof(SubCatActivity));
					act.PutExtra ("mainCat", mmc.name);
					StartActivity (act);
				};

				layout.AddView(ib);
			}

			SetContentView (layout);


//			ImageButton btnHouse = FindViewById<ImageButton>(Resource.Id.btnHouse);
//			ImageButton btnPeople = FindViewById<ImageButton>(Resource.Id.btnPeople);
//			ImageButton btnMisc = FindViewById<ImageButton>(Resource.Id.btnMisc);
//			btnHouse.Click += delegate {
//				var act = new Intent (this, typeof(SubCatActivity));
//				act.PutExtra ("mainCat", "House");
//				StartActivity (act);
//			};
//			btnPeople.Click += delegate {
//				var act = new Intent (this, typeof(SubCatActivity));
//				act.PutExtra ("mainCat", "People");
//				StartActivity (act);
//			};
//			btnMisc.Click += delegate {
//				var act = new Intent (this, typeof(SubCatActivity));
//				act.PutExtra ("mainCat", "Miscellaneous");
//				StartActivity (act);
//			};

		}
	}
}


