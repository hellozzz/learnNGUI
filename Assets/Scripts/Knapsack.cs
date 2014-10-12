using UnityEngine;
using System.Collections;

public class Knapsack : MonoBehaviour {

	public GameObject[] cells;
	public string[] equipmentSpriteName;
	public GameObject item;

	void Update(){
		// 当按下 P 键时，捡起物品
		if(Input.GetKeyDown(KeyCode.P)){
			Pickup();
		}
	}

	public void Pickup(){
		// 这里用随机模拟，实际项目中应该主角捡到什么就Pickup什么
		int index = Random.Range(0, equipmentSpriteName.Length);
		string name = equipmentSpriteName[index];
		bool isExisting = false;
		for(int i = 0; i< cells.Length; i++){
			// 当前格子有物品且名字符合
			if(cells[i].transform.childCount > 0) {
				// 获取已有物品（当前Cell的child）上的KnapsackItem脚本，以使用其中记录的数据的方法
				KnapsackItem knapsackItem = cells[i].GetComponentInChildren<KnapsackItem>();
				if(knapsackItem.sprite.spriteName == name) {
					isExisting = true;
					knapsackItem.AddCount();
					break;
				}
			}
		}
		if(!isExisting) {
			// 检测一个空格子来放置物品
			for(int i = 0; i < cells.Length; i++) {
				if(cells[i].transform.childCount == 0) {  // 判断当前位置没有物品
					GameObject newItem = NGUITools.AddChild(cells[i],item);	// 通过给当前格子添加child的方式添加物品
					newItem.GetComponent<UISprite>().spriteName = name;  // 设置该物品的sprite，实在随机效果。
					newItem.transform.localPosition = Vector3.zero;
					break;
				}
			}
		}
	}
}
