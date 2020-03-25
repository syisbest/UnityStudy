using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.forward * speed;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
