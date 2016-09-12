using UnityEngine;
using System.Collections;

public class Farm_PlayerMovement : MonoBehaviour {

    float horizMovement;
    float vertMovement;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    void Movement()
    {

        horizMovement = Input.GetAxis("Horizontal");
        vertMovement = Input.GetAxis("Vertical");

        this.transform.Translate(new Vector3(horizMovement / 100, 0, 0));
        this.transform.Translate(new Vector3(0, vertMovement / 100, 0));


    }
}
