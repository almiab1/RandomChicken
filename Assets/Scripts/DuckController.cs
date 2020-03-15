using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckController : MonoBehaviour
{
    private Rigidbody rb;
    public Transform referencePoint;
    public GameManager gameManager;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDrag()
    {
        rb.useGravity = false;
        transform.position = referencePoint.position;
        //transform.rotation = referencePoint.rotation;
    }
    private void OnMouseUpAsButton()
    {
        rb.useGravity = true;
        rb.AddForce(referencePoint.forward * 5000);
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameManager.numberOfBounces += 1;
        _audioSource.Play();
    }
}
