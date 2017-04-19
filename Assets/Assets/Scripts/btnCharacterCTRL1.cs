using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnCharacterCTRL1 : MonoBehaviour {

    public Sprite MageSprite;
    public Sprite WarriorSprite;
    public Sprite WarriorStats;
    public Sprite MageStats;

    public void MyButtonClickFunction(Image character)
    {
        if (character.sprite==WarriorSprite)
        {
            character.sprite = MageSprite;
            //stats.sprite = MageStats;

        }
        else { character.sprite = WarriorSprite;
          //  stats.sprite = WarriorStats;
        }
    }
    public void MyButtonClickFunction1 (Image stats)
    {
        if (stats.sprite == WarriorStats)
        {
            //character.sprite = MageSprite;
            stats.sprite = MageStats;

        }
        else
        {
          //  character.sprite = WarriorSprite;
              stats.sprite = WarriorStats;
        }
    }
}
