using UnityEngine;
using System.Collections;

public class Trying_Super_Hard_Right_Na : MonoBehaviour {

    float horizMovement;
    float vertMovement;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Inputs();
	}

    void Inputs()
    {
        horizMovement = Input.GetAxis("Horizontal");
        vertMovement = Input.GetAxis("Vertical");

        this.transform.Translate(new Vector3(horizMovement/3,0,0));
        this.transform.Translate(new Vector3(0,vertMovement/3,0));
    }

}
