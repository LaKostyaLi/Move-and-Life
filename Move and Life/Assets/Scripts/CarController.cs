using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
   public ItemsUp _itemsUp;
   void NextLevel()
   {
        if(_itemsUp._image.color == Color.green)
        {
            Debug.Log("You need fast help your wife");
        }
   }
}
