//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//      2018        //
//------------------//

using UnityEngine;
using UnityEngine.UI;

public class LightingTextScript : MonoBehaviour {

    //public static int value;
    public Light lightComponent;
    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        //value = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //lightComponent.intensity.ToString();
        text.text = lightComponent.name + " " + lightComponent.intensity.ToString("0.000");
    }
}
