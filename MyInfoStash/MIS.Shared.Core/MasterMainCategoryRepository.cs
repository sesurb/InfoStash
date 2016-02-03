using System;
using System.Collections.Generic;

namespace MIS.Shared.Core
{
	public class MasterMainCategoryRepository
	{
		public MasterMainCategoryRepository ()
		{
		}

		public List<MasterMainCategory> GetMasterMainCategories ()
		{
			List<MasterMainCategory> mmcs = new List<MasterMainCategory>();

			MasterMainCategory mmc = new MasterMainCategory ();
			mmc.id = 1;
			mmc.name = "House";
			mmc.active = true;
			mmc.imgsrc = "house";
			mmcs.Add (mmc);

			mmc = new MasterMainCategory ();
			mmc.id = 2;
			mmc.name = "People";
			mmc.active = true;
			mmc.imgsrc = "family";
			mmcs.Add (mmc);

			mmc = new MasterMainCategory ();
			mmc.id = 3;
			mmc.name = "Miscellaneous";
			mmc.active = true;
			mmc.imgsrc = "Misc";
			mmcs.Add (mmc);

			return mmcs;
		}
	}
}

