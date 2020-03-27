using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectObject : MonoBehaviour
{
    public Transform referencePoint;
    public GameObject luz;
    private Transform player;
    public GameObject luzEmergendia;

    protected bool seguimiento;

    private void Update()
    {
        if(seguimiento == true)
        {
            var targetRotation = Quaternion.LookRotation(player.position - luz.transform.position);

            // Smoothly rotate towards the target point.
            luz.transform.rotation = Quaternion.Slerp(luz.transform.rotation, targetRotation, 3 * Time.deltaTime);

            //luz.transform.LookAt(player);
        }
        else
        {
            //luz.transform.LookAt(referencePoint);

            var targetRotation = Quaternion.LookRotation(referencePoint.position - luz.transform.position);

            // Smoothly rotate towards the target point.
            luz.transform.rotation = Quaternion.Slerp(luz.transform.rotation, targetRotation, 1 * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HA ENTRADO EN LA ZONA");
        if (other.gameObject.tag == "Player")
        {
            seguimiento = true;
            player = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            seguimiento = false;
        }
        Debug.Log("HA SALIDO DE LA ZONA");
    }
}