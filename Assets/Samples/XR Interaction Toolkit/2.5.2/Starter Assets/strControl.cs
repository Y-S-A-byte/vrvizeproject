using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class strControl : MonoBehaviour
{
    public Text TextBox;
    public XRSocketInteractor Interactor;
    float timer = 0f;

    private void OnTriggerExit(Collider other)
    {
        timer = 0f;
        if (other.gameObject.tag == gameObject.tag)
        {
            if (!TextBox.text.Equals("Correct!!"))
            {
                TextBox.color = Color.green;
                TextBox.text = "";
                TextBox.text += "Correct!!";
            }
            Interactor.socketActive = false;
        }
        else
        {
            if (!TextBox.text.Equals("Wrong Shape!!"))
            {
                TextBox.color = Color.red;
                TextBox.text = "";
                TextBox.text += "Wrong Shape!!";
            }
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 6.5)
        {
            TextBox.text = "";
        }
    }




}
