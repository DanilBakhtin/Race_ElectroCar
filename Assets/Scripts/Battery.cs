using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    [SerializeField] float energyCount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")){
            other.gameObject.GetComponentInParent<BatteryController>().addEnergy(energyCount);
            Destroy(this.gameObject);
        }
    }
}
