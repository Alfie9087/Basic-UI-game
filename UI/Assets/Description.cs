using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Description : MonoBehaviour
{
    bool trainer;
    bool attack1;
    bool attack2;
    bool attack3;
    bool sword;
    bool bow;
    bool staff;
    bool knife;
    public Text descriptiontext;
    // Start is called before the first frame update
    void Start()
    {
        trainer = false;
        sword = false;
        bow = false;
        staff = false;
        knife = false;
        attack1 = false;
        attack2 = false;
        attack3 = false;
        transform.localScale = Vector2.zero;
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
    public void Attack1(){
        attack1 = true;
    }
    public void Attack2(){
            attack2 = true;
        }

    public void Attack3(){
            attack3 = true;
    }
    public void Attack1Off(){
        attack1 = false;
    }
    public void Attack2Off(){
            attack2 = false;
        }

    public void Attack3Off(){
            attack3 = false;
    }
    public void Trainer(){
        trainer = true;
    }
    public void Charmander(){
        trainer = false;
    }
    public void Show(){
        transform.localScale = Vector2.one;
        

        if (attack3){
           if (sword){
            descriptiontext.text = "Charmander used Let it Rain on ";
           }
           else{
            descriptiontext.text = "Charmander used Flying Knife on ";
           }
    
        }

        if (attack1){
            if (sword){
                descriptiontext.text = "Charmander used Slash on ";
            }
            else if (staff){
                descriptiontext.text = "Charmander used Fireball on ";
            }
            else if (bow){
                descriptiontext.text = "Charmander used Revenge Arrow on ";
            }
            else if (knife){
                descriptiontext.text = "Charmander used Stab on ";
            }
            else {
                descriptiontext.text = "Charmander used Punch on ";
            }
            
        }

        if (attack2){
            if (bow){
                descriptiontext.text = "Charmander used Explosive Arrow on ";
            }
            else if (knife){
                descriptiontext.text = "Charmander used Shank on ";
            }
            else if (sword){
                descriptiontext.text = "Charmander used Parry on ";
            }
            else if (staff){
                descriptiontext.text = "Charmander used Ember on ";
            }
            else {
                descriptiontext.text = "Charmander used Run Away on ";
            }
        
            
        }




        if (trainer){
            descriptiontext.text += "Trainer";
        }
        else{
            descriptiontext.text += "Charmander";
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
