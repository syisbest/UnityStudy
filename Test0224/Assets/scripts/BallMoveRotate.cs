using UnityEngine;
using System.Collections;

public class BallMoveRotate : MonoBehaviour
{

    //private GameObject gb;
    private Vector3 v;
    // Use this for initialization
    void Start()
    {
        //float x = transform.position.x;
        //print(x);
        //x = gameObject.transform.position.x;
        //print(x);
        //x = GetComponent<Transform>().position.x;
        //print(x);
        //gb = GameObject.Find("Plane");
        //print(gb.transform.position.x);


        
    }

    // Update is called once per frame
    void Update()
    {
        v = gameObject.transform.InverseTransformDirection(Vector3.right);
        gameObject.transform.Translate(v * Time.deltaTime);
        gameObject.transform.Rotate(0, 0, 1.0f);
        print(Time.deltaTime);
    }
}
