using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Recipe")]
public class Recipes : ScriptableObject
{
    public string descriptionOfReaction;
    public List<Item> reagents;
    public List<Item> catalyst;
    public string solvent;

    [Space]
    public List<Item> product1;
    public List<Item> product2;
}
