using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
    public Transform follow;
    public float distanceUp;
    public float distanceAway;

    private Vector3 CameraPosition;
	// Use this for initialization
	void Start () {
    	
	}
	
	// Update is called once per frame
	void Update ()
    {
        CameraPosition = follow.position + Vector3.up * distanceUp - follow.forward * distanceAway;
        transform.position=Vector3.Lerp(transform.position,CameraPosition,Time.deltaTime);
        transform.LookAt(follow);
    }
}
