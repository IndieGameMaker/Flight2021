using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMissile : MonoBehaviour
{
    public GameObject missile;

    IEnumerator Fire()
    {
        yield return new WaitForSeconds(Random.Range(0.0f, 3.0f));
        
        Instantiate(missile,
                    transform.position,
                    Quaternion.LookRotation(transform.forward));
        Debug.Log("Fire !!!");
    }

}
