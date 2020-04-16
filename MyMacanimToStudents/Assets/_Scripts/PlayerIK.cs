using UnityEngine;
using System.Collections;

public class PlayerIK : MonoBehaviour
{
    public Transform LeftHandObj = null;
    public Transform RightHandObj = null;
    public Transform LeftFootObj = null;
    public Transform RightFootObj = null;
    public Transform BodyObj = null;
    public Transform LookAtObj = null;
    private Animator animator;
    public bool isActive=true;
	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
    }

    void OnGUI()
    {
        isActive = GUILayout.Toggle(isActive, "isActive");
    }
    void OnAnimatorIK(int layerIndex)
    {
        if (animator)
        {
            if (isActive)
            {
                animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot,1);
                animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot,1);

                animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, 1);
                animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, 1);

                animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
                animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);

                animator.SetIKPositionWeight(AvatarIKGoal.RightHand,1);
                animator.SetIKRotationWeight(AvatarIKGoal.RightHand,1);

                animator.SetLookAtWeight(1,0.3f,0.6f,1.0f,0.5f);

                if (BodyObj != null)
                {
                    animator.bodyPosition = BodyObj.position;
                    animator.bodyRotation = BodyObj.rotation;
                }

                if (LookAtObj != null)
                {
                    animator.SetLookAtPosition(LookAtObj.position);
                }
                if (LeftFootObj != null)
                {
                    animator.SetIKPosition(AvatarIKGoal.LeftFoot, LeftFootObj.position);
                    animator.SetIKRotation(AvatarIKGoal.LeftFoot, LeftFootObj.rotation);
                }
                if (RightFootObj != null)
                {
                    animator.SetIKPosition(AvatarIKGoal.RightFoot, RightFootObj.position);
                    animator.SetIKRotation(AvatarIKGoal.RightFoot, RightFootObj.rotation);
                }
                if (LeftHandObj != null)
                {
                    animator.SetIKPosition(AvatarIKGoal.LeftHand, LeftHandObj.position);
                    animator.SetIKRotation(AvatarIKGoal.LeftHand, LeftHandObj.rotation);
                }
                if (RightHandObj != null)
                {
                    animator.SetIKPosition(AvatarIKGoal.RightHand, RightHandObj.position);
                    animator.SetIKRotation(AvatarIKGoal.RightHand, RightHandObj.rotation);
                }
            }
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
