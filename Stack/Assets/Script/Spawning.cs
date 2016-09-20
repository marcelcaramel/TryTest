using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider theCol)
	{
		Debug.Log ("crissostie44");
		if (this.tag == "Food")
		{
			Debug.Log ("crissostie");
		}
		if (this.tag == "Money")
		{

		}
		if (this.tag == "Trees")
		{

		}
		if (this.tag == "Art")
		{

		}
		if (this.tag == "Sex")
		{

		}
	}
}
