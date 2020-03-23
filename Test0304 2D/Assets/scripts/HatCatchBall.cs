using UnityEngine;
using System.Collections;

public class HatCatchBall : MonoBehaviour {

    public GameObject effect;
    private GameObject neweffect;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        neweffect = (GameObject)Instantiate(effect, transform.position, effect.transform.rotation);
        neweffect.transform.parent = transform;
        Destroy(neweffect,3);
    }
}
