using UnityEngine;
using System.Collections;

public class AddForceMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Rigidbody rb;
        rb = gameObject.GetComponent<Rigidbody>();
        rb.MovePosition(new Vector3(0, 0, 0));
        rb.MoveRotation(Quaternion.Euler(0, 30, 0));
        rb.AddForce(0, 10, 0);
        rb.AddRelativeForce(100, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
