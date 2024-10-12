using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;
    public AudioClip ac;
    public int villagerIndex = 0;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = ac;
            audio.Play();
            if (villagerIndex != 2)
            {
                m_SpawnerNPC.SpawnVillagers(villagerIndex);
                villagerIndex += 1;
            }
            else if(villagerIndex == 2)
            {
                m_SpawnerNPC.SpawnVillagers(villagerIndex);
                villagerIndex = 0;
            }
        }
    }
}
