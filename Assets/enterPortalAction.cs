using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterPortalAction : MonoBehaviour
{
    public LevelLoader levelLoader;
    public int level;

    private void OnTriggerEnter(Collider other)
    {
        levelLoader.LoadLevel(level);
    }
}
