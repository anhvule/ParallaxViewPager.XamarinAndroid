package md557a4fec6e85d2e82855f68ec5fd47222;


public class BaseJavaObject
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ParallaxViewPager.BaseJavaObject, ParallaxViewPager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaseJavaObject.class, __md_methods);
	}


	public BaseJavaObject () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BaseJavaObject.class)
			mono.android.TypeManager.Activate ("ParallaxViewPager.BaseJavaObject, ParallaxViewPager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
