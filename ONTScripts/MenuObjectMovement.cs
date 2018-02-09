//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//      2018        //
//------------------//

using UnityEngine;

public class MenuObjectMovement : MonoBehaviour {

    public float rotateSpeed = 0.5f;

    public Vector3 RotateAxis = Vector3.forward;

    void Update()
    {
        transform.rotation *= Quaternion.AngleAxis(rotateSpeed, RotateAxis);
    }
    
}