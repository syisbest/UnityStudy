using UnityEngine;
using System.Collections;

public class RigidMove : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left * 50);
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionEnter(Collision col)
    {
        print(col.gameObject.name);
    }
}
