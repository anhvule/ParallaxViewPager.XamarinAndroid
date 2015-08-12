package md557a4fec6e85d2e82855f68ec5fd47222;


public class ParallaxPageTransformer
	extends md557a4fec6e85d2e82855f68ec5fd47222.BaseJavaObject
	implements
		mono.android.IGCUserPeer,
		android.support.v4.view.ViewPager.PageTransformer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_transformPage:(Landroid/view/View;F)V:GetTransformPage_Landroid_view_View_FHandler:Android.Support.V4.View.ViewPager/IPageTransformerInvoker, Xamarin.Android.Support.v4\n" +
			"";
		mono.android.Runtime.register ("ParallaxViewPager.ParallaxPageTransformer, ParallaxViewPager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ParallaxPageTransformer.class, __md_methods);
	}


	public ParallaxPageTransformer () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ParallaxPageTransformer.class)
			mono.android.TypeManager.Activate ("ParallaxViewPager.ParallaxPageTransformer, ParallaxViewPager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void transformPage (android.view.View p0, float p1)
	{
		n_transformPage (p0, p1);
	}

	private native void n_transformPage (android.view.View p0, float p1);

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
