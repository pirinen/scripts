//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//      2018        //
//------------------//

using UnityEngine;

public class OpenDoor : MonoBehaviour {

    #region ROTATE
    private float _sensitivity = 0.4f;
    private Vector3 _mouseReference;
    private Vector3 _mouseOffset;
    private Vector3 _rotation = Vector3.zero;
    private bool _isRotating;
    public GameObject Target;
    private float angle;

    #endregion

    void Update()       //close point 90, open point max 195(?)
    {
        angle = Target.transform.localEulerAngles.y;
        
        if (_isRotating)
        {
            // offset
            _mouseOffset = (Input.mousePosition - _mouseReference);

            // apply rotation
            _rotation.y = -(_mouseOffset.x + _mouseOffset.y) * _sensitivity;
            
            if (angle < 90)
            {
                Target.transform.localEulerAngles = new Vector3(0,90,0);
                //angle = 90;
                //_isRotating = false;
            }
            else if (angle > 195)
            {
                Target.transform.localEulerAngles = new Vector3(0, 195, 0);
                //angle = 195;
                //_isRotating = false;
            }
            if (angle >= 90 && angle <= 195)
            {
                // rotate
                Target.transform.Rotate(_rotation);

                // store new mouse position
                _mouseReference = Input.mousePosition;
            }
            else
            {
                _isRotating = false;
            }
            
        }

        if (Input.GetMouseButtonDown(0))
        //void OnMouseDown()
        {
            // rotating flag
            _isRotating = true;
            // store mouse position
            _mouseReference = Input.mousePosition;
        }

        //void OnMouseUp()
        if (Input.GetMouseButtonUp(0))
        {
            //angle = 91;
            // rotating flag
            _isRotating = false;
        }
    }
}