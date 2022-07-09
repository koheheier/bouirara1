using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PointSCript : MonoBehaviour
{
    //ここで、ポイント付きのボールを作る
    //ボール一つ一つにスクリプトをつけて、それが触れると消えて、Finalにポイントが送られるようにしたい

    //メカニズム
    //ボールに触れる
    //ボール消える
    //あるところにポイントが蓄積される
    //それが繰り返される
    //ゲームが終わる
    //蓄積されたポイントがFinalに送られる
    //ポイントが加算

    public AudioClip sound1;
    AudioSource audioSource;
    public static int POINT = 0;
    public Text Pnt;
    //GameObject[] Ball = GameObject.FindGameObjectsWithTag("Ball");
    // Start is called before the first frame update
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //for (int i = 0; i < j; i++)
        //{
        //    Sphere[i].gameObject.SetActive(false);
        //}

        if (SceneManager.GetActiveScene().name == "main")
        {
            POINT = 0;
        }
        
    }

    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            POINT++;
            Debug.Log("point");
            Debug.Log(POINT);
            Destroy(other.gameObject);
            audioSource.PlayOneShot(sound1);
        }

        
    }

    public static int getHitPoint()
    {
        return POINT;
    }

    // Update is called once per frame
    void Update()
    {
        Pnt.text = "Point : "+POINT;
    }
}
