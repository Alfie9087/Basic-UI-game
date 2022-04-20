using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetBox : MonoBehaviour
{   
    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector2.zero;
        Vector3 position = transform.position;
    }
    public void Open() {
        transform.localScale = Vector2.zero;
        transform.LeanScale(Vector2.one, 0.2f);
    }
    public void Close(){
        transform.localScale = Vector2.zero;
    }
    public void Attack1(){
        position.x = 546+200;
        position.y = 313-154;
        transform.position = position;
    }
    public void Attack2(){
        position.x = 546+200;
        position.y = 313-208;
        transform.position = position;
    }
    public void Attack3(){
        position.x = 546+200;
        position.y = 313-257;
        transform.position = position;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
