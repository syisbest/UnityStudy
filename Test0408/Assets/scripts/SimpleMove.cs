using UnityEngine;
using System.Collections;

public class SimpleMove : MonoBehaviour
{
    private CharacterController cc;
    private Vector3 moveDir;
    public int speed;
    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
        moveDir=Vector3.zero;
    }
	
	// Update is called once per frame
	void Update ()
    {
        moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        cc.SimpleMove(moveDir * speed);
    }
}
