using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack3 : MonoBehaviour
{
    public int counter;
    bool sword;
    bool bow;
    bool staff;
    bool knife;

    void Start()
    {
        staff = false;
        knife = false;
        transform.localScale = Vector2.zero;
        counter = 0;
    }

    public void Show()
    {

        transform.localScale = Vector2.one;
    }
    public void Hide()
    {

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

    // Update is called once per frame
    void Update()
    {
        
    }
}