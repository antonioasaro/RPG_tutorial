using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour {

	public int RotateSpeed;
	public AudioSource CollectSound;
	public GameObject ThisHeart;


//	// Use this for initialization
//	void Start () {
//		
//	}
	
	// Update is called once per frame
	void Update () {
		RotateSpeed = 2;
		transform.Rotate (0, RotateSpeed, 0, Space.World);
	}

	void OnTriggerEnter ()
	{
		CollectSound.Play ();
		HealthMonitor.HealthValue += 1;
		ThisHeart.SetActive (false);
	}
}
