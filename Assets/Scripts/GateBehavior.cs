using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateBehavior : MonoBehaviour
{

    SpriteRenderer myRenderer; //makes variable myRenderer of datatype SpriteRenderer

    //SpriteRenderer gateRenderer;

    //public Color floorColor; //makes variable floorcolor of datatype Color
    public Color gateColor; //makes variable gatecolor of datatype color

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>(); //sets myRenderer to the correct SpriteRenderer
        //myBody = gameObject.GetComponent<Rigidbody2D>(); //sets myBody to the correct Rigidbody2d
        //gateRenderer = gameObject.GetComponent
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Ball"){ //when it passes the gate it changes color
            myRenderer.color = gateColor;
        }
    }
}
