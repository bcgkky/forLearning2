using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boyat : MonoBehaviour
{
    public Color clr;
   void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("agent"))
        {
            other.gameObject.GetComponent<MeshRenderer>().material.color = clr;
        }

        /*GameObject obj = GameObject.FindGameObjectWithTag("agent");
        obj.GetComponent<MeshRenderer>().material.color = Color.green;*/

    }
}
