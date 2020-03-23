using UnityEngine;
using System.Collections;

public class Cube2Sphere : MonoBehaviour {

    private Vector3 cubep;
    private Vector3 spherep;
    private float dis;
    private float speed = 1.2f;
    private float start;
	// Use this for initialization
	void Start () {
        start = Time.time;
        cubep = gameObject.transform.position;
        spherep = GameObject.Find("Sphere").transform.position;
        dis = Vector3.Distance(cubep, spherep);

	}
	
	// Update is called once per frame
	void Update () {
        float s;
        s = speed * (Time.time - start);
        float f;
        f = s / dis;
        gameObject.transform.position = Vector3.Lerp(cubep, spherep, f);
	}
}
