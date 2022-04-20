using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBox : MonoBehaviour
{
    bool weapon;
    bool support;
    // Start is called before the first frame update
    void Start()
    {
        weapon = false;
        support = false;
        transform.localScale = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Close(){
        transform.localScale = Vector2.zero;
    }
    public void Weapon(){
        if (weapon){
            weapon = false;
        }
        else{
            ;weapon = true;
        }

    }
    public void Support(){
        if (support){
            support = false;
        }
        else{
            support = true;
        }
    }

    public void Show()
    {
        if (weapon && support)
        {
            transform.localScale = Vector2.zero;
            
        }
        else {
            transform.localScale = Vector2.one;
        }
    }
}
