﻿using UnityEngine;
using System.Collections;

public class TestTabView : MonoBehaviour, ITableViewData {

	public UITableView TabView = null;

	void Awake()
	{
		if (TabView != null)
			TabView.Data = this;	
	}

	public void OnUpClick()
	{
		if (TabView != null)
			TabView.ScrollIndex(0);
			//TabView.Scroll(100);
	}

	public void OnDownClick()
	{
		if (TabView != null)
			TabView.ScrollIndex(100);
			//TabView.Scroll(-100);
	}

	public void OnTabViewData (int index, UIWidget item, int subIndex)
	{
		int idx = index * 4 + subIndex;
		if (subIndex == 0)
		{
			UISprite sp = item.cachedTransform.FindChild("Item").GetComponent<UISprite>();
			sp.spriteName = string.Format("dish_0{0:D}", subIndex + 1);
			sp.enabled = true;
			UILabel lb = item.cachedTransform.FindChild("Item/Lb").GetComponent<UILabel>();
			lb.text = idx.ToString();
			lb.enabled = true;
		} else
		{
			string name = string.Format("Item ({0:D})", subIndex);
			UISprite sp = item.cachedTransform.FindChild(name).GetComponent<UISprite>();
			sp.spriteName = string.Format("dish_0{0:D}", subIndex + 1);
			sp.enabled = true;
			UILabel lb = item.cachedTransform.FindChild(string.Format("{0}/Lb", name)).GetComponent<UILabel>();
			lb.text = idx.ToString();
			lb.enabled = true;
		}
	}
}
