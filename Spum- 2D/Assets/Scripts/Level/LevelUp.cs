using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LevelUp : MonoBehaviour
{
    [SerializeField] private RandomItemLevelUp m_itemObject;
    [SerializeField] private List<ItemDefine> m_listItemDefine;
    [SerializeField] private RectTransform m_rectTransform;
    [SerializeField] private GameObject selectItemPanel;
    [SerializeField] private LevelPlayer m_levelPlayer;
    

    private void Start()
    {
        SpawnItem();
        
    }

    private void SpawnItem()
    {
        bool[] checkSpawnItem = new bool[m_listItemDefine.Count];
        for (int i = 0; i < checkSpawnItem.Length; i++)
        {
            checkSpawnItem[i] = false;
        }

        for (int i = 0; i < 3; i++)
        {
            var randomItem = Random.Range(0, checkSpawnItem.Length);
            if (checkSpawnItem[randomItem] == true)
            {
                i--;
                continue;
            }

            checkSpawnItem[randomItem] = true;
            var spawnItemUI = Instantiate(m_itemObject, m_rectTransform);
            spawnItemUI.SetImg(m_listItemDefine[randomItem].sprite);
            spawnItemUI.SetDescription(m_listItemDefine[randomItem].description);
            spawnItemUI.SetName(m_listItemDefine[randomItem].name);
        }
    }

    private void ClickItemLevelUp(RandomItemLevelUp randomItemLevelUp)
    {
        
        //if (randomItemLevelUp.GetName().Equals("Suriken") )
        //{
            //Inventory.Instance.AddSuriken();
            m_levelPlayer.ContinueGame();
            
        //}
    }

    private void OnEnable()
    {
        m_itemObject.OnClickItem += ClickItemLevelUp;
    }

    private void OnDestroy()
    {
        m_itemObject.OnClickItem -= ClickItemLevelUp;
    }
}
