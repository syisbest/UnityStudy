using UnityEngine;
using System.Collections;

public class Four_Six : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 10; i++)
            print("main" + i);
        StartCoroutine(TestOne(1));
        StartCoroutine(TestTwo(2));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator TestOne(int i)
    {
        for(int j=0;j<10;j++)
        {
            print("fast" + j);
            yield return new WaitForSeconds(i);
        }
    }
    IEnumerator TestTwo(int i)
    {
        for(int j=0;j<10;j++)
        {
            print("slow" + j);
            yield return new WaitForSeconds(i);
        }
    }
}
