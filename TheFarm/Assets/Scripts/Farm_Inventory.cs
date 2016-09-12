using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Farm_Inventory : MonoBehaviour {

    public GameObject[] theInventory;

	// Use this for initialization
	void Start () {
        theInventory = new GameObject[10];
	}
	
	// Update is called once per frame
	void Update () {
	}

    void GetInputs()
    {
        
    }

    void OnTriggerStay2D (Collider2D theCollision)
    {
        Debug.Log("gotcollison");
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Gotkeydown");
            for (int i = 0; i < theInventory.Length; i++)
            {
                if (theInventory[i] != null)
                {
                    theInventory[i] = theCollision.gameObject;
                    Debug.Log(theInventory[i].gameObject.name);
                }           
            }
            
        }
    }
}
