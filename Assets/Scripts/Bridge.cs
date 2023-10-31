using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    [SerializeField] private float timeFallDown;
    [SerializeField] private float killY;
    [SerializeField] private float speedFall;
    private bool isFalling;
    //private Rigidbody rb;

    private void Start()
    {
        //rb = GetComponent<Rigidbody>();
        isFalling = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(FallDownCoroutine());
        }
    }

    IEnumerator FallDownCoroutine()
    {
        yield return new WaitForSeconds(timeFallDown);
        isFalling = true;
    }

    private void FixedUpdate()
    {
        if (transform.position.y <= killY)
        {
            Destroy(gameObject);
        }
        if (isFalling)
            transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.up * -1f, speedFall * Time.deltaTime);
    }
}
