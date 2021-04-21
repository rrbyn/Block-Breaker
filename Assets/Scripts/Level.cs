using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
    
{
    // parameters
    [SerializeField] int breakableBlocks; // debug

    // cache
    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void DestroyBreakableBlocks()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }

    }

    public void Update()
    {
            
    }


}
