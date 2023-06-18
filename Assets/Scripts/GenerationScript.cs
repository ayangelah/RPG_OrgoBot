using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GenerationScript : MonoBehaviour
{
    public GameObject atomPrefab;
    public GameObject bondPrefab;
    public GameObject moleculePrefab;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && IsMouseOverUI())
        {
            //instantiate an atom
            Vector3 mousepos = Input.mousePosition;
            var atomObject = Instantiate(atomPrefab, position: mousepos, Quaternion.identity);
            atomObject.transform.SetParent(gameObject.transform);
            atomObject.gameObject.AddComponent<Atom>();
            var atomscript = atomObject.gameObject.GetComponent<Atom>();
            atomscript.setAtom("carbon", mousepos.x, mousepos.y);

            //instantiate a molecule
            var moleculeObject = Instantiate(moleculePrefab, position: mousepos, Quaternion.identity);
            atomscript.setMolecule(moleculeObject);
            moleculeObject.transform.SetParent(gameObject.transform);
            moleculeObject.gameObject.AddComponent<Molecule>();
            var molscript = moleculeObject.gameObject.GetComponent<Molecule>();
            molscript.addAtom(atomObject);
        }

        if(Input.GetMouseButtonDown(0))
        {
        }
    }

    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
}
