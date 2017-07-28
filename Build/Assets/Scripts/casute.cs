using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class casute : MonoBehaviour
{
    public InputField r1;
    public InputField r2;
    public InputField r3;
    public InputField r4;
    public InputField r5;
    public InputField r6;
    public InputField r7;
   
    public Text txt;
    public int i;

    public void xxyy()
    {
        i = 0;
        if (r1.text=="Pronaos" || r1.text=="pronaos") i = i + 1;
        if (r2.text == "Naos" || r2.text == "naos") i = i + 1;
        if (r3.text == "Altar" || r3.text == "altar") i = i + 1;
        if (r4.text == "Pridvor" || r4.text == "pridvor") i = i + 1;
        if (r5.text == "Pronaos" || r5.text == "pronaos") i = i + 1;
        if (r6.text == "Naos" || r6.text == "naos") i = i + 1;
        if (r7.text == "Altar" || r7.text == "altar") i = i + 1;
        
        txt.text = i.ToString() + "/7 corecte";

    }
    public void onsubmit()
    { xxyy(); }


}