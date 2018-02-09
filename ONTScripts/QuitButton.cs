//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//      2018        //
//------------------//

using UnityEngine;

public class QuitButton : MonoBehaviour {

    public void QuitProgram()
    {
        //UnityEditor.EditorApplication.isPlaying = false;    //for editor testing, comment away for application
        Application.Quit();                                 //for application
    }
}
