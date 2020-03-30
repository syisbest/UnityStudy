using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour
{

    Animator am;
    // Use this for initialization
    void Start()
    {
        am = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            am.SetBool("toScale", true);
            am.SetBool("toPosition", false);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            am.SetBool("toScale", false);
            am.SetBool("toPosition", true);
        }
    }
}
