using UnityEngine;
using System.Collections;

public class PrefabsInit : MonoBehaviour
{
    public GameObject sphere1;
    public GameObject sphere2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(sphere1, new Vector3(2, 2, 2), Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(sphere2, new Vector3(1, 1, 1), Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(sphere2, new Vector3(-1, 1, 3), Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(sphere1, new Vector3(-2, 1, -4), Quaternion.identity);
        }
    }
}
