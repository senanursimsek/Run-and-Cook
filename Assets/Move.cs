using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
public float speed;
public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    transform.position += transform.forward * Time.deltaTime * speed;    
    }
void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Jump")
            anim.SetTrigger("Jump");
        if(other.tag == "Fail"){
anim.SetTrigger("Fail");
OpenFailScreen();
speed = 0;
}
        if(other.tag == "Walk")
            anim.SetTrigger("Walk");
    }
public GameObject ui;
public GameObject failEkran;
    
    public void CloseTapToPlay()
    {
        ui.SetActive(false);
anim.SetTrigger("Walk");
speed=1;
    }

public void OpenFailScreen(){
failEkran.SetActive(true);}
}
