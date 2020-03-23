using UnityEngine;
using System.Collections;
using System.Xml.Schema;
using UnityEditor;

[System.Serializable]
public class Boundary
{
    public float xMax, xMin, zMax, zMin;
}


public class PlayControl : MonoBehaviour
{

    public float speed = 10.0f;
    public float angle = -40.0f;
    public Boundary boundary;
    private Rigidbody rb;

    public GameObject boltPosition;
    public GameObject bolt;

    public float shotDeltatime = 1.0f;
    private float shotTime;
	// Use this for initialization
	void Start ()
    {
        shotTime = 0;
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        shotTime += Time.deltaTime;
        if (Input.GetKeyDown("f")&&shotTime>shotDeltatime)
        {
            Instantiate(bolt, boltPosition.transform.position, rb.rotation);
            shotTime = 0;
        }
	}

    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(moveH, 0, moveV) * speed;
        float positionX = Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax);
        float positionZ = Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax);
        rb.position=new Vector3(positionX,0,positionZ);
        Quaternion rotation = Quaternion.Euler(new Vector3(0, 0, moveH*angle));
        rb.rotation = rotation;
    }
}
