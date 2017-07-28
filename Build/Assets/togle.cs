using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class togle : MonoBehaviour
{
    public Toggle r1;
    public Toggle r2;
    public Toggle r3;
    public Toggle r4;
    public Toggle r5;
    public Toggle r6;
    public Toggle r7;
    public Toggle r8;
    public Toggle r9;
    public Toggle r10;
    public Toggle r11;
    public Toggle r12;
    public Toggle r13;
    public Toggle r14;
    public Toggle r15;
    public Toggle r16;
    public Text txt;
    public int i;

    public void xxyy()
    {
        i = 0;
        if (r1.isOn)  i = i + 1;
        if (r2.isOn) i = i + 1;
        if (r3.isOn) i = i + 1;
        if (r4.isOn) i = i + 1;
        if (r5.isOn) i = i + 1;
        if (r6.isOn) i = i + 1;
        if (r7.isOn) i = i + 1;
        if (r8.isOn) i = i + 1;
        if (r9.isOn) i = i + 1;
        if (r10.isOn) i = i + 1;
        if (r11.isOn) i = i + 1;
        if (r12.isOn) i = i + 1;
        if (r13.isOn) i = i + 1;
        if (r14.isOn) i = i + 1;
        if (r15.isOn) i = i + 1;
        if (r16.isOn)  i = i + 1;
        txt.text = i.ToString()+"/16";

    }
     public void onsubmit()
     { xxyy(); }


}