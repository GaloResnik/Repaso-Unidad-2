using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateDeactivate : MonoBehaviour
{
    public GameObject inputField;

    public void ActivateandDeactivate()
    {
        //if (inputField.activeInHierarchy)
        //{
        //    inputField.SetActive(false);
        //}
        //else
        //{
        //    inputField.SetActive(true);
        //}
        inputField.SetActive(!inputField.activeInHierarchy);
        
    }
}
