using UnityEngine;
using System.Collections;

// 实现拖拽释放效果
public class KnapsackItem : UIDragDropItem {

	protected override void OnDragDropRelease (GameObject surface)
	{
		base.OnDragDropRelease (surface);

		// 如果格子里面已经有物体了，实现交换效果，否则直接放进格子
		if(surface.tag == "Cell"){
			// 把游戏物体移到格子上面，并居中显示(实现“自动归位”效果)
			this.transform.parent = surface.transform;
			this.transform.localPosition = Vector3.zero;
		}else{ 
			// 交换物品
			Transform parent = surface.transform.parent;
			surface.transform.parent = this.transform.parent;
			surface.transform.localPosition = Vector3.zero;
			this.transform.parent = parent;
			this.transform.localPosition = Vector3.zero;
		}

		// 可以通过该属性计算有没有子物体
//		print(surface.transform.childCount);
	}
}