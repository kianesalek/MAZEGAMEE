using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI cherryText;
    void Start()
    {
        cherryText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void UpdateCherryText(PlayerInventory playerInventory)
    {
        cherryText.text = playerInventory.NumberOfCherries.ToString();
    }
}
