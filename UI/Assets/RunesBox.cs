using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunesBox : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        transform.localScale = Vector2.zero;
    }


    public void Open() {
        transform.localScale = Vector2.zero;
        transform.LeanScale(Vector2.one, 0.2f);
    }

    public void Close(){
        transform.localScale = Vector2.zero;
    }
}
