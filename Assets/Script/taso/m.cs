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
            // ���b�V�����쐬
            Mesh mesh = new Mesh();

            // ���_���X�g���쐬
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

            // �ʂ��\������C���f�b�N�X���X�g���쐬
            List<int> triangles = new List<int> {
            0, 1, 2,  // ����
            0, 2, 3,  // ����
            4, 5, 6,  // �O��
            4, 6, 7,  // �O��
            0, 4, 7,  // �E��
            0, 3, 4,  // �E��
            6, 2, 1,  // ����
            6, 5, 2,  // ����
        };

            // �ʂ��\������C���f�b�N�X���X�g���쐬
            List<int> subtriangles = new List<int> {
            6, 1, 0,  // ���
            7, 6, 0,  // ���
            4, 3, 2,  // ����
            5, 4, 2,  // ����
        };

            // ���b�V���ɒ��_��o�^����
            mesh.SetVertices(vertices);

            // �T�u���b�V���̊i�[����2�ɐݒ肷��B
            mesh.subMeshCount = 2;

            // �C���f�b�N�X 0 �̃T�u���b�V���ɖʂ��\������C���f�b�N�X���X�g��o�^����
            mesh.SetTriangles(triangles, 0);

            // �C���f�b�N�X 1 �̃T�u���b�V���ɖʂ��\������C���f�b�N�X���X�g��o�^����
            mesh.SetTriangles(subtriangles, 1);

            // �쐬�������b�V�������b�V���t�B���^�[�ɐݒ肷��
            MeshFilter meshFilter = GetComponent<MeshFilter>();
            meshFilter.mesh = mesh;
        }

    }
}
