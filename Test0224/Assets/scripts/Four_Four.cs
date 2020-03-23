using UnityEngine;
using System.Collections;

public class Four_Four : MonoBehaviour {

    private int[][] a = new int[3][];
	// Use this for initialization
	void Start () {
        a[0] = new int[3];
        a[1] = new int[4];
        a[2] = new int[5];
        int n = 1;
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < a[i].Length; j++)
                a[i][j] = n++;
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < a[i].Length; j++)
                print(a[i][j]);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
