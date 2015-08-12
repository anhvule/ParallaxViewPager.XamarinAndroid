package md557a4fec6e85d2e82855f68ec5fd47222;


public class ViewPagerAdapter
	extends android.support.v13.app.FragmentStatePagerAdapter
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_getItem:(I)Landroid/app/Fragment;:GetGetItem_IHandler\n" +
			"";
		mono.android.Runtime.register ("ParallaxViewPager.ViewPagerAdapter, ParallaxViewPager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ViewPagerAdapter.class, __md_methods);
	}


	public ViewPagerAdapter (android.app.FragmentManager p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == ViewPagerAdapter.class)
			mono.android.TypeManager.Activate ("ParallaxViewPager.ViewPagerAdapter, ParallaxViewPager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.FragmentManager, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public android.app.Fragment getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native android.app.Fragment n_getItem (int p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
