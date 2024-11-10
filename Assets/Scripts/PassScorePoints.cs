using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassScorePoints : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    
    {
        GameManager.singleton.AddScore(1);
    }
}
