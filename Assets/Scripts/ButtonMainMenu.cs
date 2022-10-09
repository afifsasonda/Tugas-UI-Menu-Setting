using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMainMenu : MonoBehaviour
{
    [SerializeField] Button button;
    private void Start() {
        button.onClick.AddListener(
            delegate(){
                ButtonValue();
            }
        );
    }
    public void ButtonValue()
    {
        Debug.Log("Button Start ON");
    }
}
