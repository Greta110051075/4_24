using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 goal = new Vector3(3, 0, 5);
    public float speed = 0.01f;

    void Start()
    {
        //往某一個點移動
        //this.transform.Translate(goal);    

        goal = goal * 0.001f;
    }

    private void LateUpdate()
    {
        this.transform.Translate(goal.normalized * speed * Time.deltaTime);
        //持續移動某方向不斷移動，並且進行正規畫動作，然後每秒只執行一次
    }
    
    void Update()
    {
        //持續往某個方向移動
        //this.transform.Translate(goal.normalized * speed * Time.deltaTime);//並且取得正規化
    }
}
