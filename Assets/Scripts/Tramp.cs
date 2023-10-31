using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramp : Trap
{
    [SerializeField] private float angleUP = 20f;
    private bool isUp = false;
    [SerializeField] private float speedUp = 10f;
    private float startRotX;

    private void Start()
    {
        startRotX = transform.rotation.eulerAngles.x - 360;
    }
    public override void activate()
    {
        isActivate = true;
        
    }

    protected override void interactionPlayer(Collision collision)
    {

    }

    private void FixedUpdate()
    {
        if (isActivate && !isUp)
        {
            Vector3 rotate = transform.eulerAngles;
            rotate.x = transform.rotation.eulerAngles.x - 360 + speedUp * Time.deltaTime;
            transform.rotation = Quaternion.Euler(rotate);
           
        }

        if (Mathf.Abs(transform.rotation.eulerAngles.x - 360) <= Mathf.Abs(startRotX + angleUP))
        {
            isUp = true;
        }
    }
}
