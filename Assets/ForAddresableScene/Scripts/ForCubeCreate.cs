using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;

public class ForCubeCreate : MonoBehaviour
{
    public GameObject MyCube;

    public void CreateCubeOnButton()
    {
        Addressables.InstantiateAsync("Cube", Vector3.zero, Quaternion.identity).Completed += handle =>
        {
            MyCube = handle.Result;
        };
    }
}
