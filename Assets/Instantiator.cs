using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int cloneAmaunt;
    public Text txtCloneAmaunt;
    GameObject clon;

    public void MultiInstantiate()
    {
        cloneAmaunt = int.Parse(txtCloneAmaunt.text);
        for (int i = 0; i <= cloneAmaunt; i++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon,1);
        }
    }
}