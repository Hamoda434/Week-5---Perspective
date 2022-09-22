using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator8 : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject otherObjectToActivate;

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
        objectToActivate.GetComponent<MoveObject8>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject8>().enabled = true;
    }
    private void OnTriggerExit(Collider other) //Changed onTriggerExit (not a Unity function) to OnTriggerExit
    {
        objectToActivate.GetComponent<MoveObject8>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject8>().enabled = true;
    }
}