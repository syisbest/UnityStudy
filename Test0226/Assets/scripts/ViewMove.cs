using UnityEngine;
using System.Collections;

public class ViewMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKey("w"))
        //    gameObject.transform.Translate(0, 0, Time.deltaTime * 2);
        //if (Input.GetKey("a"))
        //    gameObject.transform.Translate(-Time.deltaTime * 2, 0, 0);
        //if (Input.GetKey("s"))
        //    gameObject.transform.Translate(0, 0, -Time.deltaTime * 2);
        //if (Input.GetKey("d"))
        //    gameObject.transform.Translate(Time.deltaTime * 2, 0, 0);
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        gameObject.transform.Translate(x * 0.1f, 0, z * 0.1f);
    }
}
