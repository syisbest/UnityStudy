using UnityEngine;
using System.Collections;

public class DestroySphere : MonoBehaviour {

    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(10, 0, 0);
	}

    void OnCollisionEnter(Collision col)
    {
        if(!col.gameObject.name.Equals("Plane"))
        {
            Destroy(col.gameObject);
        }
    }
}
