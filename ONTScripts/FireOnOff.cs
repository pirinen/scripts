//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//      2018        //
//------------------//
    
using UnityEngine;
using UnityEngine.UI;

public class FireOnOff : MonoBehaviour {

    public ParticleSystem Target;
    public Button BtnName;
    int i;
    private bool Switch;
        
    public void FireOn()
    {
        i++;
        //Debug.Log(i);
        if (Switch == false)
        {
            //Debug.Log("FireOn, target: " + Target.name);
            Target.Play();
            BtnName.enabled = true;
            Switch = true;
        }
        else
        {
            //Debug.Log("FireOff, target: " + Target.name);
            Target.Stop();
            BtnName.enabled = false;
            Switch = false;
        }
        
    }

}
