using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Final : MonoBehaviour
{
    public PointSCript PointSCript ;
    public Text Pointtxt;
    float pointer = PointSCript.getHitPoint();//
    

    
    // Start is called before the first frame update
    void Start()
    {
         float TimePoint = TimeScript.getTimePoint();//TimeScriptのTimerを代入している
         float Point = pointer + TimePoint;

        if (SceneManager.GetActiveScene().name == "False")
        {
            Point -= 50;
        }

        Pointtxt.text = "君のスコアは 「" + (int)Point + "」 だよ！";
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")) {
            SceneManager.LoadScene("StartSean");
        }

        
    }
}
