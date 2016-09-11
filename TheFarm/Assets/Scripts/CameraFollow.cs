using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    private GameObject theCamera;
    private GameObject camColLeft;
    private GameObject camColRight;

    // Use this for initialization
    void Start () {
        theCamera = GameObject.FindGameObjectWithTag("MainCamera");
        camColLeft = GameObject.FindGameObjectWithTag("camColLeft");
        camColRight = GameObject.FindGameObjectWithTag("camColRight");
        //a Change
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerStay2D (Collider2D theCol)
    {
        if (theCol.gameObject.tag == "Player")
        {
            if (this.tag == "camColLeft")
            {
                theCamera.transform.Translate(new Vector3(-0.035f, 0, 0));
            }
            if (this.tag == "camColRight")
            {
                theCamera.transform.Translate(new Vector3(0.035f, 0, 0));
            }
        }
    }
}
