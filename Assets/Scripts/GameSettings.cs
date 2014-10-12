using UnityEngine;
using System.Collections;

public enum GameGrade{
	NORMAL,
	EASY,
	DIFFICAULT
}

public enum ControlType{
	KEYBOARD,
	TOUCH,
	MOUSE
}
 	
public class GameSettings : MonoBehaviour {

	public float volume = 1;
	public GameGrade grade = GameGrade.NORMAL;
	public ControlType controlType = ControlType.KEYBOARD;
	public bool isFullScreen = false;

	public TweenPosition startPanelTween;
	public TweenPosition optionPanelTween;

	public void OnVolumeChanged() {
		volume = UIProgressBar.current.value;
	}
	public void OnGameGradeChanged(){
		switch(UIPopupList.current.value.Trim()){
		case "一般":
			grade = GameGrade.NORMAL;
			break;
		case "简单":
			grade = GameGrade.EASY;
			break;
		case "困难":
			grade = GameGrade.DIFFICAULT;
			break;
		}
	}
	public void OnControlTypeChange(){
		switch(UIPopupList.current.value.Trim()){
		case "键盘":
			controlType = ControlType.KEYBOARD;
			break;
		case "鼠标":
			controlType = ControlType.MOUSE;
			break;
		case "触摸":
			controlType = ControlType.TOUCH;
			break;
		}
	}
	public void OnisFullScreenChanged(){
		isFullScreen = UIToggle.current.value;
	}

	public void OnOptionButtonClick(){
		startPanelTween.PlayForward();
		optionPanelTween.PlayForward();
	}
	public void OnCompleteSettingButtonClick(){
		optionPanelTween.PlayReverse();
		startPanelTween.PlayReverse();
	}
}
