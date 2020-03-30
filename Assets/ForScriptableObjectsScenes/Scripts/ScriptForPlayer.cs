using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForPlayer : MonoBehaviour
{
    public Player PlayerConfig;

    private void Start()
    {
        gameObject.name = PlayerConfig.Name;
        gameObject.GetComponent<MeshRenderer>().material.color = PlayerConfig.PlayerColor;
    }
}
