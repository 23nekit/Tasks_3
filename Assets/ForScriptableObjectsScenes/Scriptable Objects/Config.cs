using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "AppConfig", menuName = "AppConfig")]
public class Config : ScriptableObject
{
    public string AppName;
    public string AppVersion;
    public List<Player> ListOfPlayers;
    private void OnEnable()
    {
        AppName = Application.productName;
        AppVersion = Application.version;
    }
}
