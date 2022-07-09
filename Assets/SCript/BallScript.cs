using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    //TimeScriptから、ここのプログラムを起動
    //このオブジェクトにぶつかると消滅、スコア１がポイントに加算

    //球体は3個数あるとする
    //public GameObject[] Sphere = new int[2];
    
    //この配列数は変更できないので、都度スクリプトを変更するしかない?
    
        
        
        //このスクリプトは、BallScriptと書いてあるが、その実、ステージ変更スクリプトである。
    public GameObject[] Sphere = new GameObject[2];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2 ; i++) {
            Sphere[i].gameObject.SetActive(false);
        }
    }

    public void Active()
    {
        for (int i = 0; i < 2; i++)
        {
            Sphere[i].gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
