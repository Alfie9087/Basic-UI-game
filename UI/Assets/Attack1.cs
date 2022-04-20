using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack1 : MonoBehaviour
{
    public int counter;
    public Text Attack;
    MeleeSpell1 spell;
    bool sword;
    bool bow;
    bool staff;
    bool knife;
    // Start is called before the first frame update
    void Start()
    {
        staff = false;
        knife = false;
        spell = GameObject.FindObjectOfType<MeleeSpell1>();
        
        counter = 0;
    }

    public void Show()
    {
        if (counter == 0)
        {
            transform.localScale = Vector2.one;
            Attack = spell.buttonText;
            counter = 1;
        }
        else {
            transform.localScale = Vector2.zero;
            counter = 0;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
