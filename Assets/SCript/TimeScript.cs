using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{

    //やりたいこと
    //黄色にステイを３秒間、黄色が消えて、タイマーが作動
    //時間
    static float Timer = 100.0f;
    bool Game = false;
    double Baka = 0;
    public GameObject TimeCount ;
    //フィル効果
    float Elapsed;
    public Image imgBar;
    public Image imgButton;
    public float FillTime = 2.0f;
    GameObject Starter;
    GameObject Wall;
    GameObject Goal;
    GameObject Beem;
    GameObject Ball;
    float Itempoint = PointSCript.getHitPoint();
    //GameObject[] Ball = GameObject.FindGameObjectsWithTag("Ball");
    //やりたいこと「ここのTimerを、ゲームの終了（クリア）時、別の静的変数に代入、その変数をFinalに送り、スコアに加算」
    //Damageで失敗画面

    // Start is called before the first frame update
    void Start()
    {


        if (Timer < 100)
        {
            Timer = 100;
        }

        Beem = GameObject.Find("Beem");
        Goal = GameObject.Find("Goal");
        Wall = GameObject.Find("Wall");
        Ball = GameObject.Find("Ball");
        Starter = GameObject.Find("Start");
        
        Ball.SetActive(false);
        Wall.SetActive(false);
        Goal.SetActive(false);
        

        Elapsed = 0.0f;
        imgButton.fillAmount = 0.0f;
        imgBar.fillAmount = 0.0f;
        



    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Beem")
        {
            Elapsed = 0.0f;
            imgBar.fillAmount = 0.0f;
            imgButton.fillAmount = 0.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        


        if (Game)
        {
        
        Timer -= Time.deltaTime;
        Text Timetxt = TimeCount.GetComponent<Text>();
        Timetxt.text = "Time : " + Timer.ToString("f2");
        

        }

        

        //print("Ahoですか？");

        //謎なのは、始まっても時間が100から変わってくれないということ。


    }



    public static float getTimePoint()
    {
        return Timer ;
    }



    //Startに入ってるとき
    void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.name == "Beem")
        {
            imgButton.fillAmount = 1.0f;

            if (Input.GetButton("Fire1"))
            {//print("aaaa");

                Elapsed += Time.deltaTime;
                imgBar.fillAmount = Elapsed / FillTime;

                if (Elapsed > FillTime)
                {
                    print("Gameは" + Game);
                    Game = true;
                    print("Gameは"+ Game);
                    Elapsed = 0.0f;
                    imgBar.fillAmount = 0.0f;
                    imgButton.fillAmount = 0.0f;
                    //startをどこかへ。falseにするとスクリプトが動かず、タイマーが作動しない。
                    Starter.gameObject.transform.Translate(0, 100000.0f, 0);
                    
                    print(Game);

                    Wall.SetActive(true);
                    Goal.SetActive(true);
                    Ball.SetActive(true);
                    
                    
                }
            }
            else
            {
                Elapsed = 0.0f;
                imgBar.fillAmount = 0.0f;
            }
        }
        
         

    }

}