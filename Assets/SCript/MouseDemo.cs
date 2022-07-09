using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDemo : MonoBehaviour
{

    float xRot;
    float yRot = 0;
    public float xBias = 5.0f; // 回転速度
    public float yBias = 5.0f; // 回転速度
    public float maxPitch = 60.0f; // 制限角度
    public float minPitch = -60.0f; // 制限角度

    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetKey(KeyCode.Home))
        {
        }
        else
        {
            //現在のカメラの左右向きにマウスの左右移動量を（バイアスを掛けて）加える
            xRot = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * xBias;
            //現在のカメラの仰角俯角にマウスの前後移動量を（バイアスを掛けて）加える
            yRot += Input.GetAxis("Mouse Y") * yBias;
            //仰角俯角のみ、範囲内に収める(Clamp)
            yRot = Mathf.Clamp(yRot, minPitch, maxPitch);
            //上記で求めたxRot,yRotをカメラの角度に与える
            transform.localEulerAngles = new Vector3(-yRot, xRot, 0);
        }
#endif
    }

}

