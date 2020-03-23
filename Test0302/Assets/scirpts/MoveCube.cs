using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {

    private float dis;
    private float speed = 10.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        dis = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(new Vector3(dis, 0, 0) * Time.deltaTime * speed);
	}
}
