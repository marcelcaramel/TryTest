using UnityEngine;
using System.Collections;

public class KittenScript : MonoBehaviour {

    public GameObject theKitten;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnCollisionEnter2D(Collision2D theColl)
    {
        Instantiate(theKitten, new Vector3(0,4,0), Quaternion.identity);
        GameObject.FindGameObjectWithTag("Kittensomg").gameObject.GetComponent<MeshRenderer>().enabled = true;
        Debug.Log("kitten!");
    }
}
