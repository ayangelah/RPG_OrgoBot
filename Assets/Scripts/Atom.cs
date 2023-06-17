using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atom
{
    string identity;
    int index;
    float positionX;
    float positionY;
    GameObject atomObject;

    public Atom(GameObject atomObject, string identity, float positionX, float positionY)
    {
        this.atomObject = atomObject;
        this.identity = identity;
        this.positionX = positionX;
        this.positionY = positionY;
    }

    public GameObject getObject() { return atomObject; }
    public void setIndex(int i) { index = i; }
    public int getIndex() { return index; }
    public string getIdentity() { return identity; }
}
