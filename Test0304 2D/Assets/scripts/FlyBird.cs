using UnityEngine;
using System.Collections;

public class FlyBird : MonoBehaviour {

    private float speed = 5.0f;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(19.9f, 3, 0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Time.deltaTime * Vector3.left * speed);
        if (transform.position.x < -22.3f)
            transform.position = new Vector3(19.9f, 3, 0);
    }
}
