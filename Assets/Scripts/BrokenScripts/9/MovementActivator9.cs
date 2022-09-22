using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator9 : MonoBehaviour
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
        objectToActivate.GetComponent<MoveObject9>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject9>().enabled = true;
    }
    private void OnTriggerExit(Collider other) // Changed onTriggerExit (not a Unity function) to OnTriggerExit
    {
        objectToActivate.GetComponent<MoveObject9>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject9>().enabled = true;
    }
}