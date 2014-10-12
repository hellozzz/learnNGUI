using UnityEngine;
using System.Collections;

public class TestTextList : MonoBehaviour {

	private UITextList textlist; 
	private int lineNumber = 0;

	void Awake () {
		textlist = this.GetComponent<UITextList>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			textlist.Add("adsfjdsaofienknkjlkadsjfldsajfl" + lineNumber++);
		}
	}
}
