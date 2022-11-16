using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;
    public int itemID;

    public bool isCatalyst = false;
    public bool isReagent = true;
    public string functionalGroups;
    public string properties;
    public int levelUnlocked;
    [Range(1, 5)]
    public int electronucleophilicity;
    [Range(1, 5)]
    public int stability;
}