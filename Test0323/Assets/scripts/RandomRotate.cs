using UnityEngine;
using System.Collections;

public class RandomRotate : MonoBehaviour
{

    public float angle = 10.0f;

    private Rigidbody rb;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * angle;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
