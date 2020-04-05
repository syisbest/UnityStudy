using UnityEngine;
using System.Collections;

public class AsteroidCreate : MonoBehaviour
{

    public GameObject asteroid;

    public int hazardCount = 10;

    public float waveTime = 2.0f;

    public float startTime = 1.0f;

    private GameControl gameControl;
    // Use this for initialization
    void Start ()
    {
        StartCoroutine(SpawnWaves());
        GameObject myGameControl = GameObject.Find("GameControl");
        gameControl = myGameControl.GetComponent<GameControl>();
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
             if(gameControl.gameover)
                 break;
             yield return new WaitForSeconds(waveTime);
        }
       
    }
}
