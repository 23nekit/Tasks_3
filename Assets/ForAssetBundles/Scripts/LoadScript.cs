using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScript : MonoBehaviour
{
    public string Url;

    private AssetBundle MyLoadedAssetBundle;
    
    public void CreateTNT()
    {
        LoadAssetBundle();
    }

    private void LoadAssetBundle()
    {
        MyLoadedAssetBundle = AssetBundle.LoadFromFile(Url);
        Object Picture = MyLoadedAssetBundle.LoadAsset("Render");
        Instantiate(Picture);
    }
}
