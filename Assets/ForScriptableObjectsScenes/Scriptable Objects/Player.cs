using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Player")]
public class Player : ScriptableObject
{
    public string Name;
    public Color PlayerColor;

    public Player(string Name, Color PlayerColor)
    {
        this.Name = Name;
        this.PlayerColor = PlayerColor;
    }
}
