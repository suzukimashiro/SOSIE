using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        void Start()
        {
            // メッシュを作成
            Mesh mesh = new Mesh();

            // 頂点リストを作成
            List<Vector3> vertices = new List<Vector3>
        {
            new Vector3(1.0f, 1.0f, 1.0f),
            new Vector3(-1.0f, 1.0f, 1.0f),
            new Vector3(-1.0f, -1.0f, 1.0f),
            new Vector3(1.0f, -1.0f, 1.0f),
            new Vector3(1.0f, -1.0f, -1.0f),
            new Vector3(-1.0f, -1.0f, -1.0f),
            new Vector3(-1.0f, 1.0f, -1.0f),
            new Vector3(1.0f, 1.0f, -1.0f),
        };

            // 面を構成するインデックスリストを作成
            List<int> triangles = new List<int> {
            0, 1, 2,  // 奥面
            0, 2, 3,  // 奥面
            4, 5, 6,  // 前面
            4, 6, 7,  // 前面
            0, 4, 7,  // 右面
            0, 3, 4,  // 右面
            6, 2, 1,  // 左面
            6, 5, 2,  // 左面
        };

            // 面を構成するインデックスリストを作成
            List<int> subtriangles = new List<int> {
            6, 1, 0,  // 上面
            7, 6, 0,  // 上面
            4, 3, 2,  // 下面
            5, 4, 2,  // 下面
        };

            // メッシュに頂点を登録する
            mesh.SetVertices(vertices);

            // サブメッシュの格納数を2つに設定する。
            mesh.subMeshCount = 2;

            // インデックス 0 のサブメッシュに面を構成するインデックスリストを登録する
            mesh.SetTriangles(triangles, 0);

            // インデックス 1 のサブメッシュに面を構成するインデックスリストを登録する
            mesh.SetTriangles(subtriangles, 1);

            // 作成したメッシュをメッシュフィルターに設定する
            MeshFilter meshFilter = GetComponent<MeshFilter>();
            meshFilter.mesh = mesh;
        }

    }
}
