using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnergyRoad : MonoBehaviour
{
    [SerializeField] private float energyGive;
    [SerializeField] private float timeEnergyGive;
    private bool isCharge;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(GiveEnergyCoroutine(other));
            isCharge = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isCharge = false;
        }
    }


    IEnumerator GiveEnergyCoroutine(Collider player)
    {
        yield return new WaitForSeconds(timeEnergyGive);

        if (isCharge)
        {
            player.GetComponentInParent<BatteryController>().addEnergy(energyGive);
            StartCoroutine(GiveEnergyCoroutine(player));
        }
    }

}
