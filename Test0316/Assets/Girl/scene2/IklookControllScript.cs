using UnityEngine;
using System.Collections;

public class IklookControllScript : MonoBehaviour {

    public Transform tf;
    private Animator am;
	// Use this for initialization
	void Start () {
        am = GetComponent<Animator>();
	}
    
    void OnAnimatorIK(int layerIndex)
    {
        am.SetLookAtWeight(1);
        am.SetLookAtPosition(tf.position);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
