//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//      2018        //
//------------------//
    //useful for anything?
using UnityEngine;
using UnityEngine.EventSystems;

public class IncreaseTargetSize : MonoBehaviour {

    float rotateSpeed = 20;
    float speed = 200;

    public GameObject targetObject;
    public bool buttonPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    public void rotateRight ()
    {
        float rotateX = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad;
        targetObject.transform.Rotate(Vector3.up, -rotateX);
    }

    public void rotateLeft ()
    {
        
        float rotateY = Input.GetAxis("Mouse Y") * rotateSpeed * Mathf.Deg2Rad;
        targetObject.transform.Rotate(Vector3.up, speed);
    }
    /*
	// Use this for initialization
	void Start () {
		
	}
	*/
    // Update is called once per frame
    void Update () {
        if (buttonPressed == true)
        {
            
        }
	}
    
}
