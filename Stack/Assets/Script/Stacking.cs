using UnityEngine;
using System.Collections;

public class Stacking : MonoBehaviour {

	float foodQuantity;
	float moneyQuantity;
	float treesQuantity;
	float artQuantity;
	float sexQuantity;

	float foodQuantityMultiplier;
	float moneyQuantityMultiplier;
	float treesQuantityMultiplier;
	float artQuantityMultiplier;
	float sexQuantityMultiplier;

	int updateCount;

	// Use this for initialization
	void Start () {
		foodQuantityMultiplier = 0.1f;
		moneyQuantityMultiplier = 0.1f;
		treesQuantityMultiplier = 0.1f;
		artQuantityMultiplier = 0.1f;
		sexQuantityMultiplier = 0.1f;

	}
	
	// Update is called once per frame
	void Update () {
		
		updateCount++;
	}

	void Stack()
	{
		if (this.tag == "Food" && (updateCount % 6 == 2))
		{
			foodQuantity += foodQuantityMultiplier;
			Debug.Log(foodQuantity + " Food");
			//Debug.Log((updateCount % 6) + " MODULO"); 
		}
		if (this.tag == "Money" && (updateCount % 8 == 3))
		{
			moneyQuantity += moneyQuantityMultiplier;
			Debug.Log(moneyQuantity + " Money");
			//Debug.Log((updateCount % 8) + " MODULO");
		}
		if (this.tag == "Trees" && (updateCount % 10 == 4))
		{
			treesQuantity += treesQuantityMultiplier;
			Debug.Log(treesQuantity + " Trees");
		}
		if (this.tag == "Art" && (updateCount % 12 == 5))
		{
			artQuantity += artQuantityMultiplier;
			Debug.Log(artQuantity.ToString() + " Art");
		}
		if (this.tag == "Sex" && (updateCount % 14 == 6))
		{
			sexQuantity += sexQuantityMultiplier;
			Debug.Log(sexQuantity.ToString() + " Sex");
		}
	}
}