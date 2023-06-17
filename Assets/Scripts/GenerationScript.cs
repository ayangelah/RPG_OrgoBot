using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GenerationScript : MonoBehaviour
{
    public GameObject atomPrefab;
    public Molecule molecule = new Molecule();

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && IsMouseOverUI())
        {
            //ui instantiation
            Vector3 mousepos = Input.mousePosition;
            var atomObject = Instantiate(atomPrefab, position: mousepos, Quaternion.identity);
            atomObject.transform.SetParent(gameObject.transform);
            Atom atom = new Atom(atomObject, "carbon", mousepos.x, mousepos.y);
            molecule.addAtom(atom);
        }
    }

    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
}
