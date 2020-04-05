using UnityEngine;
using System.Collections;

public class DestroyByCollision : MonoBehaviour
{

    public GameObject explosion;
    public GameObject playExplosion;
    private GameObject newExplosion;
    private GameObject newPlayExplosion;

    public int scoreValue;

    private GameControl gameControl;

	// Use this for initialization
	void Start ()
    {
        GameObject myGameControl=GameObject.Find("GameControl");
        gameControl = myGameControl.GetComponent<GameControl>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "shots")
        {
            Destroy(col.gameObject);
            newExplosion =
                (GameObject) Instantiate(explosion, gameObject.transform.position, explosion.transform.rotation);
            Destroy(newExplosion, 1.0f);
            Destroy(gameObject);
            gameControl.UpdateScore(scoreValue);
        }
        else if (col.gameObject.name.Equals("vehicle_playerShip"))
        {
            Destroy(col.gameObject);
            newPlayExplosion =
                (GameObject)Instantiate(playExplosion, gameObject.transform.position, playExplosion.transform.rotation);
            Destroy(newPlayExplosion, 1.0f);
            Destroy(gameObject);
            gameControl.GameOver();
            gameControl.GameReStart();
        }
    }
}
