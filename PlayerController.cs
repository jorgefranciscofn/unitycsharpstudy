using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour

{
    // make the speed turns into a public class so i can edity in  engine
    private float speed = 25.0f;
    private float turnSpeed= 25.0f;
    private float horizontalInput;
    private float forwardInput;
    public string Inputid;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //built in unity input methods
        horizontalInput = Input.GetAxis("Horizontal" + Inputid);
        forwardInput= Input.GetAxis("Vertical" + Inputid);
        //move the vehicle          
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime*turnSpeed*horizontalInput);
    }
}
