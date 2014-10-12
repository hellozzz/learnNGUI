using UnityEngine;
using System.Collections;

public class AgeLimit : MonoBehaviour {

	private UIInput input;

	// Use this for initialization
	void Awake () {
		input = this.GetComponent<UIInput>();
	}
	
	public void OnAgeValueChanged() {
		int valueInt = int.Parse(input.value);
		input.value = Mathf.Clamp(valueInt, 18, 120).ToString();
	}
}
