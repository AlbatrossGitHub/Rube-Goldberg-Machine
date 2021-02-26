using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{

    SpriteRenderer myRenderer; //makes variable myRenderer of datatype SpriteRenderer

    public Color floorColor; //makes variable floorcolor of datatype Color
    public Color gateColor; //makes variable gatecolor of datatype color

    Rigidbody2D myBody; //makes variable myBody of type Rigidbody2d

    public float power;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>(); //sets myRenderer to the correct SpriteRenderer
        myBody = gameObject.GetComponent<Rigidbody2D>(); //sets myBody to the correct Rigidbody2d
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){ //when we tap Space
            //both of htese next two lines do the exact same thing
            myBody.AddForce((Vector3.right + Vector3.up)*power); // we add force in the right direction
            ///myBody.AddForce((new Vector3(1, 0, 0) + new Vector3(0, 1, 0)) * power); //we are basically creating a new vector struct, and power makes it faster
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Floor"){ //when it hits the floor it changes color
            myRenderer.color = floorColor;
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Gate"){ //when it passes the gate it changes color
            myRenderer.color = gateColor;
        }
    }
}
