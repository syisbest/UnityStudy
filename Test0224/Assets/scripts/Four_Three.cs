using UnityEngine;
using System.Collections;

public class Four_Three : MonoBehaviour {

    private int[,] a = new int[3,3];

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                a[i, j] = i * 3 + j + 1;
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                print(a[i, j]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
