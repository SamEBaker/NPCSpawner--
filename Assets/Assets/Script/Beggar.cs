using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Beggar : INPC
{
    public void Speak(CanvasStuff c)
    {
        c.message.text = "Oh...hey...how you doin? ;)";
    }
}
