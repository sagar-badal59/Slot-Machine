using UnityEngine;
using UnityEngine.UI;
using System.Collections; 

namespace BE {

	public class SceneSlotGame : MonoBehaviour {

		public	static SceneSlotGame instance;

		public 	SlotGame	Slot;			// slot game class
		public 	Button		btnSpin;		// start spin

		void Awake () {
			instance=this;
		}

		void Start () {

		}

		void Update () {
			if((Slot.gameResult.InFreeSpin()) && Slot.Spinable()) {
				//Debug.Log ("Update Spin");
				OnButtonSpin();
			}
		}

		// user clicked spin button
		public void OnButtonSpin() {

			// start spin
			SlotReturnCode code = Slot.Spin();
			// if spin succeed
			if(SlotReturnCode.Success == code) {
				// disabled inputs
				ButtonEnable(true);
			}
		}

		// enable or disable button inputs
		public void ButtonEnable(bool bEnable) {
			btnSpin.interactable = bEnable;
		}

		//------------------------------------------
		//callback functions

	}

}
