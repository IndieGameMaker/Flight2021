using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMissile : MonoBehaviour
{
    public GameObject missile;

    IEnumerator Fire()
    {
        yield return new WaitForSeconds(Random.Range(0.0f, 3.0f));

        GameObject obj =  Instantiate(missile,
                                      transform.position,
                                      Quaternion.LookRotation(transform.forward));

        Destroy(obj, 10.0f);            
        Debug.Log("Fire !!!");
    }

}
