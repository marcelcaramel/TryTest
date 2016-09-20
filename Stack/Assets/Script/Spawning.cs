using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {

	public GameObject miniFood;
	public GameObject miniMoney;
	public GameObject miniTrees;
	public GameObject miniArt;
	public GameObject miniSex;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider theCol)
	{
		if (this.tag == "Food")
		{
			
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
