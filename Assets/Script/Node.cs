using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 타일 노드
public class Node : MonoBehaviour
{
   
    public List< Material>N_material = new List<Material>();
    public GameObject[]N_Towers;
    GameObject N_instower;
    public static int N_num =0;
    void Awake()
    {
        N_Towers = Info.Instatnce.I_tower_ob;
        for (int i = 0; i < Info.Instatnce.I_node_mat.Length; i++)
        {
            N_material.Add(Info.Instatnce.I_node_mat[i]);
        }
    }
    void Update()
    {
        
    }
    void OnMouseDown()// 마우스 입력값을 받아 타워를 설치하고 타일의 마테리얼 변경
    {
        if (gameObject.GetComponent<Material>() == N_material[2]&& 
            gameObject.GetComponent<Material>() == N_material[3])
        {
            if (N_num != 0)
            {
                N_instower = Instantiate(N_Towers[N_num], gameObject.transform.position, gameObject.transform.rotation);
            }
            if (N_instower != null)
            {
                gameObject.GetComponent<MeshRenderer>().material = N_material[5];
            }
            else
                return;
        }
        if (gameObject.GetComponent<Material>() == N_material[3])
        {
            if (N_num == 6 )
            {
                N_instower = Instantiate(N_Towers[N_num], gameObject.transform.position, gameObject.transform.rotation);
            }
            if (N_instower != null)
            {
                gameObject.GetComponent<MeshRenderer>().material = N_material[5];
            }
            else
                return;
        }
        else GameSystem.Instatce.G_fail_text.text = "건설 불가능한 지역 입니다.";


    }
}
