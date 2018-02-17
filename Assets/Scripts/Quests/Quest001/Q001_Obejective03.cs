using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q001_Obejective03 : MonoBehaviour {

	public float TheDistance;
	public GameObject FakeSword;
	public GameObject RealSword;
	public GameObject ActionCharacter;
	public GameObject ActionText;
	public GameObject TheObjective;
	public GameObject ChestBlock;
	public int CloseObjective;

	void Update() {
		TheDistance = PlayerCasting.DistanceFromTarget;
		if (CloseObjective == 3) {
			if (TheObjective.transform.localScale.y <= 0f) {
				CloseObjective = 0;
				TheObjective.SetActive (false);
			} else {
				TheObjective.transform.localScale -= new Vector3 (0f, 0.1f, 0f);
			}
		}
	}

	void OnMouseOver() {
		if (TheDistance <= 3f) {
			ActionText.GetComponent<Text>().text = "Take Sword";
			ActionText.SetActive (true);
			ActionCharacter.SetActive (true);
		}
		if (Input.GetButtonDown ("Action")) {
			if (TheDistance <= 3f) {
				this.GetComponent<BoxCollider>().enabled = false;
				FakeSword.SetActive (false);
				RealSword.SetActive (true);
				ChestBlock.SetActive (true);
				CloseObjective = 3;
				ActionText.SetActive (false);
				ActionCharacter.SetActive (false);
			}
		}
	}

	void OnMouseExit() {
		ActionText.SetActive (false);
		ActionCharacter.SetActive (false);
	}


}
