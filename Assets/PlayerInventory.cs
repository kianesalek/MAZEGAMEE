using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCherries { get; private set; }

    public UnityEvent<PlayerInventory> OnCherriesCollected;

    public void CherriesCollected()
    {
        NumberOfCherries++;
        OnCherriesCollected.Invoke(this);
    }

}
