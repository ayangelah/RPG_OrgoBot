using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeOnCollision : Interactable
{
    [SerializeField] string Scene;
    public bool levelCompleted;
    public override void Interact()
    {
        base.Interact();
        if (levelCompleted)
            Teleport();
        else
            Debug.Log("level isn't done");
    }

    void Teleport()
    {
        SceneManager.LoadScene(Scene);
    }
}
