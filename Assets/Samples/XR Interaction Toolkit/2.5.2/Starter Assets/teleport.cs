using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;

public class piramit_teleport : MonoBehaviour
{
    public Transform Spawn;
    public Vector3 GetSpawn() => Spawn.position;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            teleport();
        }
        else if(other.gameObject.tag.Equals(gameObject.tag))
        {
            gameObject.GetComponent<XRGrabInteractable>()
        }
    }
        public void teleport()
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.transform.position = GetSpawn();
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }

}
