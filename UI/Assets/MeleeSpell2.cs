using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeSpell2 : MonoBehaviour
{
    public Text buttonText;
    bool sword;
    bool bow;
    bool staff;
    bool knife;

    void Start()
    {
        sword = false;
        bow = false;
        staff = false;
        knife = false;
        buttonText.text = "";
    }

    public void Change  (){
        if (sword && bow){
            buttonText.text = "Let it Rain";
        }

        if (knife && staff){
            buttonText.text = "Flying Knife";
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



    // Update is called once per frame
    void Update()
    {
        
    }
}