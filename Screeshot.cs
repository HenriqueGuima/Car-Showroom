using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screeshot : MonoBehaviour
{

    [SerializeField]

    public void TakeAShot() {
        StartCoroutine ("CaptureIt");
    }

    IEnumerator CaptureIt(){
        string tstamp = System.DateTime.Now.ToString ("dd-MM-yyyy-HH-mm-ss");
        string file = "ScrnSht" + tstamp + ".png";
        string path = file;
        ScreenCapture.CaptureScreenshot(path);
        yield return new WaitForEndOfFrame();

        //Instantiate (new Vector2(0f, 0f), Quaternion.identity);
    }

    public void Capture()
    {
        string tstamp = System.DateTime.Now.ToString ("dd-MM-yyyy-HH-mm-ss");
        string file = "ScrnSht" + tstamp + ".png";
        string path = file;
        ScreenCapture.CaptureScreenshot(path);
    }
}
