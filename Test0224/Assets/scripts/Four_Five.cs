using UnityEngine;
using System.Collections;

public class Four_Five : MonoBehaviour {

    private int[] num;
	// Use this for initialization
	void Start () {
        int max;
        int address;
        int[] num ={ 1,3,4,6,2};
        maxnum(num, out max, out address);
        Debug.Log("max="+max);
        print("address="+address);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void maxnum(int[] num,out int max,out int address)
    {
        max = num[0];
        address = 1;
        for(int i=0;i<5;i++)
        {
            if(num[i]>max)
            {
                max = num[i];
                address = i + 1;
            }
        }
    }
}
