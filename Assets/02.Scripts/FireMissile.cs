using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMissile : MonoBehaviour
{
    public GameObject missile;

    void Fire()
    {
        Instantiate(missile,
                    transform.position,
                    Quaternion.LookRotation(transform.forward));
        Debug.Log("Fire !!!");
    }

}
