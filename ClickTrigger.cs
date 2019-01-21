using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickTrigger : MonoBehaviour {

	private Image panel;
	private Text text;
	private Spawner spawner;
	private Button button;

	//Triggers when the user presses a word

	public void OnPress(){
		spawner.OnSelectAnimation (panel);
		//button.enabled = false;

		StartCoroutine (Waiter ());
	}

	IEnumerator Waiter() {
		yield return new WaitForSeconds(0.2f);
		spawner.SendWord (text, panel);
	}	

	/*void Awake(){
		Messenger.AddListener (GameEvent.NOT_MATCHED, EnableButton);
	}*/

	void Start () {
		panel = (Image) GetComponent(typeof(Image));
		button = (Button) GetComponent(typeof(Button));
		spawner = GameObject.FindObjectOfType <Spawner>();
		text = (Text) GetComponentInChildren (typeof(Text));
	}

	void OnDestroy(){
		//Messenger.RemoveListener (GameEvent.NOT_MATCHED, EnableButton);
	}
		
	/*private void EnableButton(){
		button.enabled = true;
	}*/

}
