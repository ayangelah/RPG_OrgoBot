using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molecule : MonoBehaviour
{
    //int[,] moleculeArray;
    List<GameObject> atoms = new List<GameObject>();
    public List<GameObject> longestchain = new List<GameObject>();

    //public Molecule() { }

    //public Molecule(Atom first)
    //{
    //    atoms.Add(first);
    //}

    public void addAtom(GameObject a)
    {
        if (!atoms.Contains(a))
        {
            atoms.Add(a);
        }
        Debug.Log(atoms.Count);
    }

    public List<GameObject> getAtoms() { return atoms; }
    public int getBondOrder() { return 1; }
    public int getLongestChain() { return atoms.Count; }
}
