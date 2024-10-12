using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;
    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public CanvasStuff c;


    public void SpawnVillagers(int i)
    {
        if( i == 0)
        {
            m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
            p2.SetActive(false);
            p3.SetActive(false);
            p1.SetActive(true);
            m_Beggar.Speak(c);
        }
        else if( i == 1)
        {
            m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
            p2.SetActive(true);
            p3.SetActive(false);
            p1.SetActive(false);
            m_Farmer.Speak(c);
        }
        else if(i == 2)
        {
            m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
            p2.SetActive(false);
            p3.SetActive(true);
            p1.SetActive(false);
            m_Shopowner.Speak(c);
        }

    }
}
