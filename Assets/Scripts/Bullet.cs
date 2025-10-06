using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float deleteTime = 5.0f; //削除されるまでの時間
    public GameObject boms; //爆発のエフェクト
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //deleteTime秒後に消える
        Destroy(this.gameObject, deleteTime);

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        //相手がEnemyタグなら相手を削除
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Instantiate(boms, //生成したいオブジェクト
                other.transform.position, //生成する位置
                Quaternion.identity //回転しない
                );
        }
        //相手がEnemyタグならbomsを生成


        //いずれにしても自分を削除
        Destroy(this.gameObject);
    }
}
