using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletFactory : MonoBehaviour
{
    [Header("Bullet Types")] 
    public GameObject enemyBullet;
    public GameObject playerBullet;

    public GameObject CreateBullet(BulletTypes type = BulletTypes.ENEMY)
    {
        GameObject tempBullet = null;
        switch (type)
        {
            case BulletTypes.ENEMY:
                tempBullet = Instantiate(enemyBullet);
                break;
            case BulletTypes.PLAYER:
                tempBullet = Instantiate(playerBullet);
                break;
        }

        tempBullet.transform.parent = transform;
        tempBullet.SetActive(false);
        return tempBullet;
    }
}
