using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    float Elapsed;
    GameObject Beem;
    public Image imgBar;
    public Image imgButton;
    public float FillTime = 2.0f;
    public GameObject Stage1;
    GameObject Stage2;
    //このスクリプト参照は、ステージ変更のためのスクリプトをつけるためのものである。現時点では未完成。
    //BallScript script;

    // Start is called before the first frame update
    void Start()
    {
        //script = this.GetComponent<BallScript>();
        Beem = GameObject.Find("Beem");
        Elapsed = 0.0f;
        imgBar.fillAmount = 0.0f;
        imgButton.fillAmount = 0.0f;
        Stage1 = GameObject.Find("Stage1");
        Stage2 = GameObject.Find("Stage2");
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Beem")
        {
            Elapsed = 0.0f;
            imgButton.fillAmount = 0.0f;
            imgBar.fillAmount = 0.0f;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Beem")
        {
            imgButton.fillAmount = 1.0f;
            if (Input.GetButton("Fire1"))
            {
                Elapsed += Time.deltaTime;
                imgBar.fillAmount = Elapsed / FillTime;
                if (Elapsed > FillTime)
                {

                    Elapsed = 0.0f;
                    imgBar.fillAmount = 0.0f;
                    Debug.Log(gameObject.name);
                    //Stage1.gameObject.transform.Translate(0, 0, 5.0f);
                    if (this.gameObject.name == "Stage1")
                    {
                        SceneManager.LoadScene("main");
                        Debug.Log("ステージ1だぜ");
                    }
                    if (this.gameObject.name == "Stage2")
                    {
                        //SceneManager.LoadScene("main2");
                        Debug.Log("ステージ2だと！？");
                    }

                    
                    //script.Active();
                    //ゲームオブジェクトの名前（Stage?）によって、シーンを変更することで、別ステージに切り替えられるようになる
                    //現時点では未完成。
                    

                }
            }
            else
            {
                Elapsed = 0.0f;
                imgBar.fillAmount = 0.0f;
            }
        
    }

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("Start");
        
    //}

}
