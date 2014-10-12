using UnityEngine;
using System.Collections;

public class MyDragDropItem : UIDragDropItem {

	protected override void OnDragDropRelease (GameObject surface)
	{
		base.OnDragDropRelease (surface);
		print(surface);
	}
}
