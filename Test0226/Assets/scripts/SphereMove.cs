using UnityEngine;
using System.Collections;

public class SphereMove : MonoBehaviour {

    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 9.0f, 0);
    }
}
