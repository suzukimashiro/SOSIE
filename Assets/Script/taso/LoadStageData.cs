using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadStageData : MonoBehaviour
{
    [SerializeField] private DataServer server; //
    [SerializeField] private TextAsset data; //


    private void OnEnable()
    {
        LoadFromText();
        GenerateStage();
    }

    private void LoadFromText()
    {
        List<List<int>> temp_list = new List<List<int>>();
        string temp_data = data.text;
        string[] temp_data_list_1 = temp_data.Split('\n');

        for (int i = 0; i < temp_data_list_1.Length; i++)
        {
            List<int> temp = new List<int>();
            string[] temp_data_list_2 = temp_data_list_1[i].Split(',');
            for (int l = 0; l < temp_data_list_2.Length; l++)
            {
                temp.Add(int.Parse(temp_data_list_2[l]));
            }
            temp_list.Add(temp);
        }

        server.stageData = temp_list;
    }

    private void GenerateStage()
    {
        for (int i = 0; i < server.stageData.Count; i++)
        {
            for (int l = 0; l < server.stageData[i].Count; l++)
            {
                GameObject obj;
                int id = server.stageData.ToArray()[i].ToArray()[l];

                if (id == 0) { continue; }
                if (id == 1)
                {
                    GameObject tuti1_prefab = Resources.Load<GameObject>("Tuti1");
                    obj = Instantiate(tuti1_prefab);/*GameObject.CreatePrimitive(PrimitiveType.Cube);*/

                    obj.transform.parent = this.transform;
                    obj.transform.localPosition = new Vector3(i, 0, l);
                }
                else if (id == 2)
                {
                    GameObject tuti2_prefab = Resources.Load<GameObject>("Tuti2");
                    obj = Instantiate(tuti2_prefab);/*GameObject.CreatePrimitive(PrimitiveType.Cube);*/

                    obj.transform.parent = this.transform;
                    obj.transform.localPosition = new Vector3(i, 0, l);
                }
                else if (id == 3)
                {
                    GameObject bomb1_prefab = Resources.Load<GameObject>("Bomb1");
                    obj = Instantiate(bomb1_prefab);/*GameObject.CreatePrimitive(PrimitiveType.Cube);*/

                    //obj.transform.parent = this.transform;
                    obj.transform.localPosition = new Vector3(i, 0, l);
                }
                else if (id == 4)
                {
                    GameObject bomb2_prefab = Resources.Load<GameObject>("Bomb2");
                    obj = Instantiate(bomb2_prefab);/*GameObject.CreatePrimitive(PrimitiveType.Cube);*/

                    //obj.transform.parent = this.transform;
                    obj.transform.localPosition = new Vector3(i, 0, l);
                }
                else if (id == 5)
                {
                    GameObject tuti2_prefab = Resources.Load<GameObject>("Tuti2");
                    obj = Instantiate(tuti2_prefab);/*GameObject.CreatePrimitive(PrimitiveType.Cube);*/

                    obj.transform.parent = this.transform;
                    obj.transform.localPosition = new Vector3(i, 0, l);
                }
                else if (id == 6)
                {
                    GameObject goal_prefab = Resources.Load<GameObject>("Goal");
                    obj = Instantiate(goal_prefab);/*GameObject.CreatePrimitive(PrimitiveType.Cube);*/

                    obj.transform.parent = this.transform;
                    obj.transform.localPosition = new Vector3(i, 0, l);
                }
                else if (id == 7)
                {
                    GameObject wall_prefab = Resources.Load<GameObject>("Wall Left");
                    obj = Instantiate(wall_prefab);/*GameObject.CreatePrimitive(PrimitiveType.Cube);*/

                    obj.transform.parent = this.transform;
                    obj.transform.localPosition = new Vector3(i, 0, l);
                }
                else if (id == 8)
                {
                    GameObject wall_prefab = Resources.Load<GameObject>("Wall Right");
                    obj = Instantiate(wall_prefab);/*GameObject.CreatePrimitive(PrimitiveType.Cube);*/

                    obj.transform.parent = this.transform;
                    obj.transform.localPosition = new Vector3(i, 0, l);
                }
                else if (id == 9)
                {
                    GameObject wall_prefab = Resources.Load<GameObject>("Wall Bottom");
                    obj = Instantiate(wall_prefab);/*GameObject.CreatePrimitive(PrimitiveType.Cube);*/

                    obj.transform.parent = this.transform;
                    obj.transform.localPosition = new Vector3(i, 0, l);
                }
                else if (id == 10)
                {
                    GameObject wall_prefab = Resources.Load<GameObject>("Wall Top");
                    obj = Instantiate(wall_prefab);/*GameObject.CreatePrimitive(PrimitiveType.Cube);*/

                    obj.transform.parent = this.transform;
                    obj.transform.localPosition = new Vector3(i, 0, l);
                }
            }
        }
    }
}

