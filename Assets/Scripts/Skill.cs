using UnityEngine;
using System.Collections;

public class Skill : MonoBehaviour {

	public float coldTime = 2;  // 2秒钟转一圈
	private UISprite sprite;
	private bool isColding = false;

	void Awake() {
		sprite = transform.Find("Sprite").GetComponent<UISprite>();
	}

	void Update() {
		if(Input.GetKeyDown(KeyCode.A) && !isColding) {
			sprite.fillAmount = 1;
			isColding = true;
		}
		if(isColding) {
			sprite.fillAmount -= (1f/coldTime) * Time.deltaTime;  // 实现每coldTime转一圈
			if(sprite.fillAmount <= 0.05f) {
				isColding = false;
				sprite.fillAmount = 0;
			}
		}
	}
}
