//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//      2018        //
//------------------//
    //on progress...
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelUp : MonoBehaviour {

    public GameObject Target;
    private float angle;

    // Use this for initialization
    /*void Start () {

    }
	*/
	// Update is called once per frame
	void Update () {

        //Debug.Log("ImageTarget x = " + angle);
        //angle = Target.transform.localEulerAngles.x;
        angle = Target.transform.rotation.x;

        if (angle >= 0.5 || angle <= -0.5)
        {
            //Debug.Log(Target + " takaisin pystyssä...");
            Target.transform.localEulerAngles = new Vector3(0, 0, 0); //palautetaan target pystyyn
            //Target.transform.rotation.x = new Vector3(0,0,0);
        }
    }
}
