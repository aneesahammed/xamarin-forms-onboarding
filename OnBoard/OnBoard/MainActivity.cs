using System;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;

namespace OnBoard
{
	/// <summary>
	/// Activities that host a ViewPager use the support-library FragmentActivity class as their base
	/// </summary>
	[Activity (Theme = "@style/Theme.NoTitle",Label = "OnBoard", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Android.Support.V4.App.FragmentActivity,Android.Support.V4.View.ViewPager.IOnPageChangeListener
	{
		private static  int NUM_PAGES = 3;
		private ImageView [] _carouselIndicator = new ImageView [NUM_PAGES];
		private int _currentPosition;


		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);


			var fragments = new Android.Support.V4.App.Fragment []{
				new FirstFragment(),
				new SecondFragment(),
				new ThirdFragment(),
			};

			var viewPager = FindViewById<Android.Support.V4.View.ViewPager> (Resource.Id.myPager);

			//inherit a SupportFramentManager property that gives support version of FragmentManager which ViewPager needs
			//Instantiate an adapter and load into ViewPager
			viewPager.Adapter = new SlideAdapter (base.SupportFragmentManager, fragments);

			//listen for page change
			viewPager.AddOnPageChangeListener (this);
			int selectedPos = viewPager.CurrentItem;


			LinearLayout carouselLayout = (LinearLayout)FindViewById<LinearLayout>(Resource.Id.carousel_indicator_layout);

			for (int i = 0; i < carouselLayout.ChildCount; i++) {
				var imgView = (ImageView)carouselLayout.GetChildAt (i);
				if(selectedPos==i){
					imgView.Selected = true;
					_currentPosition = i;
				}
				_carouselIndicator [i] = imgView;
			}

		}

		void ViewPager.IOnPageChangeListener.OnPageScrolled (int position, float positionOffset, int positionOffsetPixels)
		{
			
		}

		void ViewPager.IOnPageChangeListener.OnPageScrollStateChanged (int state)
		{
			
		}

		void ViewPager.IOnPageChangeListener.OnPageSelected (int position)
		{
			UpdateCarouselIndicator (position);
		}

		void UpdateCarouselIndicator (int position)
		{
			_carouselIndicator [_currentPosition].Selected = false;
			_currentPosition = position;
			_carouselIndicator [position].Selected = true;
		}
}










	/// <summary>
	/// Slide adapter.
	/// Adapter provides your pages to the ViewPager
	/// You can either derive from FragmentPagerAdapter or FragmentStatePagerAdapter
	/// FragmentStatePagerAdapter conserves memory by destroying Fragments that are not visible to the user.
	/// </summary>
	class SlideAdapter : FragmentStatePagerAdapter
	{
		Android.Support.V4.App.Fragment [] _fragments;

		//must pas a support FragmentManager to your adapter's base
		public SlideAdapter (Android.Support.V4.App.FragmentManager fm,
							Android.Support.V4.App.Fragment [] fragments) : base (fm)
		{
			this._fragments = fragments;
		}

		//No of Fragments
		public override int Count {
			get {
				return _fragments.Length;
			}
		}

		//Fragment at the given position
		public override Android.Support.V4.App.Fragment GetItem (int position)
		{
			return _fragments [position];
		}
	}




}


