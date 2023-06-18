using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atom : MonoBehaviour
{
    string identity;
    int index;
    float positionX;
    float positionY;
    GameObject molecule;

    public void setAtom(string identity, float positionX, float positionY)
    {
        this.identity = identity;
        this.positionX = positionX;
        this.positionY = positionY;
    }

    public GameObject getObject() { return gameObject; }
    public void setIndex(int i) { index = i; }
    public int getIndex() { return index; }
    public string getIdentity() { return identity; }
    public void setMolecule(GameObject mol) { molecule = mol; }
    public GameObject getMolecule() { return molecule; }
}
