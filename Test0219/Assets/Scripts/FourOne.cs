using UnityEngine;
using System.Collections;

public class FourOne : MonoBehaviour {
    private double n;
	// Use this for initialization
	void Start () {
        n = 10;
        for(int i = 0; i < 30; i++)
        {
            n *= 2;
        }
        Debug.Log(n);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
