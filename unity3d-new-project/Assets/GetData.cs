using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetData : MonoBehaviour
{
    public Entity_GameDB entity_GameDB;

    void Start()
    {
        foreach(Entity_GameDB.Param param in entity_GameDB.sheets[0].list)
        {
            Debug.Log(param.index + " - " + param.name + " - " + param.hp + " - " + param.mp + " - " + param.dex);
        }
    }
}
