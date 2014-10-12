using UnityEngine;
using System.Collections;

public class MyChatInput : MonoBehaviour {

	public UITextList testlist;
	private UIInput input;
	private string[] names = new string[]{
		"zzz",
		"offical",
		"张张张",
		"小明"
	};

	public void OnChatSubmit(){
		string chatMessage = input.value;
		string name = names[Random.Range(0,4)];
		testlist.Add(name + " : " + chatMessage);
		input.value = "";
	}
	void Awake(){
		input = this.GetComponent<UIInput>();
	}
}
