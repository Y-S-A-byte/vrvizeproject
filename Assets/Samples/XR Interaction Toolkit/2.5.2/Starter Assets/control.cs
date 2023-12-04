using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit; 
public class control : MonoBehaviour
{
    public Transform Spawn;
    public Vector3 GetSpawn() => Spawn.position;
    
    private void OnTriggerExit(Collider other)
    {
        if (!other.gameObject.tag.Equals(gameObject.tag))
        {
            gameObject.transform.position = GetSpawn();
        }
    }
}
