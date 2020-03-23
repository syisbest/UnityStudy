using UnityEngine;
using System.Collections;

public class HatMove : MonoBehaviour {

    private float xmax;
    private float xmin;
    private Vector3 mousePosition;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(-1.5f, -8.4f, 0);
        Vector3 screenPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0));
        float halfHat = GetComponent<Renderer>().bounds.extents.x;
        xmax = screenPos.x - halfHat;
        xmin = -xmax;
	}
	
	// Update is called once per frame
	void Update () {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.x = Mathf.Clamp(mousePosition.x, xmin, xmax);
        transform.position = new Vector3(mousePosition.x, transform.position.y);
	}
}
