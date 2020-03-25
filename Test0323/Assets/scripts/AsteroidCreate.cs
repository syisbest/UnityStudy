using UnityEngine;
using System.Collections;

public class AsteroidCreate : MonoBehaviour
{

    public GameObject asteroid;

    public int hazardCount = 10;

    public float waveTime = 2.0f;

    public float startTime = 1.0f;
    // Use this for initialization
	void Start ()
    {
        StartCoroutine(SpawnWaves());
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startTime);
        Vector3 v;
        for (int i = 0; i < hazardCount; i++)
        {
             v = new Vector3(Random.Range(-6.0f, 6.0f), 0, 14.5f);
             Instantiate(asteroid, v, asteroid.transform.rotation);
             yield return new WaitForSeconds(waveTime);
        }
       
    }
}
