using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterCtrl : MonoBehaviour
{
    private Transform tr;

    public float speed = 30.0f;

    void Start()
    {
        tr = GetComponent<Transform>();        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        tr.Rotate(Vector3.right * Time.deltaTime * v * 100.0f);
        tr.Rotate(Vector3.up * Time.deltaTime * h * 100.0f);
        tr.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
