﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace BE {
	
	public class SceneLobby : MonoBehaviour {

		public	GameObject 		prefabSceneItem; // selectstage item prefab
		public 	RectTransform	rtScrollContent; // scrollview that contain stageselect items
		public	Text			textGold;		// user gold info

		void Awake () {
			
		}
		
		void Start () {
			Time.timeScale = 1;

		}
		
		// Update is called once per frame
		void Update () {
		
			// if user press 'escape' key, show quit message window
			if (Input.GetKeyDown(KeyCode.Escape)) { 
				UISGMessage.Show("Quit", "Do you want to quit this program ?", MsgType.OkCancel, MessageQuitResult);
			}
			
		}

		// when user pressed 'ok' button on quit message.
		public void MessageQuitResult(int value) {
			//Debug.Log ("MessageQuitResult value:"+value.ToString ());
			if(value == 0) {
				Application.Quit ();
			}
		}
		
		//public void OnButtonUser() {
		//	BEAudioManager.SoundPlay(0);
		//}
		
		//public void OnButtonShop() {
		//	BEAudioManager.SoundPlay(0);
		//	UISGShop.Show();
		//}
		
		//public void OnButtonOption() {
		//	BEAudioManager.SoundPlay(0);
		//	UISGOption.Show();
		//}
		
		//public void OnButtonPlay() {
		//	BEAudioManager.SoundPlay(0);
		//}
		
		//public void OnButtonGet() {
		//	BEAudioManager.SoundPlay(0);
		//}

		public void OnButtonSelected(int value) {
			//BEAudioManager.SoundPlay(0);
			Application.LoadLevel("SlotGame");
		}
	}
}