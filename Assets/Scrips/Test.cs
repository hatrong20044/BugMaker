using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<Transform> childs =new List<Transform>();
    void Start()
    {
        for(int i=0; i<this.transform.childCount; i++)
        {
            childs.Add(this.transform.GetChild(i));//thêm mấy thằng con của thằng cha trong insperator vào danh sách childs
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0 ; i<childs.Count; i++) {
            childs[i].name = "";
        }

    }
    private void OnDrawGizmosSelected()//thay vì việc kéo thả thì ta dùng hàm này ,
                                       //sau khi bấm vô thằng mà sở hữu đoạn mã này nó rẽ auto kéo thả vào sanh sách list

    {
        childs.Clear();
        for (int i=0;i<transform.childCount; i++)
        {
           
            childs.Add(this.transform.GetChild(i));
        }
    }
}
