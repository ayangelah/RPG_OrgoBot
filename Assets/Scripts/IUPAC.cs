using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IUPAC : MonoBehaviour
{
    [SerializeField] GenerationScript script;
    [SerializeField] TMP_Text m_name;

    Dictionary<int, string> longestChain = new Dictionary<int, string>
    {
        { 1, "meth" },
        { 2, "eth" },
        { 3, "prop" },
        { 4, "but" },
        { 5, "pent" },
        { 6, "hex" },
        { 7, "hept" },
        { 8, "oct" },
        { 9, "non" },
        { 10, "dec" },
        { 11, "undec" },
        { 12, "dedec" }
    };

    Dictionary<int, string> bondOrder = new Dictionary<int, string>
    {
        { 1, "ane" },
        { 2, "ene" },
        { 3, "yne" }
    };

    // Start is called before the first frame update
    void Start()
    {
        Molecule m_molecule = script.molecule;
        m_name.text = "blah";
    }

    // Update is called once per frame
    void Update()
    {
        m_name.text = longestChain[script.molecule.getLongestChain()] + bondOrder[script.molecule.getBondOrder()];
    }
}
