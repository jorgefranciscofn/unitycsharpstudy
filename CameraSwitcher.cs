using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // Start is called before the first frame update

    //here i create 2 public camera from a built in method  i found in the unity documentation
    public Camera firstpersoncamera;
    public Camera thirdpersoncamera;
    public string SwitchId;
    void Start()
    {
    // once the game starts one of the cameras is disabled
        thirdpersoncamera.enabled = true;
        firstpersoncamera.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        //here i use the input method with a axis i created in the engine repeating the if c# method to switch the cameras using the letters q and e and for p2 letter k and l
        // using the same logic as to make the p1 and p2 moving from diferent inputs i adpated this to my camera switch sistem 
        
        if (Input.GetKeyDown(SwitchId))
        {
            thirdpersoncamera.enabled=!thirdpersoncamera.enabled;
            firstpersoncamera.enabled=!firstpersoncamera.enabled;
        }
        
    }
}
