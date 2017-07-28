using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//afiseaza textul pe ecranul jucatorului
public class Textpeecran : MonoBehaviour
{
    public bool display = false;
    public bool displayInfo;// vede daca jucatorul are mouse-ul indreptat spre tinta
    public int x;
    public int y;
    string text = System.IO.File.ReadAllText("text_1.txt");
    GUIStyle style = new GUIStyle();
    GUIStyle style_2 = new GUIStyle();
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
    void OnTriggerEnter(Collider iCollide) //vede daca jucatorul este in trigger-ul tintei
    {
        if (iCollide.transform.name == "FPSController")
            display = true;
    }
    void OnTriggerExit(Collider iCollide) //vede daca jucatorul este in trigger-ul tintei
    {
        if (iCollide.transform.name == "FPSController")
            display = false;
    }
    void OnGUI()//afiseaza textul pe ecran creand un dreptunghi de dimensiuni ajustabile
    {
        GUI.skin = aSkin;
        GUIStyle style = new GUIStyle(GUI.skin.GetStyle("box"));
        GUIStyle style_2 = new GUIStyle(GUI.skin.GetStyle("button"));
        if (display == true && displayInfo)
        {
            GUI.Box(new Rect(0, y, Screen.width, Screen.height),"Palatul Mogosoaia", style_2);
            GUI.Box(new Rect(0, x, Screen.width, Screen.height), text, style);
        }
    }
}
