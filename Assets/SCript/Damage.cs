using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{

    //道中にスコアアイテムを設置して、スコアをfalseシーンに表示できるようにしよう。
    //早いゴールにも得点のメリットを与えたいので、残り時間をポイントとしよう。
    //問題は、別シーンにどうやって時間とポイントを送るかだ。
    //それができれば、後はコースづくりと背景選択（アセッツでさがそう）
    

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    //やることは、失敗したときのペナルティを、-50ポイントにしたい。

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall") { 
            Debug.Log("WallHit");
            SceneManager.LoadScene("False");
            
        }
    }
}
