using UnityEngine;
using System.Collections;

public class Four_Seven : MonoBehaviour {

    private float x = 0.0f;
    private float y = 0.0f;
    private float xSpeed = 10.0f;
    private float ySpeed = 10.0f;//旋转速度
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            x += Input.GetAxis("Mouse X") * xSpeed;
            y += Input.GetAxis("Mouse Y") * ySpeed;//x和y轴旋转度数
            ModifyAngle(ref x);
            ModifyAngle(ref y);
            gameObject.transform.rotation = Quaternion.Euler(y, -x, 0);
        }
    }
    void ModifyAngle(ref float angle)//将旋转度数控制在0-360度
    {
        if (angle >= 360)
            angle -= 360;
        else if (angle < 0)
            angle += 360;
    }
}
