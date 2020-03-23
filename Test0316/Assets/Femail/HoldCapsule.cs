using UnityEngine;
using System.Collections;

public class HoldCapsule : MonoBehaviour {

    private Animator am;
    public Transform tf;
	// Use this for initialization
	void Start () {
        am = GetComponent<Animator>();
	}
	
    void OnAnimatorIK(int layerIndex)
    {
        AvatarIKGoal goal = AvatarIKGoal.LeftHand;
        am.SetIKPositionWeight(goal, 1f);
        am.SetIKPosition(goal, tf.position);
        am.SetIKRotationWeight(goal, 1f);
        am.SetIKRotation(goal, tf.rotation);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
