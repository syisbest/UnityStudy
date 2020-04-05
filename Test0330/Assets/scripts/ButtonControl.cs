using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{

    public GameObject Text;

    private Text text;
	// Use this for initialization
	void Start ()
    {
        text = Text.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ButtonClickFun()
    {
        text.text = "Button is clicked";
    }

    public void ToggleClickFunRed(Toggle toggle)
    {
        if (toggle.isOn)
            text.color = Color.red;
        else
            text.color = Color.black;
    }

}
