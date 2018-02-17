using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q001_Objective01 : MonoBehaviour {


	public GameObject TheObjective;
	public int CloseObjective;

	// Update is called once per frame
	void Update () {
		if (CloseObjective == 1) {
			if (TheObjective.transform.localScale.y <= 0f) {
				CloseObjective = 0;
				TheObjective.SetActive (false);
			} else {
				TheObjective.transform.localScale -= new Vector3 (0f, 0.1f, 0f);
			}
		}
	}

	void OnTriggerEnter() {
		StartCoroutine (FinishObjective ());
	}

	IEnumerator FinishObjective() {
		TheObjective.SetActive (true);
		yield return new WaitForSeconds (3f);
		CloseObjective = 1;
	}

}
