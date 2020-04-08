using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    private CharacterController cc;

    private Vector3 move;

    public float speed;

    public float jumpSpeed;

    public float gravity;

    public float pushPower;
    // Use this for initialization
	void Start () {
	    move=Vector3.zero;
        cc = GetComponent<CharacterController>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (cc.isGrounded)
        {
            move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //move = transform.TransformDirection(move);//转换成局部坐标
            move *= speed;
            if (Input.GetButton("Jump"))
                move.y = jumpSpeed;
        }

        move.y -= gravity * Time.deltaTime;
        cc.Move(move * Time.deltaTime);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;
        if(rigidbody==null||rigidbody.isKinematic)
            return;
        if(hit.moveDirection.y<-0.3f)
            return;
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        rigidbody.velocity = pushDir * pushPower;
    }

    //void OnCollisionEnter(Collision col)
    //{
    //    print(col.gameObject.name);
    //}
}
