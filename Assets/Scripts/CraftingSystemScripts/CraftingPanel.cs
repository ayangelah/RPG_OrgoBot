using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class CraftingPanel : MonoBehaviour
{
    [SerializeField] Image product1;
    [SerializeField] Image product2;
    [SerializeField] Image rcatalyst;
    [SerializeField] TextMeshProUGUI output;
    [Space]
    [SerializeField] Selected Reagent1;
    [SerializeField] Selected Reagent2;
    [SerializeField] Selected Catalyst;
    [SerializeField] Products Product1;
    [SerializeField] Products Product2;
    [SerializeField] Products RCatalyst;

    [SerializeField] List<Item> reagent1;
    [SerializeField] List<Item> reagent2;
    [SerializeField] List<Item> catalyst;

    [SerializeField] List<Recipes> recipes = new List<Recipes>();

    //public List<Item> reagents = new List<Item>();

    private void Update()
    {
        reagent1 = Reagent1.items;

        reagent2 = Reagent2.items;

        catalyst = Catalyst.items;
    }

    public void Combine()
    {
        List<Item> Temp = new List<Item>();
        Temp.AddRange(reagent1);
        Temp.AddRange(reagent2);

        foreach (Recipes recipe in recipes)
        {
            List<Item> recipeReagents = recipe.reagents;

            //sort recipeReagents
            if (recipeReagents[0].itemID > recipeReagents[1].itemID)
            {
                Item temp = recipeReagents[0];
                recipeReagents[0] = recipeReagents[1];
                recipeReagents[1] = temp;
            }

            //sort temp
            if (Temp[0].itemID > Temp[1].itemID)
            {
                Item temp = Temp[0];
                Temp[0] = Temp[1];
                Temp[1] = temp;
            }

            bool isEqual = Temp.SequenceEqual(recipeReagents);
            //bool isEqual = Enumerable.SequenceEqual(Temp.OrderBy(e => e), recipeReagents.OrderBy(e => e));
            if (isEqual)
            {
                Debug.Log(recipe.name);
                Debug.Log("Reagent Lists are Equal");
                //check catalyst and solvent
                if (catalyst[0] == recipe.catalyst[0] & output.text == recipe.solvent)
                {
                    Debug.Log("This is a valid recipe!");
                    Reagent1.ClearSlot();
                    Reagent2.ClearSlot();
                    Catalyst.ClearSlot();

                    Product1.Add(recipe.product1[0]);
                    Product2.Add(recipe.product2[0]);
                    RCatalyst.Add(recipe.catalyst[0]);

                    product1.sprite = recipe.product1[0].icon;
                    product2.sprite = recipe.product2[0].icon;
                    rcatalyst.sprite = recipe.catalyst[0].icon;

                }
                return;
            }
            else
            {
                Debug.Log("Reagent Lists are not Equal");
            }
        }

        Temp.Clear();
    }


}

