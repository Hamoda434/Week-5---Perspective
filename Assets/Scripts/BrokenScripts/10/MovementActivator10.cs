using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator10 : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject otherObjectToActivate; //Serialized the field, so it can accept an input.

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) // Changed onTriggerEnter (not a Unity function) to OnTriggerEnter
    {
        objectToActivate.GetComponent<MoveObject10>().enabled = true; //changed from 9 to 10
        otherObjectToActivate.GetComponent<MoveObject10>().enabled = true; //changed from 9 to 10
    }
    private void OnTriggerExit(Collider other) // Changed onTriggerEnter (not a Unity function) to OnTriggerEnter
    {
        objectToActivate.GetComponent<MoveObject10>().enabled = true; //changed from 9 to 10
        otherObjectToActivate.GetComponent<MoveObject10>().enabled = true; //changed from 9 to 10
    }
}
