using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordScript : MonoBehaviour
{
    // Start is called before the first frame update

    RangedToggle rangedToggle;
    KnifeToggle knifeToggle;
    public Text buttonText;
    int Counter;
    private string Orginal;
    // Start is called before the first frame update
    public void SetText(string text)
    {
        if (Counter == 0) {
            Counter = 1;
            buttonText.text = text;
            rangedToggle.Increase();
            knifeToggle.Increase();
        }
        else {
            buttonText.text = Orginal;
            Counter = 0;
            rangedToggle.Decrease();
            knifeToggle.Decrease();
        }
        
    }
    
    
    void Start()
    {
        Orginal = buttonText.text;
        Counter = 0;
        rangedToggle = GameObject.FindObjectOfType<RangedToggle>();
        knifeToggle = GameObject.FindObjectOfType<KnifeToggle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}