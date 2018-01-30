using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
	private Vector3 startPos;
	private Quaternion startRot;
	// Use this for initialization
	void Start () 
	{
		startPos = transform.position;
		startRot = transform.rotation;
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "Death")
		{
			transform.position = startPos;
			transform.rotation = startRot;
			Debug.Log("Animator",GetComponent<Animator>());
			GetComponent<Animator>().Play("LOSE00", 0, 0f);
			GetComponent<Rigidbody>().velocity = new Vector3(0f,0f,0f);
			GetComponent<Rigidbody>().angularVelocity = new Vector3(0f,0f,0f);
		} else if (col.tag == "checkpoint")
		{
			startPos = col.transform.position;
			startRot = col.transform.rotation;
		}
	}
}
