using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textpeecran_28 : MonoBehaviour
{
    public bool display = false;
    public bool displayInfo;
    public int x;
    public int y;
    string text = System.IO.File.ReadAllText("text_28.txt");
    GUIStyle style = new GUIStyle();
    public GUISkin aSkin;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseOver()
    {
        displayInfo = true;

    }
    void OnMouseExit()

    {
        displayInfo = false;

    }
    void OnTriggerEnter(Collider iCollide)
    {
        if (iCollide.transform.name == "FPSController")
        {
            Debug.Log("aaa");
            display = true;
        }
    }
    void OnTriggerExit(Collider iCollide)
    {
        if (iCollide.transform.name == "FPSController")
            display = false;
    }
    void OnGUI()
    {
        GUI.skin = aSkin;
        GUIStyle style = new GUIStyle(GUI.skin.GetStyle("box"));
        if (display == true && displayInfo)
            GUI.Box(new Rect(y, x, Screen.width, Screen.height), text, style);
    }
}
