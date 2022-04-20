using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackBox : MonoBehaviour
{
    void Start()
    {
        transform.localScale = Vector2.zero;
    }

    public void Open(float f) {
        transform.localScale = Vector2.zero;
        transform.LeanScale(Vector2.one, f);
    }

    public void Close(){
        transform.localScale = Vector2.zero;
    }
    
}
