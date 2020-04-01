using UnityEngine;
using System.Collections;

public class followObj : MonoBehaviour {

    private Animator am;
    public Transform CapsuleTransform;

    public Transform SphereTransform;
	// Use this for initialization
	void Start () {
        am = GetComponent<Animator>();
	}
	
    void OnAnimatorIK(int layerIndex)
    {
        AvatarIKGoal goal1 = AvatarIKGoal.LeftHand;
        am.SetIKPositionWeight(goal1, 1f);
        am.SetIKPosition(goal1, CapsuleTransform.position);
        am.SetIKRotationWeight(goal1, 1f);
        am.SetIKRotation(goal1, CapsuleTransform.rotation);

        AvatarIKGoal goal2 = AvatarIKGoal.RightFoot;
        am.SetIKPositionWeight(goal2, 1f);
        am.SetIKPosition(goal2, SphereTransform.position);
        am.SetIKRotationWeight(goal2, 1f);
        am.SetIKRotation(goal2, CapsuleTransform.rotation);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
