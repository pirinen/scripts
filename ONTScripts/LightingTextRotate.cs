//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//      2018        //
//------------------//

using UnityEngine;
using UnityEngine.UI;

public class LightingTextRotate : MonoBehaviour {

    public Light lightComponent;
    public Slider sliderObject;

    // Use this for initialization
    void Start () {
		//lightRotation = lightComponent.transform.rotation.y;
    }
	
	// Update is called once per frame
	void Update () {
        //lightComponent.transform.rotation.y = sliderValue;
        lightComponent.transform.localEulerAngles = new Vector3(lightComponent.transform.rotation.x, sliderObject.value, lightComponent.transform.rotation.z);
        Debug.Log("Light angle: " + lightComponent.transform.eulerAngles.y);
    }
}
