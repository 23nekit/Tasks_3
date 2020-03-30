using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateAssetBundles : Editor
{
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAssetBundles()
    {
        BuildPipeline.BuildAssetBundles(@"C:\AssetBundles", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneWindows64);
    }
}
