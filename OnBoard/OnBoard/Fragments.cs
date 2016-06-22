
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace OnBoard
{
	/// <summary>
	/// First fragment.
	/// Fragments displayed by ViewPager must use the support-library Fragment class as their base.
	/// </summary>
	public class FirstFragment : Android.Support.V4.App.Fragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			return inflater.Inflate(Resource.Layout.FirstFragment, container, false);

			//return base.OnCreateView (inflater, container, savedInstanceState);
		}
	}

	public class SecondFragment : Android.Support.V4.App.Fragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			return inflater.Inflate(Resource.Layout.SecondFragment, container, false);

			//return base.OnCreateView (inflater, container, savedInstanceState);
		}
	}

	public class ThirdFragment : Android.Support.V4.App.Fragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			 return inflater.Inflate(Resource.Layout.ThirdFragment, container, false);

			//return base.OnCreateView (inflater, container, savedInstanceState);
		}
	}
}

