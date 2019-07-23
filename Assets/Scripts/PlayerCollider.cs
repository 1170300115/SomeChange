using UnityEngine;

/*
 * Provide the obstacles with a way of damaging the player.
 */
public class PlayerCollider : MonoBehaviour
{

    public string thisLevel;

    /*
     * A trigger callback to detect when the player's collider has
     * entered the obstacle's. Then simply obtain the PlayerController
     * reference can apply damage. Then remove the obstacle for feedback.
     */
    private void OnTriggerEnter2D(Collider2D other)
  {
    // Obtain a reference to the Player's PlayerController
    PlayerController playerController =
      other.gameObject.GetComponent<PlayerController>();
    
        if (gameObject.tag == "fallDown")//坠崖死亡
        {
            playerController.Die();
        }
        else if (gameObject.tag == "badTerrain")//有害地形
        {
            playerController.Damage();
        }
        else if (gameObject.tag == "nextLevel") //下一关卡
        {
            Application.LoadLevel("Level" + thisLevel);
        }
        else if (gameObject.tag == "endofGame") //通关
        {
            Application.LoadLevel("AllClear");
        }
        else//普通伤害
        {
            // Register damage with player
            playerController.Damage();

            // Make this object disappear
            GameObject.Destroy(gameObject);
        }


    
  }
}
