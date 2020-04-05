using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class AudioControl : MonoBehaviour
{

    public AudioSource audioSource;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ButtonPlayClickFun()
    {
        audioSource.Play();
    }

    public void ButtonPauseClickFun()
    {
        audioSource.Pause();
    }
}
