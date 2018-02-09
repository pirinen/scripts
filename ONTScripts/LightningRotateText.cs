//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//      2018        //
//------------------//

using UnityEngine;
using UnityEngine.UI;

public class LightningRotateText : MonoBehaviour
{

    //public static int value;
    public Light lightComponent;
    Text RotText;
    // Use this for initialization
    void Start()
    {
        RotText = GetComponent<Text>();
        //value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        RotText.text = lightComponent.name + " " + lightComponent.transform.eulerAngles.y.ToString("0.000");
    }
}
