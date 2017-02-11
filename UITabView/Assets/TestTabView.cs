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
			TabView.Scroll(100);
	}

	public void OnDownClick()
	{
		if (TabView != null)
			TabView.Scroll(-100);
	}

	public void OnTabViewData (int index, UIWidget item, int subIndex)
	{
		UISprite sp = item.cachedTransform.FindChild("Item").GetComponent<UISprite>();
		sp.spriteName = "eggs_01";
		sp.enabled = true;
		UILabel lb = item.cachedTransform.FindChild("Item/Lb").GetComponent<UILabel>();
		lb.text = index.ToString();
	}
}