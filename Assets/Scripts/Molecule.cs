using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molecule
{
    int[,] moleculeArray;
    List<Atom> atoms = new List<Atom>();

    public Molecule() { }

    public Molecule(Atom first)
    {
        atoms.Add(first);
    }

    public void addAtom(Atom a)
    {
        if (!atoms.Contains(a))
        {
            a.setIndex(atoms.Count);
            atoms.Add(a);
        }
        Debug.Log(atoms.Count);
    }

    public List<Atom> getAtoms() { return atoms; }
    public int getBondOrder() { return 1; }
    public int getLongestChain() { return atoms.Count; }
}
