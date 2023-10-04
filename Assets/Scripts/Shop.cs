using System;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Action productUpgrade;
    [SerializeField] private List<int> productLevelUpgrade = new List<int>();
    [SerializeField] private List<int> productUpgradeMultiplyer = new List<int>();
    public ShopData data;

    private void Start()
    {
        productUpgrade += Upgrade;
        ConstractData();
    }
    private void Upgrade()
    {
        print("Upgrade");
    }
    private void ConstractData()
    {
        if (productLevelUpgrade.Count <= 1) return;

        data.productStage = 0;

        for (int i = 1; i < productLevelUpgrade.Count; i++)
        {
            if (data.productLevel >= productLevelUpgrade[i-1] && data.productLevel < productLevelUpgrade[i])
                continue;
            data.productStage = i;

        }
    }

    private void LevelUp()
    {
        data.productLevel++;
        if (data.productLevel < productLevelUpgrade[data.productStage] || data.productStage == productLevelUpgrade.Count-1) return;
        ConstractData();
        productUpgrade?.Invoke();
    }
    private void OnMouseDown()
    {
        LevelUp();
    }
}
[System.Serializable]
public class ShopData
{
    public int productLevel, cashierLevel;
    public int productStage;
    public float startPrice, cashierStartPrice;
    public int cashierCount;

}
