using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour {
	
	void Update () {
        
    }

    void OnGUI()
    {
        foreach (Touch t in Input.touches)
        {
            string message = "";
            message += "ID: " + t.fingerId + "\n";

        }
    }

}
