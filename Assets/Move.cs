using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public Transform Transf;
    public float Velocidad;
	// Use this for initialization
	void Start () {
        Transf = GetComponent<Transform>();
        //Transf.position = new Vector3(0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("holamundo");
        }

        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
      //  Debug.Log("Axis x: " + horizontal  +" Axis Y: "+ vertical);
       // Debug.Log("Position: " + Transf.position);
        Transf.position = new Vector2(transform.position.x+horizontal*Velocidad, transform.position.y+vertical*Velocidad);
    }
}
