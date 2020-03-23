using UnityEngine;
using System.Collections;

public class UpSphere : MonoBehaviour {

    private Rigidbody rb;
    public GameObject gb;
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.y < gb.transform.position.y - 1)
            Destroy(gameObject);
	}

    void OnCollisionEnter(Collision col)
    {
        rb.AddForce(new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(1.0f, 4.0f), 0)*150.0f);
    }
}
