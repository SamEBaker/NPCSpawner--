using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopowner : INPC
{
    public void Speak(CanvasStuff c)
    {
        c.message.text = "You got games on ur phone?";
    }
}
