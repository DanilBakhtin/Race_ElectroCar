using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Trap : MonoBehaviour
{
    public float costEnergy;
    protected bool isActivate;
    void Start()
    {
        isActivate = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !isActivate)
        {
            other.gameObject.GetComponentInParent<BatteryController>().setTrap(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !isActivate)
        {
            other.gameObject.GetComponentInParent<BatteryController>().setTrap(null);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            interactionPlayer(collision);
        }
    }

    public abstract void activate();

    protected abstract void interactionPlayer(Collision collision);

  
}
