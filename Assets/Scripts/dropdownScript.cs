using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dropdownScript : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;

    public void GetOption(int value)
    {
        Debug.Log(dropdown.options[value].text);
    }

    
}
