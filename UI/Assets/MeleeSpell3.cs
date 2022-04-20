using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeSpell3 : MonoBehaviour
{
    public Text buttonText;
    bool sword;
    bool bow;
    bool staff;
    bool knife;

    public void Change(){
        if (bow){
            buttonText.text = "Explosive Arrow";
        }
        else if (sword){
            buttonText.text = "Parry";
        }
        else if (knife){
            buttonText.text = "Shank";
        }
        else if (staff){
            buttonText.text = "Ember";
        }
        else {
            buttonText.text = "Run Away";
        }
    }
    public void Sword(){
        if (sword == false)
        {
            sword = true;
        }
        else
        {
            sword = false;
        }
    }
    public void Bow(){
        if (bow == false)
        {
            bow = true;
        }
        else
        {
            bow = false;
        }
    }
      public void Knife(){
        if (knife == false)
        {
            knife = true;
        }
        else
        {
            knife = false;
        }
    }
      public void Staff(){
        if (staff == false)
        {
            staff = true;
        }
        else
        {
            staff = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        sword = false;
        bow = false;
        staff = false;
        knife = false;
        buttonText.text = "";
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
