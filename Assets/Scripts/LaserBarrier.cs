using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBarrier : Trap
{
    [SerializeField] private GameObject laserMesh;
    [SerializeField] private BoxCollider laserCollider;
    public override void activate()
    {
        isActivate = true;
        laserMesh.SetActive(false);
        laserCollider.enabled = false;
    }

    protected override void interactionPlayer(Collision collision)
    {

    }

}
