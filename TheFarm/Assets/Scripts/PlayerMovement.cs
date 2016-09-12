using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

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
        CheckInputs();

        horizMovement = Input.GetAxis("Horizontal");
        vertMovement = Input.GetAxis("Vertical") ;

        

        this.transform.Translate(new Vector3(horizMovement / 100, 0, 0));
        this.transform.Translate(new Vector3(0, vertMovement / 50, 0));


    }

    void CheckInputs()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("pressed space");
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100));
        }
    }

    void AnimateMovement(float horizontalValue, float verticalValue)
    {
        
    }
}
