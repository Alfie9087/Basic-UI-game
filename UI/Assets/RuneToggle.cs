using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuneToggle : MonoBehaviour
{
    
    public int Counter;
    private Button ThisButton;
    // Start is called before the first frame update
    void Start()
    {
        Counter = 0;
        ThisButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Counter != 0) {
            ThisButton.interactable = false;
        }
        else {
            ThisButton.interactable = true;
        }
    }
     public void Increase(){
        Counter+=1;
    }
    public void Decrease(){
        Counter-=1;
    }
}
