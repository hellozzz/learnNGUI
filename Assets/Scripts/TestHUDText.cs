using UnityEngine;
using System.Collections;

public class TestHUDText : MonoBehaviour {

	public HUDText text;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {	
			text.Add(-10, Color.red,1f);  // 减少10，持续1秒消失
		}
		if(Input.GetMouseButtonDown(1)) {
			text.Add(+10, Color.green, 1f);
		}
	}
}
