using UnityEngine;
using System.Collections;

public class CrowdMovement : MonoBehaviour
{
    private Animator animator;
    public float SpeedDampTime = 1.0f;
    public float DirectionDampTime = 1.0f;
    private Vector3 TargetPosition;
    public float AvatarRange = 20.0f;
	// Use this for initialization
	void Start ()
    {
        animator = gameObject.GetComponent<Animator>();
        TargetPosition = new Vector3(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (animator)
        {
            int rand = Random.Range(0, 50);
            animator.SetBool("Jump", rand == 20);
            animator.SetBool("Dive", rand == 30);

            if (Vector3.Distance(animator.rootPosition, TargetPosition) > 5)
            {
                animator.SetFloat("Speed",1,SpeedDampTime,Time.deltaTime);
                Vector3 currentDir = animator.rootRotation * Vector3.zero;
                Vector3 wantedDir = (TargetPosition - animator.rootPosition).normalized;
                if (Vector3.Dot(currentDir, wantedDir) > 0)
                {
                    animator.SetFloat("Dirction",Vector3.Cross(currentDir,wantedDir).y,DirectionDampTime,Time.deltaTime);
                }
                else
                {
                    animator.SetFloat("Dirction", Vector3.Cross(currentDir, wantedDir).y > 0 ? 1 : -1,
                        DirectionDampTime, Time.deltaTime);
                }
            }
            else
            {
                animator.SetFloat("Speed", 0, SpeedDampTime, Time.deltaTime);
                if (animator.GetFloat("Speed") < 0.01f)
                {
                    TargetPosition = new Vector3(Random.Range(-AvatarRange, AvatarRange), 0,
                        Random.Range(-AvatarRange, AvatarRange));
                }
            }
        }
    }
}
