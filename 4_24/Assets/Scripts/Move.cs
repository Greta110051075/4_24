using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 goal = new Vector3(3, 0, 5);
    public float speed = 0.01f;

    void Start()
    {
        //���Y�@���I����
        //this.transform.Translate(goal);    

        goal = goal * 0.001f;
    }

    private void LateUpdate()
    {
        this.transform.Translate(goal.normalized * speed * Time.deltaTime);
        //���򲾰ʬY��V���_���ʡA�åB�i�楿�W�e�ʧ@�A�M��C��u����@��
    }
    
    void Update()
    {
        //���򩹬Y�Ӥ�V����
        //this.transform.Translate(goal.normalized * speed * Time.deltaTime);//�åB���o���W��
    }
}
