using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoCtrl : MonoBehaviour
{
    private Transform fighterTr;
    private Transform ufoTr;

    void Start()
    {
        fighterTr = GameObject.FindGameObjectWithTag("FLIGHT").GetComponent<Transform>();
        ufoTr = GetComponent<Transform>();        
    }

    void LateUpdate()
    {
        //벡터 계산 (비행기의좌표 - UFO좌표)
        Vector3 fighterVec = new Vector3(fighterTr.position.x,
                                         ufoTr.position.y,
                                         fighterTr.position.z);

        ufoTr.LookAt(fighterVec);

        /*
        Vector3 fighterVec = fighterTr.position;
        fighterVec.y = ufoTr.position.y;
        */

        // Vector3 dir = fighterVec - ufoTr.position;
        // //벡터의 각도를 계산(쿼터니언 Quaternion)
        // Quaternion rot = Quaternion.LookRotation(dir);

        // ufoTr.rotation = Quaternion.Slerp(ufoTr.rotation,
        //                                   rot,
        //                                   Time.deltaTime * 5.0f);
    }
}
