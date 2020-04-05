using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MixAudioControl : MonoBehaviour
{
    public AudioMixer AudioMixer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MasterChange(Slider slider)
    {
        AudioMixer.SetFloat("MasterParam", slider.value);
    }

    public void Music1Change(Slider slider)
    {
        AudioMixer.SetFloat("Music2Param", slider.value);
    }

    public void Music2Change(Slider slider)
    {
        AudioMixer.SetFloat("Music3Param", slider.value);
    }
}
