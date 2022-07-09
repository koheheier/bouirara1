using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // uGUIを利用するのに必要 

public class RollScript : MonoBehaviour
{

    float Elapsed;
    GameObject Beem;
    public Image imgBar;
    public float FillTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Beem = GameObject.Find("Beem");
        Elapsed = 0.0f;
        imgBar.fillAmount = 0.0f;
    }


    void OnTriggerExit(Collider other) {
        if (other.gameObject.name == "Beem") {
            Elapsed = 0.0f;
            imgBar.fillAmount = 0.0f;
        }
    }

    void OnTriggerStay(Collider other) {
        if (other.gameObject.name == "Beem") {
            if (Input.GetButton("Fire1")) {
                Elapsed += Time.deltaTime;
                imgBar.fillAmount = Elapsed / FillTime;
                if (Elapsed > FillTime) {
                    Elapsed = 0.0f;
                    imgBar.fillAmount = 0.0f;
                    Debug.Log("Selected!");
                }
            } else {
                Elapsed = 0.0f;
                imgBar.fillAmount = 0.0f;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
