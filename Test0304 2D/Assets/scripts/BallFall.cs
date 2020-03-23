using UnityEngine;
using System.Collections;

public class BallFall : MonoBehaviour {

    private float xmax;
    private float xmin;
    private float time;
    public GameObject ball;
    private GameObject newBall;
	// Use this for initialization
	void Start () {
        time = 0;
        Vector3 screenPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0));
        float hatHalf = GetComponent<Renderer>().bounds.extents.x;
        xmax = screenPos.x - hatHalf;
        xmin = -xmax;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if(time>2)
        {
            Vector3 ballPos = new Vector3(Random.Range(xmin, xmax), ball.transform.position.y, 0);
            newBall = (GameObject)Instantiate(ball, ballPos, Quaternion.identity);
            time = 0;
            Destroy(newBall, 5);
        }
	}
}
