using UnityEngine;
using System.Collections;

public class PlayerGenerator : MonoBehaviour
{
    public GameObject Teddy;

    public GameObject Dude;

    public int maxPlayerCount = 10;

    private int nowCount = 0;

    private float lastTime;

    public float timeSpan=1.0f;
	// Use this for initialization
	void Start ()
    {
        lastTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        if (nowCount <= maxPlayerCount && (Time.time - lastTime) >= timeSpan)
        {
            nowCount++;
            lastTime = Time.time;
            if (Input.GetButton("Fire1"))
                Instantiate(Dude, Vector3.zero, Quaternion.identity);
            else
                Instantiate(Teddy, Vector3.zero, Quaternion.identity);

        }
	}
}
