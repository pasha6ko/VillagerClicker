using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    static public PlayerData instance;
    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(this);      
        else
            instance = this;
    }
}
