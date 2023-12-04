using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class strControl1 : MonoBehaviour
{
    private Text TextBox;
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
