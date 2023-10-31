using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishRace : MonoBehaviour
{      
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponentInParent<TimerController>().stopTimer();
        }
    }
}
