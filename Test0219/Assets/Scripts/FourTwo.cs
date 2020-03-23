using UnityEngine;
using System.Collections;

public class FourTwo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] a = new int[10];
        for (int i = 0; i < a.Length; i++)
            a[i] = i + 1;
        foreach (int j in a)
            print(j);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
