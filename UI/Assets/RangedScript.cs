using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RangedScript : MonoBehaviour
{
    // Start is called before the first frame update
    RuneToggle runeToggle;
    BowToggle bowToggle;
    public Text buttonText;
    int Counter;
    private string Orginal;
    // Start is called before the first frame update
    public void SetText(string text)
    {
        if (Counter == 0) {
            Counter = 1;
            buttonText.text = text;
            runeToggle.Increase();
            bowToggle.Increase();
        }
        else {
            buttonText.text = Orginal;
            Counter = 0;
            runeToggle.Decrease();
            bowToggle.Decrease();
        }
        
    }
    
    
    void Start()
    {
        Orginal = buttonText.text;
        Counter = 0;
        runeToggle = GameObject.FindObjectOfType<RuneToggle>();
        bowToggle = GameObject.FindObjectOfType<BowToggle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
