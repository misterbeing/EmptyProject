using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public bool Entered;
    public Transform parentobject;

    private void Start()
    {
        parentobject = this.transform.parent;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<PlayerMovement>())
        {
            Entered = true;
            parentobject.position = new Vector3(parentobject.position.x + 7,parentobject.position.y,parentobject.position.z);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>())
        {
            Entered = false;
        }
    }
}
