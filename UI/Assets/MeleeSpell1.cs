using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeSpell1 : MonoBehaviour
{
    public Text buttonText;
    bool sword;
    bool bow;
    bool staff;
    bool knife;
    Attack3 attack3;
    void Start()
    {
        sword = false;
        bow = false;
        staff = false;
        knife = false;
        buttonText.text = "";
        attack3 = GameObject.FindObjectOfType<Attack3>();
    }

    public void Change(){
        if (sword && bow){
            attack3.Show();
        }
        else if (knife && staff){
            attack3.Show();
        }
        else {
            attack3.Hide();
        }
        if (sword){
            buttonText.text = "Slash";
        }
        else if (bow){
            buttonText.text = "Revenge Arrow";
        }
        else if (staff){
            buttonText.text = "Fireball";
        }
        else if (knife){
            buttonText.text = "Stab";
        }
        else {
            buttonText.text = "punch";
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
