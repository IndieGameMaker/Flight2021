using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    private Transform targetTr;
    private Transform missileTr;

    public float speed = 1000.0f;
    public float damping = 10.0f;

    void Start()
    {
        targetTr = GameObject.FindGameObjectWithTag("FLIGHT").transform;
        missileTr = transform;
    }

    void LateUpdate()
    {
        //회전
        var rot = Quaternion.LookRotation(targetTr.position - missileTr.position);
        missileTr.rotation = Quaternion.Slerp(missileTr.rotation,
                                              rot,
                                              Time.deltaTime * damping);
        //이동
        missileTr.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
