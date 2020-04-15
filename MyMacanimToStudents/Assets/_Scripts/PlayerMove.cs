using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    private Animator animator;

    private float h;

    private float v;
    // Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.IsName("Base Layer.Run"))
        {
            if(Input.GetButton("Fire1"))
                animator.SetBool("Jump",true);
            else
            {
                animator.SetBool("Jump",false);
            }
        }
        if(Input.GetButtonDown("Fire2"))
            animator.SetBool("Hi",!animator.GetBool("Hi"));
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        animator.SetFloat("Speed", v * v + h * h);
        animator.SetFloat("Dirction",h,0.25f,Time.deltaTime);
    }
}
